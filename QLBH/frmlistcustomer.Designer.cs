namespace QLBH
{
    partial class frmlistcustomer
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
            this.components = new System.ComponentModel.Container();
            this.lbldskh = new System.Windows.Forms.Label();
            this.dtgdskh = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.Btndelete = new System.Windows.Forms.Button();
            this.btnimportcustomer = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdskh)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldskh
            // 
            this.lbldskh.AutoSize = true;
            this.lbldskh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldskh.Location = new System.Drawing.Point(378, 21);
            this.lbldskh.Name = "lbldskh";
            this.lbldskh.Size = new System.Drawing.Size(226, 39);
            this.lbldskh.TabIndex = 0;
            this.lbldskh.Text = "List Customer";
            // 
            // dtgdskh
            // 
            this.dtgdskh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgdskh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgdskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdskh.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgdskh.Location = new System.Drawing.Point(3, 151);
            this.dtgdskh.Name = "dtgdskh";
            this.dtgdskh.ReadOnly = true;
            this.dtgdskh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgdskh.Size = new System.Drawing.Size(1026, 475);
            this.dtgdskh.TabIndex = 1;
            this.dtgdskh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdskh_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfomationToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.addToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 114);
            // 
            // viewInfomationToolStripMenuItem
            // 
            this.viewInfomationToolStripMenuItem.Name = "viewInfomationToolStripMenuItem";
            this.viewInfomationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewInfomationToolStripMenuItem.Text = "View infomation";
            this.viewInfomationToolStripMenuItem.Click += new System.EventHandler(this.viewInfomationToolStripMenuItem_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 93);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 32);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(116, 93);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 32);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Location = new System.Drawing.Point(225, 93);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(75, 32);
            this.Btndelete.TabIndex = 4;
            this.Btndelete.Text = "Delete";
            this.Btndelete.UseVisualStyleBackColor = true;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnimportcustomer
            // 
            this.btnimportcustomer.Location = new System.Drawing.Point(454, 93);
            this.btnimportcustomer.Name = "btnimportcustomer";
            this.btnimportcustomer.Size = new System.Drawing.Size(162, 32);
            this.btnimportcustomer.TabIndex = 5;
            this.btnimportcustomer.Text = "Import Customer To Excel";
            this.btnimportcustomer.UseVisualStyleBackColor = true;
            this.btnimportcustomer.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(810, 96);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(187, 30);
            this.txtphone.TabIndex = 7;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            this.txtphone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtphone_KeyUp);
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(686, 101);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(118, 17);
            this.lblsearch.TabIndex = 8;
            this.lblsearch.Text = "Search By Phone";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(337, 93);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 32);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.updateToolStripMenuItem.Text = "Edit";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // frmlistcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 628);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnimportcustomer);
            this.Controls.Add(this.dtgdskh);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.lbldskh);
            this.Controls.Add(this.btnadd);
            this.Name = "frmlistcustomer";
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.frmdanhsachKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdskh)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldskh;
        private System.Windows.Forms.DataGridView dtgdskh;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button Btndelete;
        private System.Windows.Forms.Button btnimportcustomer;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewInfomationToolStripMenuItem;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}

