using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test7
{
	public partial class Form1 : Form
	{
		private int totalSeconds;
		private bool isRunning;
		public Form1()
		{
			InitializeComponent();
			totalSeconds = 0;
			isRunning = false;
		}

		private void txtPhut_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; 
			}
		}

		private void txtGiay_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; 
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void UpdateTime()
		{
			int minutes = totalSeconds / 60;
			int seconds = totalSeconds % 60;
			txtPhut.Text = $"{minutes:D2}";
			txtGiay.Text = $"{seconds:D2}";

		}

		private void btnChay_Click(object sender, EventArgs e)
		{
			if (!isRunning)
			{
				int m, s;
				if (txtPhut.Text.Trim().Length != 0 && txtGiay.Text.Trim().Length != 0)
				{
					m = int.Parse(txtPhut.Text);
					s = int.Parse(txtGiay.Text);
					totalSeconds = m * 60 + s;
				}
				else
				{
					MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho phút và giây.");
				}
				isRunning = true;
				timer1.Start();


			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (totalSeconds > 0)
			{
				totalSeconds--;
				UpdateTime();
			}
			else
			{
				isRunning = false;
				timer1.Stop();
				MessageBox.Show("Đã đạt đến thời gian đã nhập.");
			}
		}

		private void btnTamDung_Click(object sender, EventArgs e)
		{
			isRunning = false;
			timer1.Stop();
		}

		private void btnHet_Click(object sender, EventArgs e)
		{
			btnTamDung_Click(sender, e);
			txtPhut.Text = "00";
			txtGiay.Text = $"00";
		}
	}
}
