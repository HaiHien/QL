namespace QLBH
{
    partial class frmDanhsachkhachhang
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
            this.dtgdskh = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.Btndelete = new System.Windows.Forms.Button();
            this.btnimportcustomer = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lbldskh = new System.Windows.Forms.Label();
            this.btntrangsau = new System.Windows.Forms.Button();
            this.btntrangdau = new System.Windows.Forms.Button();
            this.btntrangtruoc = new System.Windows.Forms.Button();
            this.btntrangcuoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdskh)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.dtgdskh.Size = new System.Drawing.Size(1026, 428);
            this.dtgdskh.TabIndex = 1;
            this.dtgdskh.DoubleClick += new System.EventHandler(this.dtgdskh_DoubleClick);
            this.dtgdskh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdskh_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.updateToolStripMenuItem.Text = "Sửa";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(12, 93);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 32);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(93, 93);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 32);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndelete.Location = new System.Drawing.Point(174, 94);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(75, 32);
            this.Btndelete.TabIndex = 4;
            this.Btndelete.Text = "Xóa";
            this.Btndelete.UseVisualStyleBackColor = true;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnimportcustomer
            // 
            this.btnimportcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportcustomer.Location = new System.Drawing.Point(255, 95);
            this.btnimportcustomer.Name = "btnimportcustomer";
            this.btnimportcustomer.Size = new System.Drawing.Size(162, 32);
            this.btnimportcustomer.TabIndex = 5;
            this.btnimportcustomer.Text = "Import Dữ liệu Từ Excel";
            this.btnimportcustomer.UseVisualStyleBackColor = true;
            this.btnimportcustomer.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(840, 98);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(187, 28);
            this.txtphone.TabIndex = 7;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            this.txtphone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtphone_KeyUp);
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(757, 101);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(66, 17);
            this.lblsearch.TabIndex = 8;
            this.lblsearch.Text = "Tìm Kiếm";
            // 
            // lbldskh
            // 
            this.lbldskh.AutoSize = true;
            this.lbldskh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldskh.Location = new System.Drawing.Point(12, 20);
            this.lbldskh.Name = "lbldskh";
            this.lbldskh.Size = new System.Drawing.Size(383, 39);
            this.lbldskh.TabIndex = 10;
            this.lbldskh.Text = "Danh Sách Khách Hàng";
            // 
            // btntrangsau
            // 
            this.btntrangsau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrangsau.Location = new System.Drawing.Point(402, 585);
            this.btntrangsau.Name = "btntrangsau";
            this.btntrangsau.Size = new System.Drawing.Size(100, 32);
            this.btntrangsau.TabIndex = 14;
            this.btntrangsau.Text = ">>";
            this.btntrangsau.UseVisualStyleBackColor = true;
            this.btntrangsau.Click += new System.EventHandler(this.btntrangsau_Click);
            // 
            // btntrangdau
            // 
            this.btntrangdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrangdau.Location = new System.Drawing.Point(303, 585);
            this.btntrangdau.Name = "btntrangdau";
            this.btntrangdau.Size = new System.Drawing.Size(75, 32);
            this.btntrangdau.TabIndex = 13;
            this.btntrangdau.Text = "Trang Đầu";
            this.btntrangdau.UseVisualStyleBackColor = true;
            this.btntrangdau.Click += new System.EventHandler(this.btntrangdau_Click);
            // 
            // btntrangtruoc
            // 
            this.btntrangtruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrangtruoc.Location = new System.Drawing.Point(526, 585);
            this.btntrangtruoc.Name = "btntrangtruoc";
            this.btntrangtruoc.Size = new System.Drawing.Size(100, 32);
            this.btntrangtruoc.TabIndex = 15;
            this.btntrangtruoc.Text = "<<";
            this.btntrangtruoc.UseVisualStyleBackColor = true;
            this.btntrangtruoc.Click += new System.EventHandler(this.btntrangtruoc_Click);
            // 
            // btntrangcuoi
            // 
            this.btntrangcuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrangcuoi.Location = new System.Drawing.Point(650, 585);
            this.btntrangcuoi.Name = "btntrangcuoi";
            this.btntrangcuoi.Size = new System.Drawing.Size(94, 32);
            this.btntrangcuoi.TabIndex = 16;
            this.btntrangcuoi.Text = "Trang Cuối";
            this.btntrangcuoi.UseVisualStyleBackColor = true;
            this.btntrangcuoi.Click += new System.EventHandler(this.btntrangcuoi_Click);
            // 
            // frmDanhsachkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1031, 628);
            this.Controls.Add(this.btntrangcuoi);
            this.Controls.Add(this.btntrangtruoc);
            this.Controls.Add(this.btntrangsau);
            this.Controls.Add(this.btntrangdau);
            this.Controls.Add(this.lbldskh);
            this.Controls.Add(this.dtgdskh);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.btnimportcustomer);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Name = "frmDanhsachkhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.frmdanhsachKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdskh)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgdskh;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button Btndelete;
        private System.Windows.Forms.Button btnimportcustomer;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Label lbldskh;
        private System.Windows.Forms.Button btntrangsau;
        private System.Windows.Forms.Button btntrangdau;
        private System.Windows.Forms.Button btntrangtruoc;
        private System.Windows.Forms.Button btntrangcuoi;
    }
}

