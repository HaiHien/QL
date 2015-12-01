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
    public partial class frmimportexcelcustomershopping : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        string filename;

        public frmimportexcelcustomershopping()
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
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename.Trim() + ";Extended Properties=Excel 8.0";
            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Sheet1"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();

                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }
        private void ImportIntoDatabase(DataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Not Data import!");
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

                            MessageBox.Show("Error Import Data!");
                        }
                        finally
                        {

                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("IDcustomer does not exist");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Import Data!");
            }

            MessageBox.Show("Kết thúc import");
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            if (!ValidInput())
                return;

            // Đọc dữ liệu từ tập tin excel trả về DataTable
            DataTable data = ReadDataFromExcelFile();

            // Import dữ liệu đọc được vào database
            ImportIntoDatabase(data);
            this.Hide();
            frmlistcustomer frm = new frmlistcustomer();
            frm.Show();
        }
    }
}
