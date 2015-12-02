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
    public partial class frmSuathongtinkhachhang : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        public int id;
        public string name;
        public string phone;
        public string gender;
        public string address;
        public frmSuathongtinkhachhang()
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
                lbln.Text = "Phải Nhập Tên!";
                lbln.Visible = true;
                str += "n";
            }
            else
            {
                lbln.Visible = false;
            }
            if (phone.Trim().Length == 0)
            {
                lblp.Text = "Phải Nhập Số Điện Thoại!";
                lblp.Visible = true;
                str += "p";
            }
            else if (phone.Trim().Length > 13)
            {
                lblp.Text = "Số Điện Thoại Phải Ít Hơn 13 Số!";
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
                    int i = list.UpdateCustomerByID(id,name,gender,phone,address);
                    if (i > 0)
                    {
                        MessageBox.Show("Sửa Thành Công!");
                        this.Hide();
                        frmDanhsachkhachhang frm = new frmDanhsachkhachhang();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Không Thể Sửa!");
                    }
                
            }
        }

        private void frmeditcustomer_Load(object sender, EventArgs e)
        {
            txtname.Text = name;
            txtphone.Text = phone;
            if (gender.Trim().Equals("Nam") || gender.Trim().Equals("nam"))
            {
                rdbmale.Checked = true;
            }
            else if (gender.Trim().Equals("Nữ") || gender.Trim().Equals("nữ"))
            {
                rdbfemale.Checked = true;
            }
            else
            {

            }
            txtaddress.Text = address;
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmDanhsachkhachhang frm = new frmDanhsachkhachhang();
            this.Hide();
            frm.Show();
            
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
