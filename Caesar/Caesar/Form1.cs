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
            /**
             * Behaviour elements according to the choice of the combobox
             */

            /* making elements appear when a choice made in the text box */
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            /* clearing all text in text boxes when a choice made in the combo box*/
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            if (comboBox1.Text == "I want to Encrypt text with Caesar") // When this choice is chosen, button 1 will appear, button 2 will disappear, and text on labels 3 and 4 will be changed as shown
            {

                button1.Visible = true;
                button2.Visible = false;
                label3.Text = "Text to be Encrypted";
                label4.Text = "Encrypted Text";

            }
            else if(comboBox1.Text == "I want to Decrypt text with Caesar") // When this choice is chosen, button 1 will disappear, button 2 will appear, and text on labels 3 and 4 will be changed as shown
            {

                button2.Visible = true;
                button1.Visible = false;
                label3.Text = "Decrypted Text";
                label4.Text = "Text to be Decrypted";
            }
            else if (comboBox1.Text == "None") // When this choice is chosen, all elements will disappear again
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else // Print error message if the user entered a strange choice
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
                if(textBox1.Text != "" || textBox1.Text == null) // if the user entered a key without errors do the following code
                {
                    int key = int.Parse(textBox1.Text); // convert the key into an integer
                    if (key > 0 && key < 26) // if the key is in the right range [1 : 25] do the following
                    {
                        string EncryptedText = ""; // declare an empty string.
                        /* Iterate through the input text to be encrypted and substitute into the following equations everytime to get the equivalent encrypted letters*/
                        for (int i = 0; i < textBox2.Text.Length; i++)
                        {
                            if (char.IsLetter(textBox2.Text[i])) // if input text is consisted of letters, do the following.
                            {
                                if (char.IsLower(textBox2.Text[i])) // if the input text is lower case, do the following.
                                {
                                    EncryptedText += (char)(((textBox2.Text[i] + key - 97) % 26) + 97); // encryption equation for small letters + concatinate each encrypted (shifted) letter to the variable EncryptedText
                                }
                                else // if the letters aren't small, then it's capital, and do the following
                                {
                                    EncryptedText += (char)(((textBox2.Text[i] + key - 65) % 26) + 65);// encryption equation for capital letters + concatinate each encrypted (shifted) letter to the variable EncryptedText
                                }
                            }
                            else // if input text is not consisted of letters, do the following.
                            {
                                EncryptedText += textBox2.Text[i]; // concatinate each non-letter symbol as it is to the resulting text
                            }
                        }
                        textBox3.Text = EncryptedText; // put the final result in the text box 3
                    }

                    else // if the key isn't in the range [1 : 25], print the following error message
                    {
                        MessageBox.Show("Error: Key must be withing the range [1 : 25]");
                    }
                }
                else // if the user didn't enter a key print this message box
                {
                    MessageBox.Show("Error: You must enter a key");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" || textBox1.Text == null) // if the user entered a key without errors do the following code
                {
                    int key = int.Parse(textBox1.Text); // convert the key into an integer
                    if (key > 0 && key < 26) // if the key is in the right range [1 : 25] do the following
                    {
                        string EncryptedText = ""; // declare an empty string.
                     /* Iterate through the input text to be Decrypted and substitute into the following equations everytime to get the equivalent Decrypted letters*/
                        for (int i = 0; i < textBox3.Text.Length; i++)
                        {
                            if (char.IsLetter(textBox3.Text[i])) // if input text is consisted of letters, do the following.
                            {
                                if (char.IsLower(textBox3.Text[i])) // if the input text is lower case, do the following.
                                {
                                    EncryptedText += (char)(((textBox3.Text[i] - key + 26 - 97) % 26) + 97); // Decryption equation for small letters + concatinate each Decrypted (shifted) letter to the variable EncryptedText
                                }
                                else // if the letters aren't small, then it's capital, and do the following
                                {
                                    EncryptedText += (char)(((textBox3.Text[i] - key + 26 - 65) % 26) + 65); // Decryption equation for capital letters + concatinate each Decrypted (shifted) letter to the variable EncryptedText
                                }
                            }
                            else // if input text is not consisted of letters, do the following.
                            {
                                EncryptedText += textBox3.Text[i]; // concatinate each non-letter symbol as it is to the resulting text
                            }
                        }
                        textBox2.Text = EncryptedText; // put the final result in the text box 2
                    }

                    else // if the key isn't in the range [1 : 25], print the following error message
                    {
                        MessageBox.Show("Error: Key must be withing the range [1 : 25]");
                    }
                }
                else // if the user didn't enter a key print this message box
                {
                    MessageBox.Show("Error: You must enter a key");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
