﻿namespace QLBH
{
    partial class frmpurchaseinformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.grbgender = new System.Windows.Forms.GroupBox();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.dtgmuahang = new System.Windows.Forms.DataGridView();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnimport = new System.Windows.Forms.Button();
            this.Btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.grbgender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmuahang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(114, 34);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(225, 26);
            this.txtname.TabIndex = 0;
            // 
            // txtaddress
            // 
            this.txtaddress.Enabled = false;
            this.txtaddress.Location = new System.Drawing.Point(557, 94);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(225, 26);
            this.txtaddress.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(13, 46);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(83, 18);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Full Name :";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(18, 108);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(57, 18);
            this.lblgender.TabIndex = 6;
            this.lblgender.Text = "Gender";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(456, 102);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(62, 18);
            this.lbladdress.TabIndex = 7;
            this.lbladdress.Text = "Address";
            // 
            // grbgender
            // 
            this.grbgender.Controls.Add(this.rdbfemale);
            this.grbgender.Controls.Add(this.rdbmale);
            this.grbgender.Enabled = false;
            this.grbgender.Location = new System.Drawing.Point(119, 90);
            this.grbgender.Name = "grbgender";
            this.grbgender.Size = new System.Drawing.Size(200, 36);
            this.grbgender.TabIndex = 8;
            this.grbgender.TabStop = false;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Location = new System.Drawing.Point(111, 13);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(60, 17);
            this.rdbfemale.TabIndex = 1;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "FeMale";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(17, 13);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(48, 17);
            this.rdbmale.TabIndex = 0;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // dtgmuahang
            // 
            this.dtgmuahang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgmuahang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgmuahang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgmuahang.Location = new System.Drawing.Point(1, 243);
            this.dtgmuahang.Name = "dtgmuahang";
            this.dtgmuahang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgmuahang.Size = new System.Drawing.Size(848, 249);
            this.dtgmuahang.TabIndex = 9;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(456, 46);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(51, 18);
            this.lblphone.TabIndex = 11;
            this.lblphone.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.Enabled = false;
            this.txtphone.Location = new System.Drawing.Point(557, 38);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(225, 26);
            this.txtphone.TabIndex = 10;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(397, 175);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(75, 32);
            this.btnimport.TabIndex = 15;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Location = new System.Drawing.Point(207, 175);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(75, 32);
            this.Btndelete.TabIndex = 14;
            this.Btndelete.Text = "Delete";
            this.Btndelete.UseVisualStyleBackColor = true;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(115, 175);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 32);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(21, 175);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 32);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(304, 175);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 32);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmpurchaseinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 491);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.dtgmuahang);
            this.Controls.Add(this.grbgender);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Name = "frmpurchaseinformation";
            this.Text = "infomationcustomer";
            this.Load += new System.EventHandler(this.frminfomationcustomer_Load);
            this.grbgender.ResumeLayout(false);
            this.grbgender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmuahang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.GroupBox grbgender;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.DataGridView dtgmuahang;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button Btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
    }
}