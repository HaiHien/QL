namespace QLBH
{
    partial class frmSuathongtinmuahang
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.lblmoney = new System.Windows.Forms.Label();
            this.lblm = new System.Windows.Forms.Label();
            this.lblp = new System.Windows.Forms.Label();
            this.txtpurchasedate = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.lblpurchasedate = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(219, 229);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(84, 32);
            this.btncancel.TabIndex = 33;
            this.btncancel.Text = "Thoát";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(107, 229);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(84, 32);
            this.btnsave.TabIndex = 32;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtmoney
            // 
            this.txtmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoney.Location = new System.Drawing.Point(148, 179);
            this.txtmoney.Multiline = true;
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(224, 28);
            this.txtmoney.TabIndex = 31;
            this.txtmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmoney_KeyPress);
            // 
            // lblmoney
            // 
            this.lblmoney.AutoSize = true;
            this.lblmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoney.Location = new System.Drawing.Point(12, 187);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(67, 18);
            this.lblmoney.TabIndex = 30;
            this.lblmoney.Text = "Số Tiền :";
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm.ForeColor = System.Drawing.Color.Red;
            this.lblm.Location = new System.Drawing.Point(145, 157);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(46, 18);
            this.lblm.TabIndex = 29;
            this.lblm.Text = "label2";
            this.lblm.Visible = false;
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp.ForeColor = System.Drawing.Color.Red;
            this.lblp.Location = new System.Drawing.Point(145, 99);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(46, 18);
            this.lblp.TabIndex = 28;
            this.lblp.Text = "label1";
            this.lblp.Visible = false;
            // 
            // txtpurchasedate
            // 
            this.txtpurchasedate.Enabled = false;
            this.txtpurchasedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurchasedate.Location = new System.Drawing.Point(149, 123);
            this.txtpurchasedate.Multiline = true;
            this.txtpurchasedate.Name = "txtpurchasedate";
            this.txtpurchasedate.Size = new System.Drawing.Size(224, 28);
            this.txtpurchasedate.TabIndex = 27;
            // 
            // txtproductname
            // 
            this.txtproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductname.Location = new System.Drawing.Point(148, 70);
            this.txtproductname.Multiline = true;
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(224, 28);
            this.txtproductname.TabIndex = 26;
            // 
            // lblpurchasedate
            // 
            this.lblpurchasedate.AutoSize = true;
            this.lblpurchasedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpurchasedate.Location = new System.Drawing.Point(12, 131);
            this.lblpurchasedate.Name = "lblpurchasedate";
            this.lblpurchasedate.Size = new System.Drawing.Size(83, 18);
            this.lblpurchasedate.TabIndex = 25;
            this.lblpurchasedate.Text = "Ngày Mua :";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(12, 78);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(114, 18);
            this.lblproductname.TabIndex = 24;
            this.lblproductname.Text = "Tên Sản Phẩm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sửa Thông Tin Mua Hàng";
            // 
            // frmSuathongtinmuahang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(415, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.lblmoney);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.txtpurchasedate);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.lblpurchasedate);
            this.Controls.Add(this.lblproductname);
            this.Name = "frmSuathongtinmuahang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thông Tin Mua Hàng";
            this.Load += new System.EventHandler(this.frmeditshopping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.TextBox txtpurchasedate;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label lblpurchasedate;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Label label1;
    }
}