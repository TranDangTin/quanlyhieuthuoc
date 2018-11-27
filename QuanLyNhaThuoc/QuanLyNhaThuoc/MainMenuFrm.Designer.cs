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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBanThuoc = new System.Windows.Forms.Button();
            this.btnNhapThuoc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnThongKe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBanThuoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNhapThuoc, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(120, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(3, 128);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(192, 108);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 108);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBanThuoc
            // 
            this.btnBanThuoc.Location = new System.Drawing.Point(3, 3);
            this.btnBanThuoc.Name = "btnBanThuoc";
            this.btnBanThuoc.Size = new System.Drawing.Size(192, 108);
            this.btnBanThuoc.TabIndex = 0;
            this.btnBanThuoc.Text = "Quản Lý Hóa Đơn Bán Thuốc";
            this.btnBanThuoc.UseVisualStyleBackColor = true;
            this.btnBanThuoc.Click += new System.EventHandler(this.btnBanThuoc_Click);
            // 
            // btnNhapThuoc
            // 
            this.btnNhapThuoc.Location = new System.Drawing.Point(213, 3);
            this.btnNhapThuoc.Name = "btnNhapThuoc";
            this.btnNhapThuoc.Size = new System.Drawing.Size(192, 108);
            this.btnNhapThuoc.TabIndex = 1;
            this.btnNhapThuoc.Text = "Quản Lý Hóa Đơn Nhập Thuốc";
            this.btnNhapThuoc.UseVisualStyleBackColor = true;
            this.btnNhapThuoc.Click += new System.EventHandler(this.btnNhapThuoc_Click);
            // 
            // MainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà thuốc";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBanThuoc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNhapThuoc;
        private System.Windows.Forms.Button btnThongKe;
    }
}