namespace Test1
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNhap = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnNhap = new System.Windows.Forms.Button();
			this.btnTong = new System.Windows.Forms.Button();
			this.btnXep = new System.Windows.Forms.Button();
			this.btnLamLai = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.lbDay = new System.Windows.Forms.Label();
			this.lbTong = new System.Windows.Forms.Label();
			this.lbGiamDan = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(140, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập n:";
			// 
			// txtNhap
			// 
			this.txtNhap.Location = new System.Drawing.Point(220, 114);
			this.txtNhap.Name = "txtNhap";
			this.txtNhap.Size = new System.Drawing.Size(190, 22);
			this.txtNhap.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(140, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Dãy số:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(140, 233);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tổng dãy số:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(140, 300);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Dãy số giảm dần:";
			// 
			// btnNhap
			// 
			this.btnNhap.Location = new System.Drawing.Point(143, 390);
			this.btnNhap.Name = "btnNhap";
			this.btnNhap.Size = new System.Drawing.Size(126, 23);
			this.btnNhap.TabIndex = 2;
			this.btnNhap.Text = "Nhập";
			this.btnNhap.UseVisualStyleBackColor = true;
			this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
			// 
			// btnTong
			// 
			this.btnTong.Location = new System.Drawing.Point(284, 390);
			this.btnTong.Name = "btnTong";
			this.btnTong.Size = new System.Drawing.Size(126, 23);
			this.btnTong.TabIndex = 2;
			this.btnTong.Text = "Tính tổng";
			this.btnTong.UseVisualStyleBackColor = true;
			this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
			// 
			// btnXep
			// 
			this.btnXep.Location = new System.Drawing.Point(416, 390);
			this.btnXep.Name = "btnXep";
			this.btnXep.Size = new System.Drawing.Size(126, 23);
			this.btnXep.TabIndex = 2;
			this.btnXep.Text = "Sắp xếp";
			this.btnXep.UseVisualStyleBackColor = true;
			this.btnXep.Click += new System.EventHandler(this.btnXep_Click);
			// 
			// btnLamLai
			// 
			this.btnLamLai.Location = new System.Drawing.Point(548, 390);
			this.btnLamLai.Name = "btnLamLai";
			this.btnLamLai.Size = new System.Drawing.Size(126, 23);
			this.btnLamLai.TabIndex = 2;
			this.btnLamLai.Text = "Làm lại";
			this.btnLamLai.UseVisualStyleBackColor = true;
			this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(680, 390);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(126, 23);
			this.btnThoat.TabIndex = 2;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// lbDay
			// 
			this.lbDay.AutoSize = true;
			this.lbDay.Location = new System.Drawing.Point(217, 177);
			this.lbDay.Name = "lbDay";
			this.lbDay.Size = new System.Drawing.Size(0, 16);
			this.lbDay.TabIndex = 0;
			// 
			// lbTong
			// 
			this.lbTong.AutoSize = true;
			this.lbTong.Location = new System.Drawing.Point(244, 233);
			this.lbTong.Name = "lbTong";
			this.lbTong.Size = new System.Drawing.Size(0, 16);
			this.lbTong.TabIndex = 0;
			// 
			// lbGiamDan
			// 
			this.lbGiamDan.AutoSize = true;
			this.lbGiamDan.Location = new System.Drawing.Point(272, 300);
			this.lbGiamDan.Name = "lbGiamDan";
			this.lbGiamDan.Size = new System.Drawing.Size(0, 16);
			this.lbGiamDan.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 485);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnLamLai);
			this.Controls.Add(this.btnXep);
			this.Controls.Add(this.btnTong);
			this.Controls.Add(this.btnNhap);
			this.Controls.Add(this.txtNhap);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbGiamDan);
			this.Controls.Add(this.lbTong);
			this.Controls.Add(this.lbDay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNhap;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnNhap;
		private System.Windows.Forms.Button btnTong;
		private System.Windows.Forms.Button btnXep;
		private System.Windows.Forms.Button btnLamLai;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Label lbDay;
		private System.Windows.Forms.Label lbTong;
		private System.Windows.Forms.Label lbGiamDan;
	}
}

