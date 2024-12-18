using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace TranTruongThuc222631147
{
    public partial class Form1 : Form
    {
        //DataGridView
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataTable table= new DataTable();
        string str = "Data Source=THUCVIVO;Initial Catalog=QuanLyKhachHang;Integrated Security=True";
       
        public Form1()
        {
            InitializeComponent();
			this.KeyDown += new KeyEventHandler(Form1_KeyDown);
			// Cho phép form bắt sự kiện bàn phím
			this.KeyPreview = true;
			txtMaKhachHang.KeyDown += new KeyEventHandler(textBox_KeyDown);
			txtHoTenKhachHang.KeyDown += new KeyEventHandler(textBox_KeyDown);
			txtDiaChi.KeyDown += new KeyEventHandler(textBox_KeyDown);
			btnThemMoi.Click += new EventHandler(btnThemMoi_Click);
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Focus();
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
           connection.Close();
        }

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM KhachHang"; 
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvKhachHang.DataSource = table;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                
                this.Close();
            }
            
        }
		private void textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				// Chuyển focus sang control tiếp theo theo TabIndex
				this.SelectNextControl((Control)sender, true, true, true, true);
				e.SuppressKeyPress = true;  // Chặn tiếng 'beep'
			}
		}

		private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            
        }
        private void clearalltextboxes()
        {
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is TextBox)
				{
					((TextBox)ctrl).Clear();  // Đặt giá trị của TextBox thành rỗng
				}
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt && e.KeyCode == Keys.H)
			{
				// Hiển thị thông báo trước khi thoát
				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					this.Close();
				}
			}
			else if (e.Alt && e.KeyCode == Keys.M)
			{
				clearalltextboxes();
			}

		}
		public void Refresh()
        {
            
        }


        private void btnThemMoi_Click(object sender, EventArgs e)
        {
			clearalltextboxes();
		}

        private void txtSoThangTruoc_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void txtSoThangNay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoThangNay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSoThangTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void btnXoaKhoiDS_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvKhachHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

		private void txtNgayChotSo_TextChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Form1_KeyDown_1(object sender, KeyEventArgs e)
		{

		}
	}
}
