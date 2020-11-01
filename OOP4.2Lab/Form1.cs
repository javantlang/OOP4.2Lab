using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4._2Lab
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void CheckValue(int number1, int number2)
        {
            if (number1 <= number2)
            {
                txtboxNumb1.Text = (number2 + 1).ToString();
                numericNumb1.Value = number2 + 1;
                richtxtboxNumb1.Text = (number2 + 1).ToString();
            }
        }

        private void txtboxNumb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckValue(Int32.Parse(txtboxNumb1.Text), Int32.Parse(txtboxNumb2.Text));
                numericNumb1.Value = Int32.Parse(txtboxNumb1.Text);
                richtxtboxNumb1.Text = txtboxNumb1.Text;
            }
        }

        private void txtboxNumb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckValue(Int32.Parse(txtboxNumb1.Text), Int32.Parse(txtboxNumb2.Text));
                numericNumb2.Value = Int32.Parse(txtboxNumb2.Text);
                richtxtboxNumb2.Text = txtboxNumb2.Text;
            }
        }

        private void numericNumb1_ValueChanged(object sender, EventArgs e)
        {
            CheckValue((Int32)numericNumb1.Value, (Int32)numericNumb2.Value);
            txtboxNumb1.Text = numericNumb1.Value.ToString();
            richtxtboxNumb1.Text = numericNumb1.Value.ToString();
        }

        private void numericNumb2_ValueChanged(object sender, EventArgs e)
        {
            CheckValue((Int32)numericNumb1.Value, (Int32)numericNumb2.Value);
            txtboxNumb2.Text = numericNumb2.Value.ToString();
            richtxtboxNumb2.Text = numericNumb2.Value.ToString();
        }

        private void richtxtboxNumb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckValue(Int32.Parse(richtxtboxNumb1.Text), Int32.Parse(richtxtboxNumb2.Text));
                txtboxNumb1.Text = richtxtboxNumb1.Text;
                numericNumb1.Value = Int32.Parse(richtxtboxNumb1.Text);
            }
        }

        private void richtxtboxNumb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckValue(Int32.Parse(richtxtboxNumb1.Text), Int32.Parse(richtxtboxNumb2.Text));
                txtboxNumb2.Text = richtxtboxNumb2.Text;
                numericNumb2.Value = Int32.Parse(richtxtboxNumb2.Text);
            }
        }
    }
}
