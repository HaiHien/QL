using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace QLBH
{
    public partial class frmeditshopping : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        public int id;
        public int index;
        public string name;
        public string phone;
        public string gender;
        public string address;
        public string productname;
        public string money;
        public string purchasedate;
        public frmeditshopping()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string pn = txtproductname.Text;
            string mn = txtmoney.Text;
            string str = "";
            if (pn.Trim().Length == 0)
            {
                lblp.Text = "must enter the productname";
                lblp.Visible = true;
                str += "n";
            }
            else
            {
                lblp.Visible = false;
            }
            if (mn.Trim().Length == 0)
            {
                lblm.Text = "must enter the money";
                lblm.Visible = true;
                str += "p";
            }
            else
            {
                lblm.Visible = false;
            }
            if (str.Trim().Length == 0)
            {
                Customershopping c = new Customershopping();
                int i = c.UpdateCustomerShoppingID(id, productname, money);
                if (i > 0)
                {
                    MessageBox.Show("Update OK!");
                    this.Hide();
                    frmpurchaseinformation frm = new frmpurchaseinformation();
                    frm.id = id;
                    frm.name = name;
                    frm.address = address;
                    frm.gender = gender;
                    frm.phone = phone;
                    frm.Show();
                    frm.LoadData();
                }
                else
                {
                    MessageBox.Show("Update Not OK!");
                }
                
            }
        }

        private void frmeditshopping_Load(object sender, EventArgs e)
        {
            txtpurchasedate.Text = Convert.ToDateTime(purchasedate).ToShortDateString().ToString();
            txtproductname.Text = productname;
            txtmoney.Text = money;
        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmpurchaseinformation frm = new frmpurchaseinformation();
            frm.id = index;
            frm.name = name;
            frm.address = address;
            frm.gender = gender;
            frm.phone = phone;
            frm.Show();
            frm.LoadData();
        }
    }
}
