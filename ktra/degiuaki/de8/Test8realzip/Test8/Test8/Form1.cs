using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "All files|*.*|Rich Text Format|*.rtf";
			openFileDialog1.FilterIndex = 1; // Set FilterIndex to 1 to default to the first filter
			openFileDialog1.Title = "Select RTF file";
			openFileDialog1.InitialDirectory = "D:\\LapTrinhTrucQuan";
			openFileDialog1.ShowDialog();

			if (openFileDialog1.FileName.Trim() != "")
			{
				FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
				StreamReader streamReader = new StreamReader(fs, Encoding.UTF8);
				rtb.Text = streamReader.ReadToEnd();
				streamReader.Close();
				fs.Close();
			}
		}

		private void btnFont_Click(object sender, EventArgs e)
		{

			using (FontDialog fontDialog = new FontDialog())
			{
				fontDialog.Font = rtb.SelectionFont;

				fontDialog.Color = rtb.SelectionColor;

				if (fontDialog.ShowDialog() == DialogResult.OK)
				{
					rtb.SelectionFont = fontDialog.Font;
					rtb.SelectionColor = fontDialog.Color;
				}
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Hiển thị hộp thoại SaveFileDialog
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "RTF Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
				saveFileDialog.FilterIndex = 1;

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					// Lưu nội dung của RichTextBox vào file đã chọn
					try
					{
						rtb.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
						MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}
