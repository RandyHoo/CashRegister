using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace CashRegister
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
            InsertFormInit();
        }

        private void InsertFormInit()
        {
            //InsertDataGridにカラムを設定
            var dt = new DataTable();
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            InsertDataGrid.DataSource = dt;

            //商品名のコンボボックスカラムを作成、要素をセット
            var ProductNameColumn = new DataGridViewComboBoxColumn();
            using (var con = new OracleConnection(CommonData.constr))
            {
                con.Open();

                using (OracleCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select NAME from PRODUCT";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductNameColumn.Items.Add(reader.GetString(0));
                        }
                    }
                }

                con.Close();
            }

            //現在存在しているProductNameカラムと作成したコンボボックスカラムを入れ替え
            ProductNameColumn.DataPropertyName = "ProductName";
            InsertDataGrid.Columns.Insert(InsertDataGrid.Columns["ProductName"].Index, ProductNameColumn);
            InsertDataGrid.Columns.Remove("ProductName");

            //InsertDataGridの列ヘッダーの表示を日本語にする
            var cheaderlist = new List<string> { "商品名", "数量" };
            for (int i = 0; i < InsertDataGrid.Columns.Count; i++)
            {
                InsertDataGrid.Columns[i].HeaderText = cheaderlist[i];
            }
        }

        private void BackMainMenuButton_Click(object sender, EventArgs e)
        {
            //表示フォーム切り替え
            Form ViewForm = new MainMenuForm();
            ViewForm.Show();
            this.Hide();
        }

        private void InputLogButton_Click(object sender, EventArgs e)
        {
            //入力されたデータをリストに変換
            var lnputlist = new List<InsertData>();
            //最後の空行までリストに変換されてしまうのでMAX値は最大行-1
            for (int i = 0; i < InsertDataGrid.Rows.Count - 1; i++)
            {
                lnputlist.Add(new InsertData(InsertDataGrid[0, i].Value, InsertDataGrid[1, i].Value));
            }

            using (var con = new OracleConnection(CommonData.constr))
            {
                con.Open();

                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        //売上に登録
                        string QsaleID = null;
                        cmd.CommandText = "select ID from SALES order by ID";
                        using (var reader = cmd.ExecuteReader())
                        {
                            //最後の要素のID+1をIDにする
                            while (reader.Read())
                            {
                                QsaleID = Convert.ToString(Convert.ToInt32(reader.GetDecimal(0)) + 1);
                            }
                        }

                        //今日の日付取得
                        DateTime dtNow = DateTime.Now;
                        DateTime dtToday = dtNow.Date;

                        cmd.CommandText = "insert into SALES " +
                            "values( " +
                            QsaleID + ", " + //ID
                            "'" + dtToday.ToShortDateString() + "'" + //日付
                            ")";

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            throw new Exception();
                        }

                        //売上詳細を登録
                        foreach (var n in lnputlist)
                        {
                            string QproductID = "";
                            //商品IDを取得
                            cmd.CommandText = "select ID from PRODUCT where NAME = '" + n.Name + "'";
                            using (var reader = cmd.ExecuteReader())
                            {
                                reader.Read();
                                QproductID = Convert.ToString(reader.GetDecimal(0));
                            }

                            cmd.CommandText = "insert into SALES_DETAILS " +
                                "values( " +
                                QsaleID + ", " + //売上テーブルID
                                QproductID + ", " +  //商品ID
                                n.Quantity + //数量
                                ")";

                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                throw new Exception();
                            }
                        }

                        //入力後に表示を初期化する
                        InsertDataGrid.Columns.Clear();
                        InsertFormInit();

                        MessageBox.Show("DBに入力されました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("DBに入力できませんでした。", "結果", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }

                con.Close();
            }
        }

    }

    class InsertData
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public InsertData(object name, object quantity)
        {
            this.Name = (string)name;
            this.Quantity = System.Convert.ToInt32(quantity);
        }

    }
}
