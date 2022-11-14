using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class MainForm : Form
    {
        long firstNum = 0;
        long secondNum = 0;
        string operation = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Num_Click(object sender, EventArgs e)
        {
            if (txt_result.Text == "0")
            {
                txt_result.Text = "";
            }
            txt_result.Text += ((Button)sender).Text;
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            long result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "X":
                    result = secondNum * firstNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
            }
        }

        private void btn_Operator_Click(object sender, EventArgs e)
        {
            operation = ((Button)sender).Text;
            firstNum = long.Parse(txt_result.Text);
            txt_result.Text = "";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {

        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {

        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {

        }

        private void btn_c_Click(object sender, EventArgs e)
        {

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {

        }
    }
}
