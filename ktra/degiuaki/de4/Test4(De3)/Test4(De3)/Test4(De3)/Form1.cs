using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test4_De3_
{
	public partial class Form1 : Form
	{
		Font currentFont = new Font("Microsoft Sans Serif", 8);
		FontStyle currentFontStyle = FontStyle.Regular;
		public Form1()
		{
			InitializeComponent();
			foreach (RadioButton i in groupBox1.Controls)
			{
				i.CheckedChanged += Font_Checked;
			}

			foreach (RadioButton i in groupBox3.Controls)
			{
				i.CheckedChanged += Color_Checked;
			}

			foreach (CheckBox i in groupBox2.Controls)
			{
				i.CheckedChanged += Effect_Checked;
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Alt | Keys.L))
			{
				// Thực hiện reset form
				Reset();
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}
		private void Reset()
		{
			currentFont = new Font("Microsoft Sans Serif", 8);
			currentFontStyle = FontStyle.Regular;
			textBox1.Font = currentFont;
			textBox1.ForeColor = Color.Black;
			foreach (RadioButton i in groupBox1.Controls)
			{
				i.Checked = false;
			}

			foreach (RadioButton i in groupBox3.Controls)
			{
				i.Checked = false;
			}

			foreach (CheckBox i in groupBox2.Controls)
			{
				i.Checked = false;
			}
			textBox1.Text = "";

		}

		private void Font_Checked(object sender, EventArgs e)
		{
			RadioButton selected = (RadioButton)sender;
			if (selected.Checked)
			{
				currentFont = new Font(selected.Text, 12);
				textBox1.Font = currentFont;
			}
		}

		private void Effect_Checked(object sender, EventArgs e)
		{
			CheckBox selected = (CheckBox)sender;
			if (selected.Checked)
			{
				switch (selected.Text)
				{
					case "Bold":
						currentFontStyle |= FontStyle.Bold;
						textBox1.Font = currentFont;
						break;
					case "Italic":
						currentFontStyle |= FontStyle.Italic;
						textBox1.Font = currentFont;
						break;
					case "Strikeout":
						currentFontStyle |= FontStyle.Strikeout;
						textBox1.Font = currentFont;
						break;
					case "Underline":
						currentFontStyle |= FontStyle.Underline;
						textBox1.Font = currentFont;
						break;
					default:
						break;
				}
				currentFont = new Font(currentFont.FontFamily, currentFont.Size, currentFontStyle);
				textBox1.Font = currentFont;
			}
		}

		private void Color_Checked(object sender, EventArgs e)
		{
			RadioButton selected = (RadioButton)sender;
			if (selected.Checked)
			{
				switch (selected.Text)
				{
					case "Red":
						textBox1.ForeColor = Color.Red; break;
					case "Blue":
						textBox1.ForeColor = Color.Blue; break;
					case "Green":
						textBox1.ForeColor = Color.Green; break;
					case "Orange":
						textBox1.ForeColor = Color.Orange; break;
					default:
						break;
				}
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{
		}

		

		private void btnReset_Click(object sender, EventArgs e)
		{
			Reset();
		}
		

		private void btnExit_Click(object sender, EventArgs e)
		{
				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
													  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					Application.Exit();
				}
			
		}

	}
}
