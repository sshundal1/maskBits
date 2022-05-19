using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maskBits
{
    public partial class BitwiseOperator : Form
    {
        public BitwiseOperator() //first function which is called
        {
            InitializeComponent();

            //initialize some values to make it look better
            value1.Text = "0";
            value2.Text = "0";
            dataType.SelectedIndex = 1;
            operatorSelection.SelectedIndex = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool isBinary(string inputString)
        {
            if (inputString.Length == 0)
            {
                return false;
            }
            foreach (char i in inputString)
            {
                if (!((i == '0')|(i == '1')))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int input1 = 0;
            int input2 = 0;
            warningLabel.Text = "";

            //CHECKS for empty inputs
            if (String.IsNullOrEmpty(value1.Text))
            {
                value1.Text = "0";
            }
            if (String.IsNullOrEmpty(value2.Text))
            {
                value2.Text = "0";
            }

            switch (dataType.Text)
            {
                case "Decimal":
                    input1 = int.Parse(value1.Text);
                    input2 = int.Parse(value2.Text);
                    break;
                case "Hexadecimal":
                    input1 = int.Parse(value1.Text, System.Globalization.NumberStyles.HexNumber);
                    input2 = int.Parse(value2.Text, System.Globalization.NumberStyles.HexNumber);
                    break;
                case "Binary":
                    if (isBinary(value1.Text))
                    {
                        input1 = Convert.ToInt32(value1.Text, 2);
                    }
                    else
                    {
                        input1 = 0;
                        warningLabel.Text = "Incorrect Input";
                    }
                    if (isBinary(value2.Text))
                    {
                        input2 = Convert.ToInt32(value2.Text, 2);
                    }
                    else
                    {
                        input2 = 0;
                        warningLabel.Text = "Incorrect Input";
                    }
                    break;
                default:
                    break;
            }

            int output = 0;


            switch (operatorSelection.Text)
            {
                case "&":
                    output = input1 & input2;
                    break;
                case "|":
                    output = input1 | input2;
                    break;
                default:
                    break;
            }

            switch (dataType.Text)
            {
                case "Hexadecimal":
                    endValue.Text = output.ToString("X");
                    break;
                case "Binary":
                    endValue.Text = Convert.ToString(output, 2);
                    break;
                case "Decimal":
                    endValue.Text = output.ToString();
                    break;
            }

        }
    }
}
