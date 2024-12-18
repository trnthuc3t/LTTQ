using System.Data.SqlClient;
using System.Windows.Forms;
using System;

cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

try
{
	conn.Open();
	cmd.ExecuteNonQuery();
	LoadData();
	MessageBox.Show("Thêm thành công!");
}
catch (Exception ex)
{
	MessageBox.Show(ex.Message);
}
                }
            }
        }




        private void Repair_Click(object sender, EventArgs e)
{
	using (SqlConnection conn = new SqlConnection(_connectionString))
	{
		using (SqlCommand cmd = new SqlCommand("UPDATE SANPHAM SET TenHang = @TenHang, MaCl = @MaCl, SoLuong = @SoLuong, GiaNhap = @GiaNhap, GiaBan = @GiaBan, Anh = @Anh, GhiChu = @GhiChu WHERE MaHang = @MaHang", conn))
		{
			cmd.Parameters.AddWithValue("@MaHang", txtMahang.Text);
			cmd.Parameters.AddWithValue("@TenHang", txtTenhang.Text);
			cmd.Parameters.AddWithValue("@MaCl", cbChatlieu.SelectedValue);
			cmd.Parameters.AddWithValue("@SoLuong", txtSoluong.Text);
			cmd.Parameters.AddWithValue("@GiaNhap", txtDongianhap.Text);
			cmd.Parameters.AddWithValue("@GiaBan", txtDongiaban.Text);
			cmd.Parameters.AddWithValue("@Anh", pictureBox1.ImageLocation);
			cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
				LoadData();
				MessageBox.Show("Sửa thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}


private void Skip_Click(object sender, EventArgs e)
{

}

private void Exit_Click(object sender, EventArgs e)
{
	Application.Exit();
}

    }
}