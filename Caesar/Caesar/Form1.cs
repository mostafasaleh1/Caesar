using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Caesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "I want to Encrypt text with Caesar")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                label4.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
            }
            else if(comboBox1.Text == "I want to Decrypt text with Caesar")
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
                button1.Visible = false;
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int key = int.Parse(textBox1.Text);
                if (key > 0 && key <= 26)
                {

                }
                else
                {
                    MessageBox.Show("Key must be withing the range [1 : 26]");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
