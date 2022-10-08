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
            button2.Visible = false;
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
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            if (comboBox1.Text == "I want to Encrypt text with Caesar")
            {

                button1.Visible = true;
                button2.Visible = false;
                label3.Text = "Text to be Encrypted";
                label4.Text = "Encrypted Text";
            }
            else if(comboBox1.Text == "I want to Decrypt text with Caesar")
            {

                button2.Visible = true;
                button1.Visible = false;
                label3.Text = "Decrypted Text";
                label4.Text = "Text to be Decrypted";
            }
            else
            {
                MessageBox.Show("Error: Please choose from the selected options");
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
                    string EncryptedText = "";
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    {
                        if (char.IsLetter(textBox2.Text[i]))
                        {
                            if (char.IsLower(textBox2.Text[i]))
                            {
                                EncryptedText += (char)(((textBox2.Text[i] + key - 97) % 26) + 97);
                            }
                            else
                            {
                                EncryptedText += (char)(((textBox2.Text[i] + key - 65) % 26) + 65);
                            }
                        }
                        else
                        {
                            EncryptedText += textBox2.Text[i];
                        }
                    }
                    textBox3.Text = EncryptedText;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
