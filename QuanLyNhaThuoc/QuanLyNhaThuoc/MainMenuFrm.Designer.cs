namespace QuanLyNhaThuoc
{
    partial class MainMenuFrm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBanThuoc = new System.Windows.Forms.Button();
            this.btnNhapThuoc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnBánThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnNhậpThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnNhapThuoc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBanThuoc, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBanThuoc
            // 
            this.btnBanThuoc.Location = new System.Drawing.Point(3, 3);
            this.btnBanThuoc.Name = "btnBanThuoc";
            this.btnBanThuoc.Size = new System.Drawing.Size(414, 108);
            this.btnBanThuoc.TabIndex = 0;
            this.btnBanThuoc.Text = "Quản Lý Hóa Đơn Bán Thuốc";
            this.btnBanThuoc.UseVisualStyleBackColor = true;
            this.btnBanThuoc.Click += new System.EventHandler(this.btnBanThuoc_Click);
            // 
            // btnNhapThuoc
            // 
            this.btnNhapThuoc.Location = new System.Drawing.Point(3, 146);
            this.btnNhapThuoc.Name = "btnNhapThuoc";
            this.btnNhapThuoc.Size = new System.Drawing.Size(414, 108);
            this.btnNhapThuoc.TabIndex = 1;
            this.btnNhapThuoc.Text = "Quản Lý Hóa Đơn Nhập Thuốc";
            this.btnNhapThuoc.UseVisualStyleBackColor = true;
            this.btnNhapThuoc.Click += new System.EventHandler(this.btnNhapThuoc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.liênHệToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHóaĐơnBánThuốcToolStripMenuItem,
            this.quảnLýHóaĐơnNhậpThuốcToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýHóaĐơnBánThuốcToolStripMenuItem
            // 
            this.quảnLýHóaĐơnBánThuốcToolStripMenuItem.Name = "quảnLýHóaĐơnBánThuốcToolStripMenuItem";
            this.quảnLýHóaĐơnBánThuốcToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.quảnLýHóaĐơnBánThuốcToolStripMenuItem.Text = "Quản lý hóa đơn bán thuốc";
            this.quảnLýHóaĐơnBánThuốcToolStripMenuItem.Click += new System.EventHandler(this.quanLyHoaDonBanThuocToolStripMenuItem_Click);
            // 
            // quảnLýHóaĐơnNhậpThuốcToolStripMenuItem
            // 
            this.quảnLýHóaĐơnNhậpThuốcToolStripMenuItem.Name = "quảnLýHóaĐơnNhậpThuốcToolStripMenuItem";
            this.quảnLýHóaĐơnNhậpThuốcToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.quảnLýHóaĐơnNhậpThuốcToolStripMenuItem.Text = "Quản lý hóa đơn nhập thuốc";
            this.quảnLýHóaĐơnNhậpThuốcToolStripMenuItem.Click += new System.EventHandler(this.quanLyHoaDonNhapThuocToolStripMenuItem_Click);
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            // 
            // MainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà thuốc";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBanThuoc;
        private System.Windows.Forms.Button btnNhapThuoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnBánThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnNhậpThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
    }
}