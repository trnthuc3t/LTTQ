namespace Test4_De3_
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbtnTa = new System.Windows.Forms.RadioButton();
			this.rbtnVgo = new System.Windows.Forms.RadioButton();
			this.rbtnVnu = new System.Windows.Forms.RadioButton();
			this.rbtnVnTime = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ckUnder = new System.Windows.Forms.CheckBox();
			this.ckStrike = new System.Windows.Forms.CheckBox();
			this.ckItalic = new System.Windows.Forms.CheckBox();
			this.cbBold = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbtnTim = new System.Windows.Forms.RadioButton();
			this.rbtnLa = new System.Windows.Forms.RadioButton();
			this.rbtnDo = new System.Windows.Forms.RadioButton();
			this.rbtnXanh = new System.Windows.Forms.RadioButton();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(223, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(326, 22);
			this.textBox1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtnTa);
			this.groupBox1.Controls.Add(this.rbtnVgo);
			this.groupBox1.Controls.Add(this.rbtnVnu);
			this.groupBox1.Controls.Add(this.rbtnVnTime);
			this.groupBox1.Location = new System.Drawing.Point(56, 104);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(187, 261);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kiểu font";
			// 
			// rbtnTa
			// 
			this.rbtnTa.AutoSize = true;
			this.rbtnTa.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnTa.Location = new System.Drawing.Point(32, 210);
			this.rbtnTa.Name = "rbtnTa";
			this.rbtnTa.Size = new System.Drawing.Size(75, 20);
			this.rbtnTa.TabIndex = 0;
			this.rbtnTa.TabStop = true;
			this.rbtnTa.Text = "Tahoma";
			this.rbtnTa.UseVisualStyleBackColor = true;
			// 
			// rbtnVgo
			// 
			this.rbtnVgo.AutoSize = true;
			this.rbtnVgo.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnVgo.Location = new System.Drawing.Point(32, 151);
			this.rbtnVgo.Name = "rbtnVgo";
			this.rbtnVgo.Size = new System.Drawing.Size(122, 20);
			this.rbtnVgo.TabIndex = 0;
			this.rbtnVgo.TabStop = true;
			this.rbtnVgo.Text = "Microsoft Tai Le";
			this.rbtnVgo.UseVisualStyleBackColor = true;
			// 
			// rbtnVnu
			// 
			this.rbtnVnu.AutoSize = true;
			this.rbtnVnu.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnVnu.Location = new System.Drawing.Point(32, 95);
			this.rbtnVnu.Name = "rbtnVnu";
			this.rbtnVnu.Size = new System.Drawing.Size(94, 20);
			this.rbtnVnu.TabIndex = 0;
			this.rbtnVnu.TabStop = true;
			this.rbtnVnu.Text = "Bahnschrift";
			this.rbtnVnu.UseVisualStyleBackColor = true;
			// 
			// rbtnVnTime
			// 
			this.rbtnVnTime.AutoSize = true;
			this.rbtnVnTime.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnVnTime.Location = new System.Drawing.Point(32, 43);
			this.rbtnVnTime.Name = "rbtnVnTime";
			this.rbtnVnTime.Size = new System.Drawing.Size(127, 19);
			this.rbtnVnTime.TabIndex = 0;
			this.rbtnVnTime.TabStop = true;
			this.rbtnVnTime.Text = "Times New Roman";
			this.rbtnVnTime.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ckUnder);
			this.groupBox2.Controls.Add(this.ckStrike);
			this.groupBox2.Controls.Add(this.ckItalic);
			this.groupBox2.Controls.Add(this.cbBold);
			this.groupBox2.Location = new System.Drawing.Point(295, 104);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(208, 261);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Hiệu ứng";
			// 
			// ckUnder
			// 
			this.ckUnder.AutoSize = true;
			this.ckUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckUnder.Location = new System.Drawing.Point(46, 210);
			this.ckUnder.Name = "ckUnder";
			this.ckUnder.Size = new System.Drawing.Size(87, 20);
			this.ckUnder.TabIndex = 0;
			this.ckUnder.Text = "Underline";
			this.ckUnder.UseVisualStyleBackColor = true;
			// 
			// ckStrike
			// 
			this.ckStrike.AutoSize = true;
			this.ckStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckStrike.Location = new System.Drawing.Point(46, 152);
			this.ckStrike.Name = "ckStrike";
			this.ckStrike.Size = new System.Drawing.Size(81, 20);
			this.ckStrike.TabIndex = 0;
			this.ckStrike.Text = "Strikeout";
			this.ckStrike.UseVisualStyleBackColor = true;
			// 
			// ckItalic
			// 
			this.ckItalic.AutoSize = true;
			this.ckItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckItalic.Location = new System.Drawing.Point(46, 95);
			this.ckItalic.Name = "ckItalic";
			this.ckItalic.Size = new System.Drawing.Size(56, 20);
			this.ckItalic.TabIndex = 0;
			this.ckItalic.Text = "Italic";
			this.ckItalic.UseVisualStyleBackColor = true;
			// 
			// cbBold
			// 
			this.cbBold.AutoSize = true;
			this.cbBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbBold.Location = new System.Drawing.Point(46, 43);
			this.cbBold.Name = "cbBold";
			this.cbBold.Size = new System.Drawing.Size(61, 20);
			this.cbBold.TabIndex = 0;
			this.cbBold.Text = "Bold";
			this.cbBold.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbtnTim);
			this.groupBox3.Controls.Add(this.rbtnLa);
			this.groupBox3.Controls.Add(this.rbtnDo);
			this.groupBox3.Controls.Add(this.rbtnXanh);
			this.groupBox3.Location = new System.Drawing.Point(548, 104);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(197, 261);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Màu chữ";
			// 
			// rbtnTim
			// 
			this.rbtnTim.AutoSize = true;
			this.rbtnTim.ForeColor = System.Drawing.Color.Violet;
			this.rbtnTim.Location = new System.Drawing.Point(57, 209);
			this.rbtnTim.Name = "rbtnTim";
			this.rbtnTim.Size = new System.Drawing.Size(73, 20);
			this.rbtnTim.TabIndex = 0;
			this.rbtnTim.TabStop = true;
			this.rbtnTim.Text = "Orange";
			this.rbtnTim.UseVisualStyleBackColor = true;
			// 
			// rbtnLa
			// 
			this.rbtnLa.AutoSize = true;
			this.rbtnLa.ForeColor = System.Drawing.Color.ForestGreen;
			this.rbtnLa.Location = new System.Drawing.Point(57, 151);
			this.rbtnLa.Name = "rbtnLa";
			this.rbtnLa.Size = new System.Drawing.Size(65, 20);
			this.rbtnLa.TabIndex = 0;
			this.rbtnLa.TabStop = true;
			this.rbtnLa.Text = "Green";
			this.rbtnLa.UseVisualStyleBackColor = true;
			// 
			// rbtnDo
			// 
			this.rbtnDo.AutoSize = true;
			this.rbtnDo.ForeColor = System.Drawing.Color.Red;
			this.rbtnDo.Location = new System.Drawing.Point(57, 94);
			this.rbtnDo.Name = "rbtnDo";
			this.rbtnDo.Size = new System.Drawing.Size(54, 20);
			this.rbtnDo.TabIndex = 0;
			this.rbtnDo.TabStop = true;
			this.rbtnDo.Text = "Red";
			this.rbtnDo.UseVisualStyleBackColor = true;
			// 
			// rbtnXanh
			// 
			this.rbtnXanh.AutoSize = true;
			this.rbtnXanh.ForeColor = System.Drawing.Color.SkyBlue;
			this.rbtnXanh.Location = new System.Drawing.Point(57, 42);
			this.rbtnXanh.Name = "rbtnXanh";
			this.rbtnXanh.Size = new System.Drawing.Size(55, 20);
			this.rbtnXanh.TabIndex = 0;
			this.rbtnXanh.TabStop = true;
			this.rbtnXanh.Text = "Blue";
			this.rbtnXanh.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(205, 400);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(133, 23);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "Làm lại";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(431, 400);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(133, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Program of Font";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbtnTa;
		private System.Windows.Forms.RadioButton rbtnVgo;
		private System.Windows.Forms.RadioButton rbtnVnu;
		private System.Windows.Forms.RadioButton rbtnVnTime;
		private System.Windows.Forms.CheckBox ckUnder;
		private System.Windows.Forms.CheckBox ckStrike;
		private System.Windows.Forms.CheckBox ckItalic;
		private System.Windows.Forms.CheckBox cbBold;
		private System.Windows.Forms.RadioButton rbtnTim;
		private System.Windows.Forms.RadioButton rbtnLa;
		private System.Windows.Forms.RadioButton rbtnDo;
		private System.Windows.Forms.RadioButton rbtnXanh;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnExit;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

