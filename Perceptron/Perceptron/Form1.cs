using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        Perceptron perceptron;
        public Form1(Perceptron p)
        {
            perceptron = p;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            if(orButton.Checked || andButton.Checked || xorButton.Checked)
            {
                orButton.Enabled = false;
                andButton.Enabled = false;
                xorButton.Enabled = false;

                if (orButton.Checked)
                {
                    perceptron.Train(1, 0, 1, Convert.ToInt32(epochText.Text));
                    perceptron.Train(0, 1, 1, Convert.ToInt32(epochText.Text));
                    perceptron.Train(1, 1, 1, Convert.ToInt32(epochText.Text));
                    perceptron.Train(0, 0, 0, Convert.ToInt32(epochText.Text));
                }
                else if (andButton.Checked)
                {
                    perceptron.Train(1, 0, 0, Convert.ToInt32(epochText.Text));
                    perceptron.Train(0, 1, 0, Convert.ToInt32(epochText.Text));
                    perceptron.Train(1, 1, 1, Convert.ToInt32(epochText.Text));
                    perceptron.Train(0, 0, 0, Convert.ToInt32(epochText.Text));
                }
                else
                {
                    perceptron.Train(1, 0, 0, Convert.ToInt32(epochText.Text));
                    perceptron.Train(0, 1, 0, Convert.ToInt32(epochText.Text));
                    perceptron.Train(1, 1, 0, Convert.ToInt32(epochText.Text));
                    perceptron.Train(0, 0, 1, Convert.ToInt32(epochText.Text));
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text); 

            int output = perceptron.Activation(x1, x2);

            outputText.Text = output.ToString();
        }

        private void andButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
