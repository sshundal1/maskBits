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
    public partial class Form1 : Form
    {
        public Form1() //first function which is called
        {
            InitializeComponent();
            value1.Text = "0";
            value2.Text = "0";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int input1 = 0;
            int input2 = 0;

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
                    input1 = Convert.ToInt32(value1.Text, 2);
                    input2 = Convert.ToInt32(value2.Text, 2);
                    break;
                default:
                    break;
            }

            int output;


            switch (operatorSelection.Text)
            {
                case "&":
                    output = input1 & input2;
                    endValue.Text = output.ToString();
                    break;
                case "|":
                    output = input1 | input2;
                    endValue.Text = output.ToString();
                    break;
                default:
                    endValue.Text = "N/A";
                    break;
            }

        }
    }
}
