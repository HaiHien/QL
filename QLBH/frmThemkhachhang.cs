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
    public partial class frmThemkhachhang : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        public frmThemkhachhang()
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
                    int i = list.AddCustomer(name,phone, gender, address);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm Mới Thành Công!");
                        this.Hide();
                        frmDanhsachkhachhang frm = new frmDanhsachkhachhang();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("lỗi Không Thể Thêm Mới!");
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
            frmDanhsachkhachhang frm = new frmDanhsachkhachhang();
            frm.Show();
        }
    }
}
