﻿namespace Test7
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
			this.components = new System.ComponentModel.Container();
			this.txtPhut = new System.Windows.Forms.TextBox();
			this.txtGiay = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnChay = new System.Windows.Forms.Button();
			this.btnTamDung = new System.Windows.Forms.Button();
			this.btnHet = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// txtPhut
			// 
			this.txtPhut.Location = new System.Drawing.Point(183, 157);
			this.txtPhut.Name = "txtPhut";
			this.txtPhut.Size = new System.Drawing.Size(100, 22);
			this.txtPhut.TabIndex = 0;
			this.txtPhut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhut_KeyPress);
			// 
			// txtGiay
			// 
			this.txtGiay.Location = new System.Drawing.Point(418, 157);
			this.txtGiay.Name = "txtGiay";
			this.txtGiay.Size = new System.Drawing.Size(100, 22);
			this.txtGiay.TabIndex = 0;
			this.txtGiay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiay_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(208, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "(phút)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(436, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "(giây)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(338, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(15, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = ":";
			// 
			// btnChay
			// 
			this.btnChay.Location = new System.Drawing.Point(164, 286);
			this.btnChay.Name = "btnChay";
			this.btnChay.Size = new System.Drawing.Size(97, 35);
			this.btnChay.TabIndex = 3;
			this.btnChay.Text = "Chạy";
			this.btnChay.UseVisualStyleBackColor = true;
			this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
			// 
			// btnTamDung
			// 
			this.btnTamDung.Location = new System.Drawing.Point(303, 286);
			this.btnTamDung.Name = "btnTamDung";
			this.btnTamDung.Size = new System.Drawing.Size(100, 35);
			this.btnTamDung.TabIndex = 3;
			this.btnTamDung.Text = "Tạm dừng";
			this.btnTamDung.UseVisualStyleBackColor = true;
			this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
			// 
			// btnHet
			// 
			this.btnHet.Location = new System.Drawing.Point(440, 286);
			this.btnHet.Name = "btnHet";
			this.btnHet.Size = new System.Drawing.Size(100, 35);
			this.btnHet.TabIndex = 3;
			this.btnHet.Text = "Kết thúc";
			this.btnHet.UseVisualStyleBackColor = true;
			this.btnHet.Click += new System.EventHandler(this.btnHet_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnHet);
			this.Controls.Add(this.btnTamDung);
			this.Controls.Add(this.btnChay);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtGiay);
			this.Controls.Add(this.txtPhut);
			this.Name = "Form1";
			this.Text = "Chương trình đồng hồ đếm ngược:";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPhut;
		private System.Windows.Forms.TextBox txtGiay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnChay;
		private System.Windows.Forms.Button btnTamDung;
		private System.Windows.Forms.Button btnHet;
		private System.Windows.Forms.Timer timer1;
	}
}

