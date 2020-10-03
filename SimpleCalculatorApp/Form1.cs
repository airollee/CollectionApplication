using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getSum);

            int num1 = Int32.Parse(Number1.Text);
            int num2 = Int32.Parse(Number2.Text);
            string title = "Answer: ";

            MessageBox.Show(delegateAnswer(num1, num2).ToString(), title);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getDifference);

            int num1 = Int32.Parse(Number1.Text);
            int num2 = Int32.Parse(Number2.Text);
            string title = "Answer: ";

            MessageBox.Show(delegateAnswer(num1, num2).ToString(), title);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getProduct);

            int num1 = Int32.Parse(Number1.Text);
            int num2 = Int32.Parse(Number2.Text);
            string title = "Answer: ";

            MessageBox.Show(delegateAnswer(num1, num2).ToString(), title);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getQuotient);

            int num1 = Int32.Parse(Number1.Text);
            int num2 = Int32.Parse(Number2.Text);
            string title = "Answer: ";

            MessageBox.Show(delegateAnswer(num1, num2).ToString(), title);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Number2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}