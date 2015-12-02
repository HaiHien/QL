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
    public partial class frmThemmuahang : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        public int index;
        public string name;
        public string phone;
        public string gender;
        public string address;
        public frmThemmuahang()
        {
            InitializeComponent();
        }

        private void frmaddshopping_Load(object sender, EventArgs e)
        {
            txtpurchasedate.Text = DateTime.Today.ToShortDateString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string productname = txtproductname.Text;
            string money=txtmoney.Text;
            DateTime purchasedate =Convert.ToDateTime(DateTime.Today.ToShortDateString());
            string str="";
            if (productname.Trim().Length == 0)
            {
                lblp.Text = "Phải Nhập Tên Sản Phẩm!";
                lblp.Visible = true;
                str += "n";
            }
            else
            {
                lblp.Visible = false;
            }
            if (money.Trim().Length == 0)
            {
                lblm.Text = "Phải Nhập Số Tiền!";
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
                int i = c.AddCustomerShopping(productname, purchasedate, money, index);
                if (i > 0)
                {
                    MessageBox.Show("Thêm Mới Thành Công!");
                    this.Hide();
                    frmThongtinmuahang frm = new frmThongtinmuahang();
                    frm.id = index;
                    frm.name = name;
                    frm.address = address;
                    frm.gender = gender;
                    frm.phone = phone;
                    frm.Show();
                    frm.LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi Không Thể Thêm Mới!");
                }
             
            }
        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongtinmuahang frm = new frmThongtinmuahang();
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
