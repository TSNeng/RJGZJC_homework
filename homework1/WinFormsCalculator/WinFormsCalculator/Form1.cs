using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCalculator;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        string operator_;
        string String = "";
        float[] numbers = new float[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number_add(button1.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number_add(button4.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number_add(button5.Text);
            textBox1.Text = String;
            textBox1.Show();
        }
        private void number_add(string num)
        {
            String += num;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            number_add(button2.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number_add(button7.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number_add(button9.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number_add(button3.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number_add(button10.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number_add(button8.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numbers[0] = Convert.ToSingle(String);
            operator_ = button6.Text;
            String = "";
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            number_add(button18.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number_add(button17.Text);
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numbers[0] = Convert.ToSingle(String);
            operator_ = button14.Text;
            String = "";
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numbers[0] = Convert.ToSingle(String);
            operator_ = button11.Text;
            String = "";
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numbers[0] = Convert.ToSingle(String);
            operator_ = button15.Text;
            String = "";
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numbers[0] = Convert.ToSingle(String);
            operator_ = button12.Text;
            String = "";
            textBox1.Text = String;
            textBox1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numbers[1] = Convert.ToSingle(String);
            if (operator_ == "+")
            {
                textBox1.Text = (numbers[0] + numbers[1]).ToString();
                textBox1.Show();
                String = "";
            }

            if (operator_ == "-")
            {
                textBox1.Text = (numbers[0] - numbers[1]).ToString();
                textBox1.Show();
                String = "";
            }

            if (operator_ == "*")
            {
                textBox1.Text = (numbers[0] * numbers[1]).ToString();
                textBox1.Show();
                String = "";
            }

            if (operator_ == "/")
            {
                textBox1.Text = (numbers[0] / numbers[1]).ToString();
                textBox1.Show();
                String = "";
            }

            if (operator_ == "%")
            {
                textBox1.Text = (numbers[0] % numbers[1]).ToString();
                textBox1.Show();
                String = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            String = String.Substring(0, String.Length - 1);
            textBox1.Text = String;
            textBox1.Show();
        }
    }
}
