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
    public partial class frmpurchaseinformation : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        DataTable dt;
        public int id;
        public string name;
        public string phone;
        public string gender;
        public string address;
        public frmpurchaseinformation()
        {
            InitializeComponent();
        }

        private void frminfomationcustomer_Load(object sender, EventArgs e)
        {
            txtname.Text = name;
            txtphone.Text = phone;
            if (gender.Trim().Equals("Nam"))
            {
                rdbmale.Checked=true;
            }
            else if (gender.Trim().Equals("Nữ"))
            {
                rdbfemale.Checked = true;
            }
            else
            {

            }
            txtaddress.Text = address;
            LoadData();
            
                 
        }
         public void LoadData()
        {
            string sql = "select ID,Productname,Purchasedate,Money from shoppinglist where IDcustomer=@id";
            try
            {
                conn.Open();
                SQLiteCommand cmd=new SQLiteCommand(sql,conn);
                cmd.Parameters.AddWithValue("@id", id);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dtgmuahang.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you sure you want to delete?", "notice..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string index = dtgmuahang.SelectedRows[0].Cells[0].Value.ToString();
                    Customershopping c = new Customershopping();
                    int i = c.DeleteCustomerShoppingID(int.Parse(index));
                    if (i > 0)
                    {
                        MessageBox.Show("Delete Ok!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Delete Not Ok!");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Delete Not Ok!");
                }
                
                }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmaddshopping frm = new frmaddshopping();
            frm.index = id;
            frm.name = name;
            frm.phone = phone;
            frm.gender = gender;
            frm.address = address;
            this.Hide();
            frm.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                frmeditshopping frm = new frmeditshopping();
                frm.purchasedate = dtgmuahang.SelectedRows[0].Cells[2].Value.ToString();
                frm.productname = dtgmuahang.SelectedRows[0].Cells[1].Value.ToString();
                frm.money = dtgmuahang.SelectedRows[0].Cells[3].Value.ToString();
                frm.index = int.Parse(dtgmuahang.SelectedRows[0].Cells[0].Value.ToString());
                frm.id = id;
                frm.name = name;
                frm.phone = phone;
                frm.gender = gender;
                frm.address = address;
                this.Hide();
                frm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Not Data!");
            }
            
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            frmimportexcelcustomershopping frm = new frmimportexcelcustomershopping();
            this.Hide();
            frm.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmlistcustomer frm = new frmlistcustomer();
            this.Hide();
            frm.Show();
        }
    }
}
