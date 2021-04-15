using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cayley
{
    public partial class Form1 : Form
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;
        private Color color;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "10";
            text1 = textBox1.Text;
            textBox2.Text = "100";
            text2 = textBox2.Text;
            textBox9.Text = "0.6";
            text3 = textBox9.Text;
            textBox10.Text = "0.7";
            text4 = textBox10.Text;
            textBox11.Text = "30";
            text5 = textBox11.Text;
            textBox12.Text = "20";
            text6 = textBox12.Text;
            color = Color.Blue;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar2.Value.ToString();
            text1 = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");
                if (rex.IsMatch(textBox1.Text))
                {
                    int num = Convert.ToInt32(textBox1.Text);
                    if (num >= 1 && num <= 20)
                    {
                        hScrollBar2.Value = Convert.ToInt32(textBox1.Text);
                        text1 = textBox1.Text;
                    }
                    else
                    {
                        textBox1.Text = text1;
                    }
                }
                else
                {
                    textBox1.Text = text1;
                }
            }
            else
            {
                textBox1.Text = text1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double per1 = Convert.ToDouble(textBox9.Text);
            double per2 = Convert.ToDouble(textBox10.Text);
            double th1 = Convert.ToInt32(textBox11.Text) * Math.PI / 180;
            double th2 = Convert.ToInt32(textBox12.Text) * Math.PI / 180;
            if (graphics == null) { graphics = panel1.CreateGraphics(); }
            graphics.Clear(panel1.BackColor);
            drawCayleyTree(Convert.ToInt32(textBox1.Text), 370, 510, Convert.ToInt32(textBox2.Text), -Math.PI / 2, per1, per2,th1,th2);
        }

        private Graphics graphics;
        
        
        

        void drawCayleyTree(int n, double x0, double y0, double leng, double th,double per1, double per2, double th1, double th2)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1,per1,per2,th1,th2);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2,per1,per2,th1,th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            Pen pen = new Pen(color);
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");
                if (rex.IsMatch(textBox2.Text))
                {
                    int num = Convert.ToInt32(textBox2.Text);
                    if (num >= 80 && num <= 170)
                    {
                        hScrollBar3.Value = Convert.ToInt32(textBox2.Text);
                        text2 = textBox2.Text;
                    }
                    else
                    {
                        textBox2.Text = text2;
                    }
                }
                else
                {
                    textBox2.Text = text2;
                }
            }
            else
            {
                textBox2.Text = text2;
            }
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = hScrollBar3.Value.ToString();
            text2 = textBox2.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+(.\d)+$");
                if (rex.IsMatch(textBox9.Text))
                {
                    double num = Convert.ToDouble(Convert.ToDouble(textBox9.Text).ToString("#0.0"));
                    if (num >= 0.1 && num <= 0.9)
                    {
                        hScrollBar4.Value = (int)(num*10);
                        text3 = num.ToString();
                    }
                    else
                    {
                        textBox9.Text = text3;
                    }
                }
                else
                {
                    textBox9.Text = text3;
                }
            }
            else
            {
                textBox9.Text = text3;
            }
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            double a = hScrollBar4.Value / 10.0;
            textBox9.Text = a.ToString("#0.0");
            text3 = textBox9.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+(.\d)+$");
                if (rex.IsMatch(textBox10.Text))
                {
                    double num = Convert.ToDouble(Convert.ToDouble(textBox10.Text).ToString("#0.0"));
                    if (num >= 0.1 && num <= 0.9)
                    {
                        hScrollBar5.Value = (int)(num * 10);
                        text4 = num.ToString();
                    }
                    else
                    {
                        textBox10.Text = text4;
                    }
                }
                else
                {
                    textBox10.Text = text4;
                }
            }
            else
            {
                textBox10.Text = text4;
            }
        }

        private void hScrollBar5_Scroll(object sender, ScrollEventArgs e)
        {
            double a = hScrollBar5.Value / 10.0;
            textBox10.Text = a.ToString("#0.0");
            text4 = textBox10.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");
                if (rex.IsMatch(textBox11.Text))
                {
                    int num = Convert.ToInt32(textBox11.Text);
                    if (num >= 10 && num <= 90)
                    {
                        hScrollBar6.Value = Convert.ToInt32(textBox11.Text);
                        text5 = textBox11.Text;
                    }
                    else
                    {
                        textBox11.Text = text5;
                    }
                }
                else
                {
                    textBox11.Text = text5;
                }
            }
            else
            {
                textBox11.Text = text5;
            }
        }

        private void hScrollBar6_Scroll(object sender, ScrollEventArgs e)
        {
            textBox11.Text = hScrollBar6.Value.ToString();
            text5 = textBox11.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");
                if (rex.IsMatch(textBox12.Text))
                {
                    int num = Convert.ToInt32(textBox12.Text);
                    if (num >= 10 && num <= 90)
                    {
                        hScrollBar6.Value = Convert.ToInt32(textBox12.Text);
                        text6 = textBox12.Text;
                    }
                    else
                    {
                        textBox12.Text = text6;
                    }
                }
                else
                {
                    textBox12.Text = text6;
                }
            }
            else
            {
                textBox12.Text = text6;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox12.Text = hScrollBar1.Value.ToString();
            text6 = textBox12.Text;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button2.BackColor = colorDialog1.Color;
            color = button2.BackColor;
        }
    }
}
