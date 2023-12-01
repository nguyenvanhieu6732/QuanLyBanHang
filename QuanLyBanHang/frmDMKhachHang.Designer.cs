namespace QuanLyBanHang
{
    partial class frmDMKhachHang
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
            panel2 = new Panel();
            dgvKhachHang = new DataGridView();
            mtbDienThoai = new MaskedTextBox();
            txtDiaChi = new TextBox();
            txtTenKhach = new TextBox();
            txtMaKhach = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnDong = new Button();
            btnBoqua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(mtbDienThoai);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(txtTenKhach);
            panel2.Controls.Add(txtMaKhach);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 118);
            panel2.TabIndex = 1;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 118);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(800, 232);
            dgvKhachHang.TabIndex = 2;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(565, 71);
            mtbDienThoai.Mask = "(999) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(168, 23);
            mtbDienThoai.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(565, 43);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(168, 23);
            txtDiaChi.TabIndex = 11;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(172, 71);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(168, 23);
            txtTenKhach.TabIndex = 8;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(172, 42);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(168, 23);
            txtMaKhach.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 79);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 14;
            label6.Text = "Điện thoại:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(485, 46);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 13;
            label7.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 79);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 10;
            label3.Text = "Tên khách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 46);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 9;
            label2.Text = "Mã khách:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(336, 7);
            label1.Name = "label1";
            label1.Size = new Size(215, 25);
            label1.TabIndex = 7;
            label1.Text = "Danh Mục Khách Hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDong);
            panel3.Controls.Add(btnBoqua);
            panel3.Controls.Add(btnLuu);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnThem);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 100);
            panel3.TabIndex = 1;
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
            // frmDMKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKhachHang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDMKhachHang";
            Text = "Danh Mục Khách Hàng";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvKhachHang;
        private MaskedTextBox mtbDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenKhach;
        private TextBox txtMaKhach;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Button btnDong;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}