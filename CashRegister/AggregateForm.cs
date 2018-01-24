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
    public partial class AggregateForm : Form
    {
        public AggregateForm()
        {
            InitializeComponent();
        }

        private void BackMainMenuButton_Click(object sender, EventArgs e)
        {
            //表示フォーム切り替え
            Form ViewForm = new MainMenuForm();
            ViewForm.Show();
            this.Hide();
        }

        private void GetAggregateButton_Click(object sender, EventArgs e)
        {
            using (var con = new OracleConnection(CommonData.constr))
            {
                con.Open();

                using (OracleCommand cmd = con.CreateCommand())
                {
                    //指定された期間の合計を取得する(合計が大きくなるので単価・数量それぞれ取得)
                    cmd.CommandText = "select PRODUCT.PRICE, SALES_DETAILS.QUANTITY " +
                        "from SALES " +
                        "left outer join SALES_DETAILS on SALES.ID = SALES_DETAILS.RELATED_ID " +
                        "left outer join PRODUCT on SALES_DETAILS.PRODUCT_ID = PRODUCT.ID " +
                        "where SALES.SALES_DATE " +
                        "between '" + StartDateTimePicker.Value.ToString("yyyy/MM/dd") + "' and '" + EndDateTimePicker.Value.ToString("yyyy/MM/dd") + "'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        long l = 0;
                        while (reader.Read())
                        {
                            //読み出し結果にnullがなければ単価*数量を合計に+する
                            l += ((reader.IsDBNull(0)) || (reader.IsDBNull(1))) ? 0 : (Convert.ToInt32(reader.GetValue(0)) * Convert.ToInt32(reader.GetValue(1)));
                        }
                        AggregateResultLabel.Text = "￥" + Convert.ToString(l);
                    }
                }

                con.Close();
            }
        }
    }
}
