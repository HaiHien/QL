using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.OleDb;

namespace QLBH
{
    public partial class frmimportexcelthongtinmuahang : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        string filename;
        public int id;
        public string name;
        public string phone;
        public string gender;
        public string address;
        public frmimportexcelthongtinmuahang()
        {
            InitializeComponent();
        }

        private void btnpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = fbd.FileName;
                filename = fbd.FileName;
            }
        }
        private bool ValidInput()
        {
            if (filename.Trim() == "")
            {
                MessageBox.Show("Xin vui lòng chọn tập tin excel cần import");
                return false;
            }
            return true;
        }
        private DataTable ReadDataFromExcelFile()
        {
            DataTable data = null;
            try
            {
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename.Trim() + ";Extended Properties=Excel 8.0";
                OleDbConnection oledbConn = new OleDbConnection(connectionString);
                try
                {
                    oledbConn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);
                    OleDbDataAdapter oleda = new OleDbDataAdapter();

                    oleda.SelectCommand = cmd;

                    DataSet ds = new DataSet();

                    oleda.Fill(ds);

                    data = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn Phải Mở File Excel Cần Import!");
                }
                finally
                {
                    oledbConn.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Import Dữ Liệu!");
            }
            return data;
        }
        private void ImportIntoDatabase(DataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Không Có Dữ Liệu Import!");
                return;
            }
            string productname;
            DateTime purchasedate;
            int idcustomer;
            float money;
            try
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    idcustomer = int.Parse(data.Rows[i]["IDcustomer"].ToString().Trim());
                    purchasedate = DateTime.Parse(data.Rows[i]["Purchasedate"].ToString().Trim());
                    productname = data.Rows[i]["Productname"].ToString().Trim();
                    money = float.Parse(data.Rows[i]["Money"].ToString().Trim());
                    Customershopping c = new Customershopping();
                    int j = c.CheckcustomerID(idcustomer);
                    if (j > 0)
                    {
                        try
                        {
                            string sql = "insert into shoppinglist (Productname,Purchasedate,Money,IDcustomer) values(@productname,@purchasedate,@money,@idcustomer)";
                            conn.Open();
                            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@productname", productname);
                            cmd.Parameters.AddWithValue("@purchasedate", purchasedate);
                            cmd.Parameters.AddWithValue("@money", money);
                            cmd.Parameters.AddWithValue("@idcustomer", idcustomer);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Lỗi Không Thể Import Dữ Liệu!");
                        }
                        finally
                        {

                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("IDcustomer Không Tồn Tại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Không Thể Import Dữ Liệu!");
            }

            MessageBox.Show("Kết Thúc Import");
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            if (txtpath.Text.Trim().Length > 0)
            {
                if (!ValidInput())
                    return;
                DataTable data = ReadDataFromExcelFile();
                ImportIntoDatabase(data);
                this.Hide();
                frmDanhsachkhachhang frm = new frmDanhsachkhachhang();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn Phải Chọn Đưuòng Dẫn");
            }
        }

        private void frmimportexcelcustomershopping_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongtinmuahang frm = new frmThongtinmuahang();
            frm.id = id;
            frm.name = name;
            frm.address = address;
            frm.gender = gender;
            frm.phone = phone;
            frm.LoadData();
            frm.Show();
        }
    }
}
