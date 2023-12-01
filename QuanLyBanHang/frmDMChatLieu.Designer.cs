namespace QuanLyBanHang
{
    partial class frmDMChatLieu
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
            panel1 = new Panel();
            btnDong = new Button();
            btnBoqua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            txtTenChatLieu = new TextBox();
            txtMaChatLieu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvChatLieu = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnBoqua);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 2;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(683, 35);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(75, 23);
            btnDong.TabIndex = 5;
            btnDong.Text = "&Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            btnBoqua.Location = new Point(558, 35);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new Size(75, 23);
            btnBoqua.TabIndex = 4;
            btnBoqua.Text = "&Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(433, 35);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "&Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(308, 35);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 2;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(183, 35);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(58, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 0;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTenChatLieu);
            panel2.Controls.Add(txtMaChatLieu);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 0;
            // 
            // txtTenChatLieu
            // 
            txtTenChatLieu.Location = new Point(114, 59);
            txtTenChatLieu.Name = "txtTenChatLieu";
            txtTenChatLieu.Size = new Size(188, 23);
            txtTenChatLieu.TabIndex = 1;
            // 
            // txtMaChatLieu
            // 
            txtMaChatLieu.Location = new Point(114, 30);
            txtMaChatLieu.Name = "txtMaChatLieu";
            txtMaChatLieu.Size = new Size(188, 23);
            txtMaChatLieu.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên chất liệu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã chất liệu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(352, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh Mục Chất Liệu";
            // 
            // dgvChatLieu
            // 
            dgvChatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChatLieu.Dock = DockStyle.Fill;
            dgvChatLieu.Location = new Point(0, 100);
            dgvChatLieu.Name = "dgvChatLieu";
            dgvChatLieu.Size = new Size(800, 250);
            dgvChatLieu.TabIndex = 1;
            // 
            // frmDMChatLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvChatLieu);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDMChatLieu";
            Text = "Danh Mục Chất Liệu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDong;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private Label label1;
        private DataGridView dgvChatLieu;
        private TextBox txtTenChatLieu;
        private TextBox txtMaChatLieu;
        private Label label3;
        private Label label2;
    }
}