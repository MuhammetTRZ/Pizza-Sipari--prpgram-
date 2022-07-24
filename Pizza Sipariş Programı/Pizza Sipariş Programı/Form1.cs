using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Sipariş_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text+" "+textBox2.Text);


            int esayısı = checkedListBox1.CheckedItems.Count;
            for (int i = 0; i < esayısı; i++)
            {
                listBox3.Items.Add(checkedListBox1.CheckedItems[i]);
            }



            {
                if (radioButton1.Checked)
                {
                    label5.Text = radioButton1.Text;
                    listBox2.Items.Add("pizza boyutu= " + radioButton1.Text);
                    
                }
            }
            {
                if (radioButton2.Checked)
                {
                    label5.Text = radioButton2.Text;
                    listBox2.Items.Add("pizza boyutu= " + radioButton2.Text);
                }
            }
            {
                if (radioButton3.Checked)
                {
                    label5.Text = radioButton3.Text;
                    listBox2.Items.Add("pizza boyutu= " + radioButton3.Text);
                }
            }
            {
                if (radioButton4.Checked)
                {
                    label5.Text = radioButton4.Text;
                    listBox2.Items.Add("pizza boyutu= " + radioButton4.Text);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            radioButton1.Checked = false; radioButton2.Checked=false; radioButton3.Checked=false;radioButton4.Checked = false;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();

            }
        }
    }
}
