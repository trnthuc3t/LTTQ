using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CoLuyen123
{
    public partial class Form1 : Form
    {
        bool status;
        List<string> list = new List<string>();
        public Form1()
        {
            status = false;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {

                if (control is TextBox && control != txtDebai)
                {
                    control.Enter += textBox_TextChanged;
                }
            }
        }

        private void TaoDeBai2()
        {
            txtDebai.Text = "Đoàn quân (1)____ đi. Chung lòng (2)____ . Bước chân rộn vang trên đường (3)____ xa" +
                ". Cờ in (4)____ chiến thắng mang (5)____. Súng (6)____ chen khúc quân hành ca. " +
                "Đường vinh quang xây xác (7)____. " + "(8)____ gian lao cùng nhau lập (9)____ ! ";

            list.Add("textBox1,Việt Nam");
            list.Add("textBox2,cứu quốc");
            list.Add("textBox3,gập ghềnh");
            list.Add("textBox4,máu");
            list.Add("textBox5,hồn nước");
            list.Add("textBox6,ngoài xa");
            list.Add("textBox7,quân thù");
            list.Add("textBox8,thắng");
            list.Add("textBox9,chiến khu");
        }
        private void TaoDeBai1()
        {
            txtDebai.Text = "Như có (1)____ trong ngày vui đại thắng. Lời bác (2)____ dành chiến thắng (3)____" +
                "Ba mươi năm đấu (4)____ toàn vẹn (5)____. Ba mươi năm (6)____, kháng " +
                "chiến đã (7)____. " + "(8)____ Hồ Chí Minh! Việt Nam (9)____ ! ";

            list.Add("textBox1,Bác Hồ");
            list.Add("textBox2,hay");
            list.Add("textBox3,huy hoàng");
            list.Add("textBox4,tranh giành");
            list.Add("textBox5,non sông");
            list.Add("textBox6,dân chủ cộng hòa");
            list.Add("textBox7,thành công");
            list.Add("textBox8,Việt Nam");
            list.Add("textBox9,Hồ Chí Minh");
        }

        private bool KiemTra(TextBox textBox)
        {
            if (textBox.Text == "")
                return false;
            foreach (string str in list)
            {
                string[] res = str.Split(',');
                if (textBox.Name == res[0] 
                    && textBox.Text.Equals
                    (res[1], StringComparison.CurrentCultureIgnoreCase)
                )
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Control control in groupBox1.Controls)
            {
                Console.WriteLine("dung");

                if (control is TextBox && control != txtDebai)
                {
                    Console.WriteLine("dung");
                    TextBox res = (TextBox) control;
                    if (KiemTra(res))
                    {
                        res.ForeColor = Color.Green;
                        count++;
                    }else
                    {
                        res.ForeColor = Color.Red;
                    }
                }
            }
            status = true;
            MessageBox.Show($"Điểm của bạn là {count}", "Kết quả",
                MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {

                if (control is TextBox && control != txtDebai)
                {
                    control.Text = "";
                    control.ForeColor = Color.Black;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = list.Count;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox && control != txtDebai)
                {
                    control.Text = list[--index].Split(',')[1];
                    control.ForeColor = Color.Pink;
                }
            }
            status = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Xác nhận thoát", "Thoát", 
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (result == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (status== true)
            {
                foreach (Control control in groupBox1.Controls)
                {

                    if (control is TextBox && control != txtDebai)
                    {
                        control.Text = "";
                        control.ForeColor = Color.Black;
                    }
                }
            }
            status = false; 
        }

        private void nhưCóBácTrongNgàyĐạiThắngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoDeBai1();
            button2_Click(sender, e);
        }

        private void quốcCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoDeBai2();
            button2_Click(sender, e);
        }
    }
}
