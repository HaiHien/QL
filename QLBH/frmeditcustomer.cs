﻿using System;
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
    public partial class frmeditcustomer : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=D:\web1\QLBH.s3db");
        public int id;
        public string name;
        public string phone;
        public string gender;
        public string address;
        public frmeditcustomer()
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
                lbln.Text = "must enter the name";
                lbln.Visible = true;
                str += "n";
            }
            else
            {
                lbln.Visible = false;
            }
            if (phone.Trim().Length == 0)
            {
                lblp.Text = "must enter the Phone";
                lblp.Visible = true;
                str += "p";
            }
            else if (phone.Trim().Length > 13)
            {
                lblp.Text = "phone number must be less than 13 numbers";
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
                    int i = list.UpdateCustomerByID(id,name,gender,int.Parse(phone),address);
                    if (i > 0)
                    {
                        MessageBox.Show("Update OK!");
                        this.Hide();
                        frmlistcustomer frm = new frmlistcustomer();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Update Not OK!");
                    }
                
            }
        }

        private void frmeditcustomer_Load(object sender, EventArgs e)
        {
            txtname.Text = name;
            txtphone.Text = phone;
            if (gender.Trim().Equals("Nam") || gender.Trim().Equals("nam"))
            {
                rdbmale.Checked = true;
            }
            else if (gender.Trim().Equals("Nữ") || gender.Trim().Equals("nữ"))
            {
                rdbfemale.Checked = true;
            }
            else
            {

            }
            txtaddress.Text = address;
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmlistcustomer frm = new frmlistcustomer();
            this.Hide();
            frm.Show();
            
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
