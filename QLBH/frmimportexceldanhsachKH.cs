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
using Excel = Microsoft.Office.Interop.Excel; 
namespace QLBH
{
    public partial class frmimportexceldanhsachKH : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        string filename;
        public frmimportexceldanhsachKH()
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
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
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
            return data;
        }
        private void ImportIntoDatabase(DataTable data)
        {
            OleDbConnection MyConnection;
            OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
            MyConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtpath.Text.Trim() + ";Extended Properties=Excel 8.0");
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để import");
                return;
            }
            string name, address, gender,phone,result;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    name = data.Rows[i]["Name"].ToString().Trim();
                    phone = data.Rows[i]["Phone"].ToString().Trim();
                    result = data.Rows[i]["Result"].ToString().Trim();
                    try
                    {
                        int p = int.Parse(phone);
                    }
                    catch (Exception)
                    {
                    }
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
                            if (result.Trim().Length < 1)
                                try
                                {

                                    MyConnection.Open();
                                    myCommand.Connection = MyConnection;
                                    string sqlexcel = "Insert into [Sheet1$] (Result) values('Thành Công')";
                                    myCommand.CommandText = sqlexcel;
                                    myCommand.ExecuteNonQuery();
                                    MyConnection.Close();
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                        catch (Exception)
                        {
                        }
                        finally
                        {

                            conn.Close();
                        }
                    }
                    else
                    {
                            try
                            {

                                MyConnection.Open();
                                myCommand.Connection = MyConnection;
                                string sqlexcel = "Insert into [Sheet1$] (Result) values('Thất Bại')";
                                myCommand.CommandText = sqlexcel;
                                myCommand.ExecuteNonQuery();
                                MyConnection.Close();
                            }
                            catch (Exception ex)
                            {
                            }
                        
                    }
                }
                MessageBox.Show("Kết Thúc Import!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmDanhsachkhachhang frm = new frmDanhsachkhachhang();
            this.Hide();
            frm.Show();
        }
    }
}
