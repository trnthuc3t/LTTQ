using Microsoft.SqlServer.Server;
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


namespace QuanLiBanHang
{
    public partial class frmChatLieu : Form
    {

        ProcessDataBase dtBase=new ProcessDataBase();
        public frmChatLieu()
        {
            InitializeComponent();
        }

        private void frmChatLieu_Load(object sender, EventArgs e)
        {
            DataTable dtChatLieu = dtBase.DocBang("select * from tblChatLieu");
            dgvChatLieu.DataSource = dtChatLieu;
            dgvChatLieu.Columns[0].HeaderText = "Mã chất liệu";
            dgvChatLieu.Columns[1].HeaderText = "Tên chất liệu";
            dgvChatLieu.Columns[0].Width = 150;
            dgvChatLieu.Columns[1].Width = 250;
            
        }
        void ResetValue()
        {
            txtMaCL.Text = "";
            txtTenCL.Text = "";
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaCL.Enabled = true;
            txtMaCL.Focus();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThemMoi.Enabled = true;
        }

        private void dgvChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCL.Text = dgvChatLieu.CurrentRow.Cells[0].Value.ToString();
            txtTenCL.Text = dgvChatLieu.CurrentRow.Cells[1].Value.ToString();
            txtMaCL.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = true;
            btnThemMoi.Enabled = false;
            dgvChatLieu.Refresh();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenCL.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCL.Focus();
            }
            else
            {
                dtBase.CapNhatDuLieu("update tblChatLieu set TenChatLieu=N'"+ txtTenCL.Text + "' where MaChatLieu = '"+txtMaCL.Text+"'");
                //using (SqlCommand command = new SqlCommand("update tblChatLieu set TenChatLieu=@TenChatLieu where MaChatLieu=@MaChatLieu", SqlConnection))
                //{
                //    command.Parameters.AddWithValue("@TenChatLieu", txtTenCL.Text);
                //    command.Parameters.AddWithValue("@MaChatLieu", txtMaCL.Text);
                //    command.ExecuteNonQuery();
                //}

                ResetValue();//Xóa dữ liệu ở các ô nhập TextBox
                             //Sau khi update cần lấy lại dữ liệu để hiển thị lên lưới
                dgvChatLieu.DataSource = dtBase.DocBang("select * from tblChatLieu");



                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
                btnThemMoi.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chất liệu có mã là:" + txtMaCL.Text + " không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==System.Windows.Forms.DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu("delete tblChatLieu where MaChatLieu='" + txtMaCL.Text + "'");
                dgvChatLieu.DataSource = dtBase.DocBang("Select * from  tblChatLieu");


                ResetValue();
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
                btnThemMoi.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCL.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu");
                txtMaCL.Focus();
            }
            else
            {
                if (txtTenCL.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tên chất liệu");
                    txtTenCL.Focus();
                }
                else
                {
                    DataTable dtChatLieu = dtBase.DocBang("Select * from tblChatLieu where" + " MaChatLieu = '" + (txtMaCL.Text).Trim() + "'");
                    if (dtChatLieu.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã chất liệu này đã có, hãy nhập mã khác!");

                        txtMaCL.Focus();
                    }
                    else
                    {
                        dtBase.CapNhatDuLieu("insert into tblChatLieu values(N'" + txtMaCL.Text + "',N'" + txtTenCL.Text +"')");
                        MessageBox.Show("Bạn đã thêm mới thành công");
                        dgvChatLieu.DataSource = dtBase.DocBang("select * from tblChatLieu");

                        ResetValue();
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        btnLuu.Enabled = false;
                        btnBoQua.Enabled = false;
                        btnThemMoi.Enabled = true;
                    }
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThemMoi.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
