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
    public partial class frmaddcustomer : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        public frmaddcustomer()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string phone = txtphone.Text;
            string gender;
            if (rdbmale.Checked)
            {
                gender = "Nam";
            }
            else if (rdbfemale.Checked)
            {
                gender = "Nữ";
            }
            else
            {
                gender = null;
            }
            string address = txtaddress.Text;
            string str = "";
            if (name.Trim().Length == 0)
            {
                lbln.Text = "must enter the name";
                lbln.Visible = true;
                str += "n";
            }
            else
            {
                lbln.Visible = false;
            }
            if (phone.Trim().Length == 0)
            {
                lblp.Text = "must enter the Phone";
                lblp.Visible = true;
                str += "p";
            }
            else if (phone.Trim().Length > 13)
            {
                lblp.Text = "phone number must be less than 13 numbers";
                lblp.Visible = true;
                str += "p";
            }
            else
            {
                lblp.Visible = false;
            }
                if (str.Trim().Length == 0)
                {
                    ListCustomer list = new ListCustomer();
                    int i = list.AddCustomer(name, int.Parse(phone), gender, address);
                    if (i > 0)
                    {
                        MessageBox.Show("Insert Ok!");
                        this.Hide();
                        frmlistcustomer frm = new frmlistcustomer();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Insert Not Ok!");
                    }
                 
                }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlistcustomer frm = new frmlistcustomer();
            frm.Show();
        }
    }
}
