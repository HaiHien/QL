namespace QLBH
{
    partial class frmimportexcelcustomershopping
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
            this.btnimport = new System.Windows.Forms.Button();
            this.btnpath = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(244, 75);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(75, 36);
            this.btnimport.TabIndex = 5;
            this.btnimport.Text = "Import excel";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnpath
            // 
            this.btnpath.Location = new System.Drawing.Point(88, 38);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(75, 31);
            this.btnpath.TabIndex = 4;
            this.btnpath.Text = "path";
            this.btnpath.UseVisualStyleBackColor = true;
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(191, 44);
            this.txtpath.Multiline = true;
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(241, 25);
            this.txtpath.TabIndex = 3;
            // 
            // frmimportexcelcustomershopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 126);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.btnpath);
            this.Controls.Add(this.txtpath);
            this.Name = "frmimportexcelcustomershopping";
            this.Text = "frmimportexcelcustomershopping";
            this.Load += new System.EventHandler(this.frmimportexcelcustomershopping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnpath;
        private System.Windows.Forms.TextBox txtpath;
    }
}