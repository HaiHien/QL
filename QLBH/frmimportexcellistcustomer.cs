using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SQLite;

namespace QLBH
{
    public partial class frmimportexcellistcustomer : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        string filename;
        public frmimportexcellistcustomer()
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
                MessageBox.Show("Không có dữ liệu để import");
                return;
            }
            string name, address, gender;
            int phone;
            try
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    name = data.Rows[i]["Name"].ToString().Trim();
                    phone = int.Parse(data.Rows[i]["Phone"].ToString().Trim());
                    gender = data.Rows[i]["Gender"].ToString().Trim();
                    address = data.Rows[i]["Address"].ToString().Trim();
                    if (gender.Equals("Nam") || gender.Equals("nam") || gender.Equals("Nữ") || gender.Equals("nữ"))
                    {
                        try
                        {
                            string sql = "insert into Listcustomer (Name,Phone,Gender,Address) values(@name,@phone,@gender,@address)";
                            conn.Open();
                            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@phone", phone);
                            cmd.Parameters.AddWithValue("@gender", gender);
                            cmd.Parameters.AddWithValue("@address", address);
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
                        MessageBox.Show("Error import does not exist!");
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
