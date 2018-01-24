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
    public partial class LogViewForm : Form
    {
        public LogViewForm()
        {
            InitializeComponent();

            ViewUpdate();
        }

        private void ViewUpdate()
        {
            using (var con = new OracleConnection(CommonData.constr))
            {
                con.Open();

                using (OracleCommand cmd = con.CreateCommand())
                {
                    //ID一覧を取得
                    var IDList = new List<SalesData>();
                    cmd.CommandText = "select * from SALES";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IDList.Add(new SalesData(reader.GetDecimal(0), reader.GetDateTime(1)));
                        }
                    }

                    //IDごとに売上詳細を取得、リストに挿入
                    var InsertList = new List<LogData>();
                    foreach (var n in IDList)
                    {
                        //合計金額を計算する
                        int total = 0;
                        cmd.CommandText = "select SALES_DETAILS.QUANTITY, PRODUCT.PRICE from SALES_DETAILS " +
                            "left outer join PRODUCT on SALES_DETAILS.PRODUCT_ID = PRODUCT.ID " +
                            "where RELATED_ID = " + n.ID;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                total += (Convert.ToInt32(reader.GetDecimal(0)) * Convert.ToInt32(reader.GetDecimal(1)));
                            }
                        }

                        cmd.CommandText = "select PRODUCT.NAME, SALES_DETAILS.QUANTITY from SALES_DETAILS " +
                            "left outer join PRODUCT on SALES_DETAILS.PRODUCT_ID = PRODUCT.ID " +
                            "where RELATED_ID = " + n.ID;
                        using (var reader = cmd.ExecuteReader())
                        {
                            int isFirst = 1;
                            string str = n.Sales_Date.ToShortDateString();
                            while (reader.Read())
                            {
                                //IDごとの最初のレコードだけID、日付、合計金額を記載する
                                if (isFirst == 1)
                                {
                                    InsertList.Add(new LogData(
                                        n.ID, //ID
                                        str, //日付
                                        total, //合計金額
                                        reader.GetString(0), //商品名
                                        reader.GetDecimal(1) //商品数
                                        ));
                                    isFirst = 0;
                                }
                                else
                                {
                                    InsertList.Add(new LogData(
                                        0, //ID(空欄)
                                        "", //日付(空欄)
                                        0, //合計金額(空欄)
                                        reader.GetString(0), //商品名
                                        reader.GetDecimal(1) //商品数
                                        ));
                                }
                            }
                        }
                    }

                    //全IDの情報を処理できたらDataGridViewに表示する
                    LogGridView.DataSource = InsertList;

                    //LogGridViewの列ヘッダーの表示を日本語にする
                    var cheaderlist = new List<string> { "ID", "日付", "合計金額", "商品名", "商品数" };
                    for (int i = 0; i < LogGridView.Columns.Count; i++)
                    {
                        LogGridView.Columns[i].HeaderText = cheaderlist[i];
                    }

                    //表示幅の自動修正をON
                    LogGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    LogGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    LogGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    LogGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
                }

                con.Close();
            }
        }

        private void BackMainMenuButton_Click(object sender, EventArgs e)
        {
            //表示フォーム切り替え
            Form ViewForm = new MainMenuForm();
            ViewForm.Show();
            this.Hide();
        }

    }

    class LogData
    {
        public string ID { get; set; }

        public string Sales_Date { get; set; }

        public string Total_Fee { get; set; }

        public string Product_Name { get; set; }

        public int Quantity { get; set; }

        public LogData(int id, string sales_date, int total_fee, string product_name, object quantity)
        {
            this.ID = (id == 0) ? "" : Convert.ToString(id);
            this.Sales_Date = sales_date;
            this.Total_Fee = (total_fee == 0) ? "" : Convert.ToString(total_fee);
            this.Product_Name = product_name;
            this.Quantity = Convert.ToInt32(quantity);
        }
    }

    class SalesData
    {
        public int ID { get; set; }
        public DateTime Sales_Date { get; set; }

        public SalesData(object id, DateTime sales_date)
        {
            this.ID = Convert.ToInt32(id);
            this.Sales_Date = sales_date;
        }
    }
}
