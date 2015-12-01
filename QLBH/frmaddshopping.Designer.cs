namespace QLBH
{
    partial class frmaddshopping
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
            this.lblm = new System.Windows.Forms.Label();
            this.lblp = new System.Windows.Forms.Label();
            this.txtpurchasedate = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.lblpurchasedate = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.lblmoney = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm.ForeColor = System.Drawing.Color.Red;
            this.lblm.Location = new System.Drawing.Point(431, 165);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(46, 18);
            this.lblm.TabIndex = 18;
            this.lblm.Text = "label2";
            this.lblm.Visible = false;
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp.ForeColor = System.Drawing.Color.Red;
            this.lblp.Location = new System.Drawing.Point(431, 56);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(46, 18);
            this.lblp.TabIndex = 17;
            this.lblp.Text = "label1";
            this.lblp.Visible = false;
            // 
            // txtpurchasedate
            // 
            this.txtpurchasedate.Enabled = false;
            this.txtpurchasedate.Location = new System.Drawing.Point(184, 107);
            this.txtpurchasedate.Multiline = true;
            this.txtpurchasedate.Name = "txtpurchasedate";
            this.txtpurchasedate.Size = new System.Drawing.Size(224, 26);
            this.txtpurchasedate.TabIndex = 16;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(184, 49);
            this.txtproductname.Multiline = true;
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(224, 26);
            this.txtproductname.TabIndex = 15;
            // 
            // lblpurchasedate
            // 
            this.lblpurchasedate.AutoSize = true;
            this.lblpurchasedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpurchasedate.Location = new System.Drawing.Point(52, 113);
            this.lblpurchasedate.Name = "lblpurchasedate";
            this.lblpurchasedate.Size = new System.Drawing.Size(107, 18);
            this.lblpurchasedate.TabIndex = 14;
            this.lblpurchasedate.Text = "Purchasedate :";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(52, 56);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(108, 18);
            this.lblproductname.TabIndex = 13;
            this.lblproductname.Text = "ProductName :";
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(184, 158);
            this.txtmoney.Multiline = true;
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(224, 26);
            this.txtmoney.TabIndex = 21;
            this.txtmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmoney_KeyPress);
            // 
            // lblmoney
            // 
            this.lblmoney.AutoSize = true;
            this.lblmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoney.Location = new System.Drawing.Point(52, 165);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(53, 18);
            this.lblmoney.TabIndex = 19;
            this.lblmoney.Text = "Money";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(210, 221);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(84, 32);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(381, 221);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(84, 32);
            this.btncancel.TabIndex = 23;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // frmaddshopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 308);
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
            this.Name = "frmaddshopping";
            this.Text = "frmaddshopping";
            this.Load += new System.EventHandler(this.frmaddshopping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.TextBox txtpurchasedate;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label lblpurchasedate;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
    }
}