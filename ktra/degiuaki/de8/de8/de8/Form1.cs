using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de8
{
    public partial class Form1 : Form
    {
        bool status;
        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
            list.Add("textBox1,đi");
            list.Add("textBox2,quốc");
            list.Add("textBox3,dồn");
            list.Add("textBox4,xa");
            list.Add("textBox5,máu");
            list.Add("textBox6,súng");
            list.Add("textBox7,khúc");
            list.Add("textBox8,đường");
            list.Add("textBox9,quân");
            list.Add("textBox10,cùng");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool KiemTra(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return false;
            }
            foreach (string str in list) {
                string[] res = str.Split(',');
                if (textBox.Name == res[0]&& textBox.Text.Equals(res[1], StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
            {
                TaoDeBai();
            foreach(Control control in groupBox1.Controls)
            {
                if(control is TextBox && control!= txtDeBai)
                {
                    //control.Enter+= textBox_chan
                }
            }
            }
            private void TaoDeBai()
            {
                txtDeBai.Text = "Đoàn quân Việt Nam (1)... chung lòng cứu (2)..., bước chân (3)... vang trên đường gập ghềnh (4)..., cờ in (5)... chiến thắng mang hồn nước, (6)... ngoài xa chen (7)... quân hành ca, (8)... vinh quang xây xác (9)... thù, thắng gian lao (10)... nhau lập chiến khu";
            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void textBox11_TextChanged(object sender, EventArgs e)
            {

            }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xac nhan thoat", "thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Control control in groupBox1.Controls)
            {
                Console.WriteLine("dung");
                if(control is TextBox && control != txtDeBai)
                {
                    Console.WriteLine("dung");
                    TextBox res=(TextBox)control;
                    if (KiemTra(res)) { 
                    res.ForeColor = Color.Green;
                        count++;
                    }
                    else
                    {
                        res.ForeColor = Color.Red;
                    }
                }
            }
            status=true;
            MessageBox.Show($"diem cua ban la {count}","ket qua", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
