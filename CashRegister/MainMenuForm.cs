using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MCInsertButton_Click(object sender, EventArgs e)
        {
            //表示フォーム切り替え
            Form ViewForm = new InsertForm();
            ViewForm.Show();
            this.Hide();
        }

        private void MCLogViewButton_Click(object sender, EventArgs e)
        {
            //表示フォーム切り替え
            Form ViewForm = new LogViewForm();
            ViewForm.Show();
            this.Hide();
        }

        private void MCAggregateButton_Click(object sender, EventArgs e)
        {
            //表示フォーム切り替え
            Form ViewForm = new AggregateForm();
            ViewForm.Show();
            this.Hide();
        }
    }
}
