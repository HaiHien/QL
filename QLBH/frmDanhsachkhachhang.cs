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
    public partial class frmDanhsachkhachhang : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        DataTable dt;
        SQLiteDataAdapter da;
        DataSet ds;
        DataTable dtSource;
        int PageCount;
        int maxRec;
        int pageSize;
        int currentPage;
        int recNo;
        public frmDanhsachkhachhang()
        {
            InitializeComponent();
        }
        private void frmdanhsachKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadPage()
        {
            int i;
            int startRec;
            int endRec;
            DataTable dtTemp;

            dtTemp = dtSource.Clone();

            if (currentPage == PageCount)
            {
                endRec = maxRec;
            }
            else
            {
                endRec = pageSize * currentPage;
            }
            startRec = recNo;
            for (i = startRec; i < endRec; i++)
            {
                dtTemp.ImportRow(dtSource.Rows[i]);
                recNo += 1;
            }
            dtgdskh.DataSource = dtTemp;
        }
        private bool CheckFillButton()
        {
            // Check if the user clicks the "Fill Grid" button.
            if (pageSize == 0)
            {
                MessageBox.Show("Set the Page Size, and then click the Fill Grid button!");
                return false;
            }
            else
            {
                return true;
            }
        }


        private void LoadData()
        {
            try
            {
                da = new SQLiteDataAdapter("select * from Listcustomer", conn);
                ds = new DataSet();
                da.Fill(ds, "Listcustomer");
                dtSource = ds.Tables["Listcustomer"];
                pageSize = 3;
                maxRec = dtSource.Rows.Count;
                PageCount = maxRec / pageSize;

                if ((maxRec % pageSize) > 0)
                {
                    PageCount += 1;
                }
                currentPage = 1;
                recNo = 0;

                LoadPage();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Không Thể Load Dữ Liệu!");
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmThemkhachhang frm = new frmThemkhachhang();
            frm.Show();
            this.Hide();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Thông Báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string id = dtgdskh.SelectedRows[0].Cells[0].Value.ToString();
                    ListCustomer list = new ListCustomer();
                    int i = list.DeleteCustomerByID(int.Parse(id));
                    if (i > 0)
                        MessageBox.Show("Xóa Thành Công!");
                    else
                    {
                        MessageBox.Show("Lỗi Không Thể Xóa!");
                    }
                    LoadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi Không Thể Xóa!");
                   
                }
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                frmSuathongtinkhachhang frm = new frmSuathongtinkhachhang();
                frm.id = int.Parse(dtgdskh.SelectedRows[0].Cells[0].Value.ToString());
                frm.name = dtgdskh.SelectedRows[0].Cells[1].Value.ToString();
                frm.phone = dtgdskh.SelectedRows[0].Cells[2].Value.ToString();
                frm.gender = dtgdskh.SelectedRows[0].Cells[3].Value.ToString();
                frm.address = dtgdskh.SelectedRows[0].Cells[4].Value.ToString();
                this.Hide();
                frm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Không Có Dữ Liệu!");
            }
         
        }

        private void txtphone_KeyUp(object sender, KeyEventArgs e)
        {
            string phone = txtphone.Text.Trim();
            try
            {
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Listcustomer where Phone LIKE '%" + phone + "%'", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dtgdskh.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void dtgdskh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            frmimportexceldanhsachKH frm = new frmimportexceldanhsachKH();
            this.Hide();
            frm.Show();
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa?", "Thông Báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string id = dtgdskh.SelectedRows[0].Cells[0].Value.ToString();
                    ListCustomer list = new ListCustomer();
                    int i = list.DeleteCustomerByID(int.Parse(id));
                    if (i > 0)
                        MessageBox.Show("Xóa Thánh Công!");
                    else
                    {
                        MessageBox.Show("Lỗi Không Thể Xóa!");
                    }
                    LoadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi Không Thể Xóa!");

                }

            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSuathongtinkhachhang frm = new frmSuathongtinkhachhang();
                frm.id = int.Parse(dtgdskh.SelectedRows[0].Cells[0].Value.ToString());
                frm.name = dtgdskh.SelectedRows[0].Cells[1].Value.ToString();
                frm.phone = dtgdskh.SelectedRows[0].Cells[2].Value.ToString();
                frm.gender = dtgdskh.SelectedRows[0].Cells[3].Value.ToString();
                frm.address = dtgdskh.SelectedRows[0].Cells[4].Value.ToString();
                this.Hide();
                frm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Không Có Dữ Liệu!");
            }
        }

        private void dtgdskh_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmThongtinmuahang frm = new frmThongtinmuahang();
                frm.id = int.Parse(dtgdskh.SelectedRows[0].Cells[0].Value.ToString());
                frm.name = dtgdskh.SelectedRows[0].Cells[1].Value.ToString();
                frm.phone = dtgdskh.SelectedRows[0].Cells[2].Value.ToString();
                frm.gender = dtgdskh.SelectedRows[0].Cells[3].Value.ToString();
                frm.address = dtgdskh.SelectedRows[0].Cells[4].Value.ToString();
                this.Hide();
                frm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Không Có Dữ Liệu!");
            }
        }

        private void btntrangdau_Click(object sender, EventArgs e)
        {
            btntrangdau.Enabled = false;
            btntrangtruoc.Enabled = false;
            btntrangcuoi.Enabled = true;
            btntrangsau.Enabled = true;
            if (CheckFillButton() == false)
            {
                return;
            }
            if (currentPage == 1)
            {
                MessageBox.Show("You are at the First Page!");
                return;
            }

            currentPage = 1;
            recNo = 0;
            LoadPage();
        }

        private void btntrangsau_Click(object sender, EventArgs e)
        {
            btntrangtruoc.Enabled = true;
            //If the user did not click the "Fill Grid" button, then return.
            if (CheckFillButton() == false)
            {
                return;
            }

            //Check if the user clicks the "Fill Grid" button.
            if (pageSize == 0)
            {
                MessageBox.Show("Set the Page Size, and then click the Fill Grid button!");
                return;
            }

            currentPage += 1;
            if (currentPage > PageCount)
            {
                currentPage = PageCount;
                //Check if you are already at the last page.
                if (recNo == maxRec)
                {
                    btntrangsau.Enabled = false;
                    return;
                }
            }
            LoadPage();
        }

        private void btntrangtruoc_Click(object sender, EventArgs e)
        {
            btntrangsau.Enabled = true;
            btntrangcuoi.Enabled = true;
            if (CheckFillButton() == false)
            {
                return;
            }

            if (currentPage == PageCount)
            {
                recNo = pageSize * (currentPage - 2);
            }

            currentPage -= 1;
            //Check if you are already at the first page.
            if (currentPage < 1)
            {
                btntrangtruoc.Enabled = false;
                currentPage = 1;
                return;
            }
            else
            {
                recNo = pageSize * (currentPage - 1);
            }
            LoadPage();
        }

        private void btntrangcuoi_Click(object sender, EventArgs e)
        {
            btntrangdau.Enabled = true;
            btntrangsau.Enabled = false;
            btntrangcuoi.Enabled = false;
            if (CheckFillButton() == false)
            {
                return;
            }

            //Check if you are already at the last page.
            if (recNo == maxRec)
            {
                MessageBox.Show("You are at the Last Page!");
                return;
            }
            currentPage = PageCount;
            recNo = pageSize * (currentPage - 1);
            LoadPage();
			
        }

    }
}
