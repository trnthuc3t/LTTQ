using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNTTVA2K63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thêm vào listview
            ListViewItem item = new ListViewItem();
            item.Text = textBox1.Text;
            item.SubItems.Add(textBox2.Text);
            item.SubItems.Add(textBox3.Text);
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sua
            int i = listView1.SelectedItems[0].Index;
           // listView1.Items[i].Text = textBox1.Text;
            listView1.Items[i].SubItems[1].Text = textBox2.Text;
            listView1.Items[i].SubItems[2].Text = textBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                if(MessageBox.Show("ban co muon xoa k","thong bao",MessageBoxButtons.OKCancel)==
                    DialogResult.OK)
                {
                    int i = listView1.SelectedItems[0].Index;
                    listView1.Items.RemoveAt(i);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            if (listView1.SelectedItems.Count > 0)
            {
                item = listView1.SelectedItems[0];
                textBox1.Text = item.Text;
                textBox2.Text = item.SubItems[1].Text;
                textBox3.Text = item.SubItems[2].Text;
                    }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
