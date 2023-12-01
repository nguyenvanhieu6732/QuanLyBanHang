namespace QuanLyBanHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem1 = new ToolStripMenuItem();
            khachToolStripMenuItem = new ToolStripMenuItem();
            hàngHóaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, danhMụcToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(57, 20);
            mnuFile.Text = "&Tệp Tin";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(180, 22);
            mnuThoat.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem, nhânViênToolStripMenuItem1, khachToolStripMenuItem, hàngHóaToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(74, 20);
            danhMụcToolStripMenuItem.Text = "&Danh mục";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(180, 22);
            nhânViênToolStripMenuItem.Text = "&Chất liệu";
            // 
            // nhânViênToolStripMenuItem1
            // 
            nhânViênToolStripMenuItem1.Name = "nhânViênToolStripMenuItem1";
            nhânViênToolStripMenuItem1.Size = new Size(180, 22);
            nhânViênToolStripMenuItem1.Text = "&Nhân viên";
            // 
            // khachToolStripMenuItem
            // 
            khachToolStripMenuItem.Name = "khachToolStripMenuItem";
            khachToolStripMenuItem.Size = new Size(137, 22);
            khachToolStripMenuItem.Text = "&Khách hàng";
            // 
            // hàngHóaToolStripMenuItem
            // 
            hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            hàngHóaToolStripMenuItem.Size = new Size(137, 22);
            hàngHóaToolStripMenuItem.Text = "&Hàng hóa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản Lý Của Hàng Đồ Gia Dụng Ciu Ciu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem1;
        private ToolStripMenuItem khachToolStripMenuItem;
        private ToolStripMenuItem hàngHóaToolStripMenuItem;
    }
}
