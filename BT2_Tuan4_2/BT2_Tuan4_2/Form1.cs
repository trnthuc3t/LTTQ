using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_Tuan4_2
{
    public partial class Form1 : Form
    {
        private int tongSoTinChi = 0;
        private double tongSoDiem = 0.0;

        public Form1()
        {
            InitializeComponent();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenMon = comboBox1.Text;
            int soTinChi = int.Parse(textBox2.Text);
            double diem = double.Parse(textBox3.Text);

            // Thêm vào ListView
            ListViewItem item = new ListViewItem(tenMon);
            item.SubItems.Add(soTinChi.ToString());
            item.SubItems.Add(diem.ToString());
            listView1.Items.Add(item);
            

            // Cập nhật tổng số tín chỉ và điểm
            tongSoTinChi += soTinChi;
            tongSoDiem +=  diem;

            // Hiển thị kết quả
            textBox6.Text = tongSoTinChi.ToString();  // Tổng số tín chỉ
            textBox5.Text = tongSoDiem.ToString();    // Tổng số điểm
            textBox4.Text = (tongSoDiem / tongSoTinChi).ToString("0.00");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.Text = "2";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox2.Text = "3";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox2.Text = "3";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox2.Text = "2";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                textBox2.Text = "3";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban có muốn thoát ko ??", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.H))
            {
                DialogResult result = MessageBox.Show("banj cos mujon thoat k", "xac nhan thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) {
                    Application.Exit();
                }
                return true;
            }
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn trong ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Xóa dòng khỏi ListView
                listView1.Items.Remove(selectedItem);

                // Hoặc dùng: listView1.Items.RemoveAt(selectedItem.Index); // Xóa theo chỉ mục

               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }
    }
}
