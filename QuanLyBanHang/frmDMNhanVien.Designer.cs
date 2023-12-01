namespace QuanLyBanHang
{
    partial class frmDMNhanVien
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
            dgvNhanVien = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            chkGioiTinh = new CheckBox();
            txtDiaChi = new TextBox();
            mtbDienThoai = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            panel3 = new Panel();
            btnDong = new Button();
            btnBoqua = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
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
            panel2.Controls.Add(dtpNgaySinh);
            panel2.Controls.Add(mtbDienThoai);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(chkGioiTinh);
            panel2.Controls.Add(txtTenNhanVien);
            panel2.Controls.Add(txtMaNhanVien);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 143);
            panel2.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 143);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(800, 207);
            dgvNhanVien.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(320, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh Mục Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 39);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 72);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 107);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 107);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 6;
            label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 72);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Điện thoại:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 39);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 4;
            label7.Text = "Địa chỉ:";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(156, 35);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(168, 23);
            txtMaNhanVien.TabIndex = 7;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(156, 64);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(168, 23);
            txtTenNhanVien.TabIndex = 8;
            // 
            // chkGioiTinh
            // 
            chkGioiTinh.AutoSize = true;
            chkGioiTinh.Location = new Point(156, 103);
            chkGioiTinh.Name = "chkGioiTinh";
            chkGioiTinh.Size = new Size(52, 19);
            chkGioiTinh.TabIndex = 9;
            chkGioiTinh.Text = "Nam";
            chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(549, 36);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(168, 23);
            txtDiaChi.TabIndex = 10;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(549, 64);
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(168, 23);
            mtbDienThoai.TabIndex = 11;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(549, 98);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(168, 23);
            dtpNgaySinh.TabIndex = 12;
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
            panel3.TabIndex = 3;
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
            // frmDMNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvNhanVien);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDMNhanVien";
            Text = "Danh Mục Nhân Viên";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvNhanVien;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox mtbDienThoai;
        private TextBox txtDiaChi;
        private CheckBox chkGioiTinh;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private DateTimePicker dtpNgaySinh;
        private Panel panel3;
        private Button btnDong;
        private Button btnBoqua;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}