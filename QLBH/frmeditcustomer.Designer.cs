﻿namespace QLBH
{
    partial class frmeditcustomer
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
            this.lblphone = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.grbgender = new System.Windows.Forms.GroupBox();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblp = new System.Windows.Forms.Label();
            this.lbln = new System.Windows.Forms.Label();
            this.grbgender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(36, 132);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(51, 18);
            this.lblphone.TabIndex = 19;
            this.lblphone.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(159, 124);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(225, 26);
            this.txtphone.TabIndex = 18;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // grbgender
            // 
            this.grbgender.Controls.Add(this.rdbfemale);
            this.grbgender.Controls.Add(this.rdbmale);
            this.grbgender.Location = new System.Drawing.Point(159, 174);
            this.grbgender.Name = "grbgender";
            this.grbgender.Size = new System.Drawing.Size(200, 36);
            this.grbgender.TabIndex = 17;
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
            this.rdbmale.Location = new System.Drawing.Point(21, 13);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(48, 17);
            this.rdbmale.TabIndex = 0;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(36, 246);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(62, 18);
            this.lbladdress.TabIndex = 16;
            this.lbladdress.Text = "Address";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(36, 192);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(57, 18);
            this.lblgender.TabIndex = 15;
            this.lblgender.Text = "Gender";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(36, 73);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(83, 18);
            this.lblname.TabIndex = 14;
            this.lblname.Text = "Full Name :";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(159, 238);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(225, 26);
            this.txtaddress.TabIndex = 13;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(159, 65);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(225, 26);
            this.txtname.TabIndex = 12;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(366, 308);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(92, 35);
            this.btncancel.TabIndex = 21;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(159, 308);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 35);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp.ForeColor = System.Drawing.Color.Red;
            this.lblp.Location = new System.Drawing.Point(403, 132);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(46, 18);
            this.lblp.TabIndex = 23;
            this.lblp.Text = "label2";
            this.lblp.Visible = false;
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln.ForeColor = System.Drawing.Color.Red;
            this.lbln.Location = new System.Drawing.Point(403, 73);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(46, 18);
            this.lbln.TabIndex = 22;
            this.lbln.Text = "label1";
            this.lbln.Visible = false;
            // 
            // frmeditcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 394);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.lbln);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.grbgender);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Name = "frmeditcustomer";
            this.Text = "Frmeditcustomer";
            this.Load += new System.EventHandler(this.frmeditcustomer_Load);
            this.grbgender.ResumeLayout(false);
            this.grbgender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.GroupBox grbgender;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.Label lbln;

    }
}