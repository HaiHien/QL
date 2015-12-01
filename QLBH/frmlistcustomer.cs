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
    public partial class frmlistcustomer : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        DataTable dt;
        public frmlistcustomer()
        {
            InitializeComponent();
        }

        private void frmdanhsachKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Listcustomer", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dtgdskh.DataSource = dt;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmaddcustomer frm = new frmaddcustomer();
            frm.Show();
            this.Hide();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you sure you want to delete?", "notice..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string id = dtgdskh.SelectedRows[0].Cells[0].Value.ToString();
                    ListCustomer list = new ListCustomer();
                    int i = list.DeleteCustomerByID(int.Parse(id));
                    if (i > 0)
                        MessageBox.Show("Delete OK!");
                    else
                    {
                        MessageBox.Show("Delete Not OK!");
                    }
                    LoadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Delete Not OK!");
                   
                }
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void viewInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmpurchaseinformation frm = new frmpurchaseinformation();
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

                MessageBox.Show("View infomation Error!");
            }
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                frmeditcustomer frm = new frmeditcustomer();
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

                MessageBox.Show("Not Data!");
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

                MessageBox.Show("error!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgdskh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            frmimportexcellistcustomer frm = new frmimportexcellistcustomer();
            this.Hide();
            frm.Show();
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string id = dtgdskh.SelectedRows[0].Cells[0].Value.ToString();
                    ListCustomer list = new ListCustomer();
                    int i = list.DeleteCustomerByID(int.Parse(id));
                    if (i > 0)
                        MessageBox.Show("Delete OK!");
                    else
                    {
                        MessageBox.Show("Delete Not OK!");
                    }
                    LoadData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Delete Not OK!");

                }

            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaddcustomer frm = new frmaddcustomer();
            frm.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmeditcustomer frm = new frmeditcustomer();
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

                MessageBox.Show("Not Data!");
            }
        }
    }
}
