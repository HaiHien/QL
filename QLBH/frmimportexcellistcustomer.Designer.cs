namespace QLBH
{
    partial class frmimportexcellistcustomer
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
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnpath = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(132, 37);
            this.txtpath.Multiline = true;
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(241, 25);
            this.txtpath.TabIndex = 0;
            // 
            // btnpath
            // 
            this.btnpath.Location = new System.Drawing.Point(29, 31);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(75, 31);
            this.btnpath.TabIndex = 1;
            this.btnpath.Text = "path";
            this.btnpath.UseVisualStyleBackColor = true;
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(185, 68);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(75, 36);
            this.btnimport.TabIndex = 2;
            this.btnimport.Text = "Import excel";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // importexcellistcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 127);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.btnpath);
            this.Controls.Add(this.txtpath);
            this.Name = "importexcellistcustomer";
            this.Text = "importexcellistcustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnpath;
        private System.Windows.Forms.Button btnimport;
    }
}