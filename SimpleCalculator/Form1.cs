using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            try
            {
                firstNumber = float.Parse(txtFirstNumber.Text);
                secondNumber = float.Parse(txtSecondNumber.Text);
                result = firstNumber + secondNumber;
                lbAnswer.Text = "The answer is: " + result.ToString();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            lbAnswer.Text = "The answer is: ...";
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            try
            {
                firstNumber = float.Parse(txtFirstNumber.Text);
                secondNumber = float.Parse(txtSecondNumber.Text);
                result = firstNumber - secondNumber;
                lbAnswer.Text = "The answer is: " + result.ToString();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            try
            {
                firstNumber = float.Parse(txtFirstNumber.Text);
                secondNumber = float.Parse(txtSecondNumber.Text);
                result = firstNumber / secondNumber;
                lbAnswer.Text = "The answer is: " + result.ToString();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            try
            {
                firstNumber = float.Parse(txtFirstNumber.Text);
                secondNumber = float.Parse(txtSecondNumber.Text);
                result = firstNumber * secondNumber;
                lbAnswer.Text = "The answer is: " + result.ToString();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }
    }
}
