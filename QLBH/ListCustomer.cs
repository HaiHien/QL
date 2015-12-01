using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace QLBH
{
    class ListCustomer
    {
        public SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        public int  DeleteCustomerByID(int id)
        {
            string sql = "delete from Listcustomer where ID=@id";
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return 1;
        }
        public int UpdateCustomerByID(int id,string name,string gender,int phone,string address)
        {
            string sql = "update Listcustomer set Name=@name,Phone=@phone,Gender=@gender,Address=@address where ID=@id";
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return 1;
        }
        public int AddCustomer(string name, int phone, string gender , string address)
        {
            string sql = "insert into Listcustomer (Name,Phone,Gender,Address) values(@name,@phone,@gender,@address)";
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return 1;
        }
    }
}
