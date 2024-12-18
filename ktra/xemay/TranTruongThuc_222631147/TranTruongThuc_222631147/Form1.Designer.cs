namespace TranTruongThuc_222631147
{
	partial class btnThemAnh
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
			this.dgvDanhSach = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnXuat = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.txtSoKhung = new System.Windows.Forms.TextBox();
			this.txtSoMay = new System.Windows.Forms.TextBox();
			this.txtMau = new System.Windows.Forms.TextBox();
			this.txtHangXe = new System.Windows.Forms.TextBox();
			this.txtTenXe = new System.Windows.Forms.TextBox();
			this.cbDungTichXiLanh = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDanhSach
			// 
			this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSach.Location = new System.Drawing.Point(12, 406);
			this.dgvDanhSach.Name = "dgvDanhSach";
			this.dgvDanhSach.RowHeadersWidth = 51;
			this.dgvDanhSach.RowTemplate.Height = 24;
			this.dgvDanhSach.Size = new System.Drawing.Size(786, 239);
			this.dgvDanhSach.TabIndex = 0;
			this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Số Khung";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Số máy\r\n";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Màu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Dung Tích Xi Lanh";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 283);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Hãng Xe";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 343);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 16);
			this.label6.TabIndex = 6;
			this.label6.Text = "Tên Xe";
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(895, 44);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(124, 36);
			this.btnThem.TabIndex = 7;
			this.btnThem.Text = "Thêm vào CSDL";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(913, 142);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(90, 36);
			this.btnSua.TabIndex = 8;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(913, 223);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(90, 36);
			this.btnXoa.TabIndex = 9;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Location = new System.Drawing.Point(913, 305);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(90, 36);
			this.btnLamMoi.TabIndex = 10;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnXuat
			// 
			this.btnXuat.Location = new System.Drawing.Point(907, 406);
			this.btnXuat.Name = "btnXuat";
			this.btnXuat.Size = new System.Drawing.Size(125, 36);
			this.btnXuat.TabIndex = 11;
			this.btnXuat.Text = "Xuất Theo Hãng";
			this.btnXuat.UseVisualStyleBackColor = true;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(913, 497);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(119, 36);
			this.btnTim.TabIndex = 12;
			this.btnTim.Text = "Tìm(màu,Hãng)";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(913, 589);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(90, 36);
			this.btnThoat.TabIndex = 13;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// txtSoKhung
			// 
			this.txtSoKhung.Location = new System.Drawing.Point(154, 44);
			this.txtSoKhung.Name = "txtSoKhung";
			this.txtSoKhung.Size = new System.Drawing.Size(470, 22);
			this.txtSoKhung.TabIndex = 14;
			// 
			// txtSoMay
			// 
			this.txtSoMay.Location = new System.Drawing.Point(154, 107);
			this.txtSoMay.Name = "txtSoMay";
			this.txtSoMay.Size = new System.Drawing.Size(470, 22);
			this.txtSoMay.TabIndex = 15;
			// 
			// txtMau
			// 
			this.txtMau.Location = new System.Drawing.Point(154, 159);
			this.txtMau.Name = "txtMau";
			this.txtMau.Size = new System.Drawing.Size(470, 22);
			this.txtMau.TabIndex = 16;
			// 
			// txtHangXe
			// 
			this.txtHangXe.Location = new System.Drawing.Point(154, 283);
			this.txtHangXe.Name = "txtHangXe";
			this.txtHangXe.Size = new System.Drawing.Size(470, 22);
			this.txtHangXe.TabIndex = 17;
			// 
			// txtTenXe
			// 
			this.txtTenXe.Location = new System.Drawing.Point(154, 337);
			this.txtTenXe.Name = "txtTenXe";
			this.txtTenXe.Size = new System.Drawing.Size(470, 22);
			this.txtTenXe.TabIndex = 18;
			// 
			// cbDungTichXiLanh
			// 
			this.cbDungTichXiLanh.FormattingEnabled = true;
			this.cbDungTichXiLanh.Items.AddRange(new object[] {
            "50",
            "70",
            "100",
            "110",
            "150"});
			this.cbDungTichXiLanh.Location = new System.Drawing.Point(154, 215);
			this.cbDungTichXiLanh.Name = "cbDungTichXiLanh";
			this.cbDungTichXiLanh.Size = new System.Drawing.Size(121, 24);
			this.cbDungTichXiLanh.TabIndex = 19;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(725, 76);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 36);
			this.button1.TabIndex = 20;
			this.button1.Text = "Chọn Ảnh Xe";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(645, 120);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(262, 263);
			this.pictureBox.TabIndex = 21;
			this.pictureBox.TabStop = false;
			// 
			// btnThemAnh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1044, 657);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cbDungTichXiLanh);
			this.Controls.Add(this.txtTenXe);
			this.Controls.Add(this.txtHangXe);
			this.Controls.Add(this.txtMau);
			this.Controls.Add(this.txtSoMay);
			this.Controls.Add(this.txtSoKhung);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.btnXuat);
			this.Controls.Add(this.btnLamMoi);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDanhSach);
			this.Name = "btnThemAnh";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDanhSach;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Button btnXuat;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.TextBox txtSoKhung;
		private System.Windows.Forms.TextBox txtSoMay;
		private System.Windows.Forms.TextBox txtMau;
		private System.Windows.Forms.TextBox txtHangXe;
		private System.Windows.Forms.TextBox txtTenXe;
		private System.Windows.Forms.ComboBox cbDungTichXiLanh;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox;
	}
}

