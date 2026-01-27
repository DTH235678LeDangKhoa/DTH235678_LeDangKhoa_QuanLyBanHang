namespace QuanLyBanHang.Forms
{
    partial class frmKhachHang
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
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            txtHoVaTen = new TextBox();
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HovaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1134, 50);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 0;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1134, 102);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(1134, 154);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.MenuHighlight;
            btnLuu.Location = new Point(1290, 50);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1290, 102);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(150, 46);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "HuyBo";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1290, 154);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button1_Click_1;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1446, 102);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(150, 46);
            btnNhap.TabIndex = 7;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1446, 154);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 46);
            btnXuat.TabIndex = 8;
            btnXuat.Text = "Xuat";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(294, 58);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(295, 39);
            txtHoVaTen.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(834, 60);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(256, 39);
            txtDienThoai.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(294, 134);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(796, 39);
            txtDiaChi.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 58);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 12;
            label1.Text = "Ho va ten (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 128);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 13;
            label2.Text = "Dia chi:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(680, 57);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 14;
            label3.Text = "Dien Thoai:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 9);
            label5.Name = "label5";
            label5.Size = new Size(249, 32);
            label5.TabIndex = 16;
            label5.Text = "Thong tin khach hang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 268);
            label4.Name = "label4";
            label4.Size = new Size(256, 32);
            label4.TabIndex = 17;
            label4.Text = "Danh sach khach hang";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, HovaTen, DienThoai, DiaChi });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1653, 640);
            dataGridView1.TabIndex = 18;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            // 
            // HovaTen
            // 
            HovaTen.DataPropertyName = "HoVaTen";
            HovaTen.HeaderText = "Ho va Ten";
            HovaTen.MinimumWidth = 10;
            HovaTen.Name = "HovaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Dien Thoai";
            DienThoai.MinimumWidth = 10;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Dia Chi";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1446, 50);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "TimKiem";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 955);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDiaChi);
            Controls.Add(txtDienThoai);
            Controls.Add(txtHoVaTen);
            Controls.Add(btnXuat);
            Controls.Add(btnNhap);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "frmKhachHang";
            Text = "Khach Hang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnNhap;
        private Button btnXuat;
        private TextBox txtHoVaTen;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HovaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private Button btnTimKiem;
    }
}