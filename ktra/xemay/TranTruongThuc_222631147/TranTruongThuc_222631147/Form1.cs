using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranTruongThuc_222631147
{
	public partial class btnThemAnh : Form
	{
		// Khai báo biến để lưu đường dẫn ảnh đã chọn
		private string selectedImagePath;

		private SqlConnection conn;
		private string originalSoKhung;
		private string originalSoMay;
		public btnThemAnh()
		{
			InitializeComponent();
			string connectionString = "Data Source=THUCVIVO;Initial Catalog=QuanLyXeMay;Integrated Security=True";
			conn= new SqlConnection(connectionString);
			LoadData();
			dgvDanhSach.CellClick += dgvDanhSach_CellClick;
		}

		

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}

				// Truy vấn thêm mới dữ liệu vào bảng, bao gồm đường dẫn ảnh
				string insertQuery = "INSERT INTO ThongTinXe (SoKhung, SoMay, MauXe, DungTichXiLanh, HangXe, TenXe, Anh) " +
									 "VALUES (@SoKhung, @SoMay, @MauXe, @DungTichXiLanh, @HangXe, @TenXe, @Anh)";
				SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
				insertCmd.Parameters.AddWithValue("@SoKhung", txtSoKhung.Text);
				insertCmd.Parameters.AddWithValue("@SoMay", txtSoMay.Text);
				insertCmd.Parameters.AddWithValue("@MauXe", txtMau.Text);
				insertCmd.Parameters.AddWithValue("@DungTichXiLanh", cbDungTichXiLanh.Text);
				insertCmd.Parameters.AddWithValue("@HangXe", txtHangXe.Text);
				insertCmd.Parameters.AddWithValue("@TenXe", txtTenXe.Text);
				insertCmd.Parameters.AddWithValue("@Anh", selectedImagePath); // Lưu đường dẫn ảnh

				insertCmd.ExecuteNonQuery();

				MessageBox.Show("Thêm xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadData(); // Cập nhật lại DataGridView sau khi thêm
				ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
			}
		}
		private void LoadData()
		{
			try
			{
				// Mở kết nối
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}

				// Truy vấn để lấy dữ liệu từ bảng ThongTinXe
				string query = "SELECT * FROM ThongTinXe";
				SqlDataAdapter da = new SqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Hiển thị dữ liệu lên DataGridView
				dgvDanhSach.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
			finally
			{
				// Đóng kết nối
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
			}
		}

		private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (e.RowIndex >= 0) // Đảm bảo rằng người dùng không click vào tiêu đề cột
			//{
			//	DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

			//	// Hiển thị thông tin từ DataGridView lên các TextBox
			//	txtSoKhung.Text = row.Cells["SoKhung"].Value.ToString();
			//	txtSoMay.Text = row.Cells["SoMay"].Value.ToString();
			//	txtMau.Text = row.Cells["MauXe"].Value.ToString();
			//	cbDungTichXiLanh.Text = row.Cells["DungTichXiLanh"].Value.ToString();
			//	txtHangXe.Text = row.Cells["HangXe"].Value.ToString();
			//	txtTenXe.Text = row.Cells["TenXe"].Value.ToString();
			//	originalSoKhung = txtSoKhung.Text;
			//	originalSoMay = txtSoMay.Text;
			//	// Nếu có cột đường dẫn ảnh (ví dụ: "Anh") trong DataGridView, hiển thị ảnh lên PictureBox
			//	//if (row.Cells["Anh"].Value != null)
			//	//{
			//	//	string imagePath = row.Cells["Anh"].Value.ToString();
			//	//	pictureBox.Image = Image.FromFile(imagePath); // Hiển thị ảnh lên PictureBox
			//	//}
			//}
			if (e.RowIndex >= 0) 
			{
				DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

				// Hiển thị thông tin từ DataGridView lên các TextBox
				txtSoKhung.Text = row.Cells["SoKhung"].Value.ToString();
				txtSoMay.Text = row.Cells["SoMay"].Value.ToString();
				txtMau.Text = row.Cells["MauXe"].Value.ToString();
				cbDungTichXiLanh.Text = row.Cells["DungTichXiLanh"].Value.ToString();
				txtHangXe.Text = row.Cells["HangXe"].Value.ToString();
				txtTenXe.Text = row.Cells["TenXe"].Value.ToString();

				
				if (row.Cells["Anh"].Value != null)
				{
					string imagePath = row.Cells["Anh"].Value.ToString();
					if (File.Exists(imagePath))
					{
						pictureBox.Image = Image.FromFile(imagePath);
					}
					else
					{
						pictureBox.Image = null; 
					}
				}
				else
				{
					pictureBox.Image = null; 
				}
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			// Kiểm tra xem người dùng đã chọn dòng nào chưa
			if (!string.IsNullOrEmpty(txtSoKhung.Text))
			{
				// Hiển thị hộp thoại xác nhận
				DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (dialogResult == DialogResult.Yes) // Nếu người dùng chọn Yes
				{
					try
					{
						// Mở kết nối
						if (conn.State == ConnectionState.Closed)
						{
							conn.Open();
						}

						// Truy vấn xóa bản ghi theo Số khung
						string deleteQuery = "DELETE FROM ThongTinXe WHERE SoKhung = @SoKhung";
						SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
						deleteCmd.Parameters.AddWithValue("@SoKhung", txtSoKhung.Text);
						deleteCmd.ExecuteNonQuery();

						// Thông báo xóa thành công
						MessageBox.Show("Xóa bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// Cập nhật lại DataGridView
						LoadData();

						// Làm mới các TextBox sau khi xóa
						ClearForm();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi: " + ex.Message);
					}
					finally
					{
						if (conn.State == ConnectionState.Open)
						{
							conn.Close();
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một bản ghi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void ClearForm()
		{
			txtSoKhung.Clear();
			txtSoMay.Clear();
			txtMau.Clear();
			cbDungTichXiLanh.SelectedIndex = -1; // Reset ComboBox
			txtHangXe.Clear();
			txtTenXe.Clear();
			//txtSoKhung.Clear();
			//txtSoMay.Clear();
			//txtMau.Clear();
			//cbDungTichXiLanh.SelectedIndex = -1; // Reset ComboBox
			//txtHangXe.Clear();
			//txtTenXe.Clear();
			//pictureBox.Image = null; // Xóa ảnh (nếu có)
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			// Kiểm tra xem người dùng đã chọn dòng nào chưa
			if (!string.IsNullOrEmpty(txtSoKhung.Text))
			{
				// Hiển thị hộp thoại xác nhận sửa
				DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa bản ghi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (dialogResult == DialogResult.Yes) // Nếu người dùng chọn Yes
				{
					try
					{
						// Mở kết nối
						if (conn.State == ConnectionState.Closed)
						{
							conn.Open();
						}

						// Truy vấn cập nhật các thông tin (trừ số khung và số máy)
						string updateQuery = "UPDATE ThongTinXe SET MauXe = @MauXe, DungTichXiLanh = @DungTichXiLanh, HangXe = @HangXe, TenXe = @TenXe WHERE SoKhung = @SoKhung AND SoMay = @SoMay";
						SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
						updateCmd.Parameters.AddWithValue("@MauXe", txtMau.Text);
						updateCmd.Parameters.AddWithValue("@DungTichXiLanh", cbDungTichXiLanh.Text);
						updateCmd.Parameters.AddWithValue("@HangXe", txtHangXe.Text);
						updateCmd.Parameters.AddWithValue("@TenXe", txtTenXe.Text);
						updateCmd.Parameters.AddWithValue("@SoKhung", txtSoKhung.Text);
						updateCmd.Parameters.AddWithValue("@SoMay", txtSoMay.Text);

						updateCmd.ExecuteNonQuery();

						// Thông báo thành công
						MessageBox.Show("Sửa bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// Cập nhật lại DataGridView
						LoadData();

						// Làm mới các TextBox sau khi sửa
						ClearForm();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi: " + ex.Message);
					}
					finally
					{
						// Đảm bảo rằng kết nối sẽ được đóng lại sau khi truy vấn
						if (conn.State == ConnectionState.Open)
						{
							conn.Close();
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một bản ghi để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt && e.KeyCode == Keys.M)
			{
				ClearForm(); // Xóa dữ liệu trong các ô nhập liệu
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.KeyPreview = true; // Đảm bảo form nhận sự kiện bàn phím
			LoadData();
			btnLamMoi.Click += btnLamMoi_Click; // Sự kiện nút "Làm mới"
			this.KeyDown += Form1_KeyDown; // Sự kiện KeyDown cho ALT + M
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Lọc chỉ cho phép chọn file ảnh
			openFileDialog.Title = "Chọn ảnh xe";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Hiển thị ảnh đã chọn lên PictureBox
				pictureBox.Image = Image.FromFile(openFileDialog.FileName);

				// Lưu đường dẫn ảnh vào biến để sử dụng khi thêm vào cơ sở dữ liệu
				selectedImagePath = openFileDialog.FileName;
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			try
			{
				string mauXe = txtMau.Text.Trim();   // Lấy từ khóa màu xe
				string hangXe = txtHangXe.Text.Trim(); // Lấy từ khóa hãng xe

				// Mở kết nối tới cơ sở dữ liệu
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}

				// Tạo truy vấn tìm kiếm theo Màu xe và Hãng xe
				string searchQuery = "SELECT * FROM ThongTinXe WHERE 1=1";

				// Kiểm tra nếu người dùng có nhập từ khóa tìm kiếm màu xe
				if (!string.IsNullOrEmpty(mauXe))
				{
					searchQuery += " AND MauXe LIKE @MauXe";
				}

				// Kiểm tra nếu người dùng có nhập từ khóa tìm kiếm hãng xe
				if (!string.IsNullOrEmpty(hangXe))
				{
					searchQuery += " AND HangXe LIKE @HangXe";
				}

				SqlDataAdapter da = new SqlDataAdapter(searchQuery, conn);

				// Gán giá trị cho tham số tìm kiếm nếu người dùng có nhập
				if (!string.IsNullOrEmpty(mauXe))
				{
					da.SelectCommand.Parameters.AddWithValue("@MauXe", "%" + mauXe + "%");
				}
				if (!string.IsNullOrEmpty(hangXe))
				{
					da.SelectCommand.Parameters.AddWithValue("@HangXe", "%" + hangXe + "%");
				}

				DataTable dt = new DataTable();
				da.Fill(dt);

				// Hiển thị dữ liệu sau khi tìm kiếm lên DataGridView
				dgvDanhSach.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
			}
		}

		//private void btnXuat_Click(object sender, EventArgs e)
		//{

		//		try
		//		{
		//			// Tạo một SaveFileDialog để người dùng chọn nơi lưu file
		//			SaveFileDialog saveFileDialog = new SaveFileDialog();
		//			saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
		//			saveFileDialog.Title = "Lưu file Excel";

		//			if (saveFileDialog.ShowDialog() == DialogResult.OK)
		//			{
		//				// Tạo file Excel mới
		//				using (var workbook = new ClosedXML.Excel.XLWorkbook())
		//				{
		//					// Tạo một worksheet
		//					var worksheet = workbook.Worksheets.Add("ThongTinXe");

		//					// Thêm các tiêu đề cột
		//					for (int i = 0; i < dgvDanhSach.Columns.Count; i++)
		//					{
		//						worksheet.Cell(1, i + 1).Value = dgvDanhSach.Columns[i].HeaderText;
		//					}

		//					// Thêm dữ liệu từ DataGridView vào worksheet
		//					for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
		//					{
		//						for (int j = 0; j < dgvDanhSach.Columns.Count; j++)
		//						{
		//							worksheet.Cell(i + 2, j + 1).Value = dgvDanhSach.Rows[i].Cells[j].Value?.ToString();
		//						}
		//					}

		//					// Lưu file Excel
		//					workbook.SaveAs(saveFileDialog.FileName);

		//					MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//				}
		//			}
		//		}
		//		catch (Exception ex)
		//		{
		//			MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message);
		//		}


		//}
	}
}
