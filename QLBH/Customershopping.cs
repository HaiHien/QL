using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace QLBH
{
    class Customershopping
    {
        public SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        public int DeleteCustomerShoppingID(int id)
        {
            string sql = "delete from shoppinglist where ID=@id";
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
        public int UpdateCustomerShoppingID(int id, string pn, string mn)
        {
            string sql = "update shoppinglist set Productname=@productname,Money=@money where ID=@id";
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@productname", pn);
                cmd.Parameters.AddWithValue("@money", mn);
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
        public int AddCustomerShopping(string productname, DateTime purchasedate, string money, int index)
        {
            string sql = "insert into shoppinglist (Productname,Purchasedate,Money,IDcustomer) values(@productname,@purchasedate,@money,@idcustomer)";
            try
            {          
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@productname", productname);
                cmd.Parameters.AddWithValue("@purchasedate", purchasedate);
                cmd.Parameters.AddWithValue("@money", money);
                cmd.Parameters.AddWithValue("@idcustomer", index);
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
        public int CheckcustomerID(int customerid)
        {
            string sql = "select * from Listcustomer where ID=@customerid ";
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@customerid", customerid);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                if (dt.Rows.Count>0)
                    return 1;
                else
                    return 0;
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
