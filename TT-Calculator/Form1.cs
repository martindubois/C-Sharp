
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-Calculator/Form1.cs

using System;
using System.Windows.Forms;

namespace TT_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            mCalculator = new Calculator();

            InitializeComponent();

            cPush.Enabled = false;

            cOutput.Text = "Hello\r\n";

            UpdateOperatorsState();
        }

        private void OutputLine(String aLine)
        {
            cOutput.Text += aLine + "\r\n";
        }

        private void UpdateOperatorsState()
        {
            bool lState = 2 <= mCalculator.StackDept;

            cAdd.Enabled = lState;
            cDiv.Enabled = lState;
            cMul.Enabled = lState;
            cSub.Enabled = lState;
        }

        private void cAdd_Click(object sender, EventArgs e)
        {
            OutputLine("+");
            OutputLine(mCalculator.Add().ToString());

            UpdateOperatorsState();
        }

        private void cDiv_Click(object sender, EventArgs e)
        {
            OutputLine("/");
            OutputLine(mCalculator.Div().ToString());

            UpdateOperatorsState();
        }

        private void cMul_Click(object sender, EventArgs e)
        {
            OutputLine("*");
            OutputLine(mCalculator.Mul().ToString());

            UpdateOperatorsState();
        }

        private void cPush_Click(object sender, EventArgs e)
        {
            OutputLine(mCalculator.Push(Convert.ToDouble(cValue.Text)).ToString());

            // cPush.Enabled = false;
            cValue.Text = "";

            UpdateOperatorsState();
        }

        private void cReset_Click(object sender, EventArgs e)
        {
            OutputLine("Reset");

            mCalculator.Reset();
        }

        private void cSub_Click(object sender, EventArgs e)
        {
            OutputLine("-");
            OutputLine(mCalculator.Sub().ToString());

            UpdateOperatorsState();
        }

        private void cValue_TextChanged(object sender, EventArgs e)
        {
            cPush.Enabled = 0 < cValue.Text.Length;
        }

        private Calculator mCalculator;

    }

}
