using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                string a=textBox1.Text;
                SendKeys.Send(a);

            }
            if(checkBox6.Checked==true)
            {
                if(comboBox1.SelectedIndex==0)
                {
                    SendKeys.Send("{TAB}");
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    SendKeys.Send("{ENTER}");
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    SendKeys.Send("{BACKSPACE}");
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    SendKeys.Send("{F5}");
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    SendKeys.Send("{BREAK}");
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    SendKeys.Send("{DEL}");
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    SendKeys.Send("{ESC}");
                }

                
            }
            if (checkBox2.Checked == true)
            {
                string b = textBox2.Text;
                SendKeys.Send(b);

            }
            if (checkBox7.Checked == true)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    SendKeys.Send("{TAB}");
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    SendKeys.Send("{ENTER}");
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    SendKeys.Send("{BACKSPACE}");
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    SendKeys.Send("{F5}");
                }
                if (comboBox2.SelectedIndex == 4)
                {
                    SendKeys.Send("{BREAK}");
                }
                if (comboBox2.SelectedIndex == 5)
                {
                    SendKeys.Send("{DEL}");
                }
                if (comboBox2.SelectedIndex == 6)
                {
                    SendKeys.Send("{ESC}");
                }
               
            }
            if(checkBox3.Checked==true)
            {
                string c = textBox3.Text;
                SendKeys.Send(c);

            }
            if(checkBox8.Checked==true)
            {
                if (comboBox3.SelectedIndex == 0)
                {
                    SendKeys.Send("{TAB}");
                }
                if (comboBox3.SelectedIndex == 1)
                {
                    SendKeys.Send("{ENTER}");
                }
                if (comboBox3.SelectedIndex == 2)
                {
                    SendKeys.Send("{BACKSPACE}");
                }
                if (comboBox3.SelectedIndex == 3)
                {
                    SendKeys.Send("{F5}");
                }
                if (comboBox3.SelectedIndex == 4)
                {
                    SendKeys.Send("{BREAK}");
                }
                if (comboBox3.SelectedIndex == 5)
                {
                    SendKeys.Send("{DEL}");
                }
                if (comboBox3.SelectedIndex == 6)
                {
                    SendKeys.Send("{ESC}");
                }
               
            }
            if (checkBox4.Checked == true)
            {

                string d = textBox4.Text;
                SendKeys.Send(d);
            }
            if (checkBox9.Checked == true)
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    SendKeys.Send("{TAB}");
                }
                if (comboBox4.SelectedIndex == 1)
                {
                    SendKeys.Send("{ENTER}");
                }
                if (comboBox4.SelectedIndex == 2)
                {
                    SendKeys.Send("{BACKSPACE}");
                }
                if (comboBox4.SelectedIndex == 3)
                {
                    SendKeys.Send("{F5}");
                }
                if (comboBox4.SelectedIndex == 4)
                {
                    SendKeys.Send("{BREAK}");
                }
                if (comboBox4.SelectedIndex == 5)
                {
                    SendKeys.Send("{DEL}");
                }
                if (comboBox4.SelectedIndex == 6)
                {
                    SendKeys.Send("{ESC}");
                }
            }
            if (checkBox5.Checked == true)
            {

                string E = textBox5.Text;
                SendKeys.Send(E);
            }
            if (checkBox10.Checked == true)
            {
                if (comboBox5.SelectedIndex == 0)
                {
                    SendKeys.Send("{TAB}");
                }
                if (comboBox5.SelectedIndex == 1)
                {
                    SendKeys.Send("{ENTER}");
                }
                if (comboBox5.SelectedIndex == 2)
                {
                    SendKeys.Send("{BACKSPACE}");
                }
                if (comboBox5.SelectedIndex == 3)
                {
                    SendKeys.Send("{F5}");
                }
                if (comboBox5.SelectedIndex == 4)
                {
                    SendKeys.Send("{BREAK}");
                }
                if (comboBox5.SelectedIndex == 5)
                {
                    SendKeys.Send("{DEL}");
                }
                if (comboBox5.SelectedIndex == 6)
                {
                    SendKeys.Send("{ESC}");
                }
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello this software is intented to be used for education purpose only thank you.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("run the website and see the steps you would take to enter the details and then step wise check the boxes and then either fill the textbox or select from the box.for ex:you need to type in textbox and then use tab and then write again and enter,the steps would be step1 write in box.step2 click on menu and enter tab,step 4 write again in textbox and then choose menu for enter.");
        }
        }
    }

