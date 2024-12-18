using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
	public partial class Form1 : Form
	{

		List<int> list = new List<int>();
		int n = 0;
		public Form1()
		{
			InitializeComponent();
			
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnNhap_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtNhap.Text, out int res))
			{
				n = res;
			}
			else
			{
				MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			Random ran = new Random();
			for (int i = 0; i < n; i++)
			{

				int ranNum = ran.Next(1, 101);
				list.Add(ranNum);
			}
			foreach (var i in list)
			{
				lbDay.Text += i.ToString() + " ";
			}
		}

		private void btnTong_Click(object sender, EventArgs e)
		{
			int sum = 0;
			foreach (int i in list)
			{
				sum += i;
			}
			lbTong.Text = sum.ToString();
		}

		private void btnXep_Click(object sender, EventArgs e)
		{
			list.Sort((a,b) => b.CompareTo(a));
            foreach (var num in list)
            {
				lbGiamDan.Text += num.ToString() + " ";
            }
        }

		private void btnLamLai_Click(object sender, EventArgs e)
		{
			txtNhap.Text = "";
			lbDay.Text = "";
			lbTong.Text = "";
			lbGiamDan.Text = "";
			list.Clear();
			txtNhap.Clear();
		}
	}
}
