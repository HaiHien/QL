﻿namespace QLBH
{
    partial class frmThemkhachhang
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.lblp = new System.Windows.Forms.Label();
            this.lbln = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(12, 80);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(126, 18);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Tên Khách Hàng :";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(12, 132);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(110, 18);
            this.lblphone.TabIndex = 1;
            this.lblphone.Text = "Số Điện Thoại :";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(12, 189);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(75, 18);
            this.lblgender.TabIndex = 2;
            this.lblgender.Text = "Giới Tính :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(12, 237);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(64, 18);
            this.lbladdress.TabIndex = 3;
            this.lbladdress.Text = "Địa Chỉ :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(141, 70);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(224, 28);
            this.txtname.TabIndex = 4;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(141, 122);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(224, 28);
            this.txtphone.TabIndex = 5;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(141, 227);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(224, 28);
            this.txtaddress.TabIndex = 7;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(101, 285);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 32);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(232, 285);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(92, 32);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Thoát";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbfemale);
            this.groupBox1.Controls.Add(this.rdbmale);
            this.groupBox1.Location = new System.Drawing.Point(141, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 36);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Location = new System.Drawing.Point(106, 14);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(39, 17);
            this.rdbfemale.TabIndex = 1;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Nữ";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(15, 14);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(47, 17);
            this.rdbmale.TabIndex = 0;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Nam";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp.ForeColor = System.Drawing.Color.Red;
            this.lblp.Location = new System.Drawing.Point(138, 151);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(46, 18);
            this.lblp.TabIndex = 12;
            this.lblp.Text = "label2";
            this.lblp.Visible = false;
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln.ForeColor = System.Drawing.Color.Red;
            this.lbln.Location = new System.Drawing.Point(138, 99);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(46, 18);
            this.lbln.TabIndex = 11;
            this.lbln.Text = "label1";
            this.lbln.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thêm Khách Hàng";
            // 
            // frmThemkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(415, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.lbln);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblname);
            this.Name = "frmThemkhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khách Hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.Label label1;
    }
}