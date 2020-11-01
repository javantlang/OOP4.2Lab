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

        private void txtboxNumb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Int32.Parse(txtboxNumb1.Text) <= Int32.Parse(txtboxNumb2.Text))
                {
                    txtboxNumb1.Text = (Int32.Parse(txtboxNumb2.Text) + 1).ToString();
                    numericNumb1.Value = Int32.Parse(txtboxNumb2.Text) + 1;
                    richtxtboxNumb1.Text = (Int32.Parse(txtboxNumb2.Text) + 1).ToString();
                }
                numericNumb1.Value = Int32.Parse(txtboxNumb1.Text);
                richtxtboxNumb1.Text = txtboxNumb1.Text;
            }
        }

        private void txtboxNumb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Int32.Parse(txtboxNumb1.Text) <= Int32.Parse(txtboxNumb2.Text))
                {
                    txtboxNumb1.Text = (Int32.Parse(txtboxNumb2.Text) + 1).ToString();
                    numericNumb1.Value = Int32.Parse(txtboxNumb2.Text) + 1;
                    richtxtboxNumb1.Text = (Int32.Parse(txtboxNumb2.Text) + 1).ToString();
                }
                numericNumb2.Value = Int32.Parse(txtboxNumb2.Text);
                richtxtboxNumb2.Text = txtboxNumb2.Text;
            }
        }

        private void numericNumb1_ValueChanged(object sender, EventArgs e)
        {
            if (numericNumb1.Value <= numericNumb2.Value)
            {
                txtboxNumb1.Text = (Int32.Parse(txtboxNumb2.Text) + 1).ToString();
                numericNumb1.Value = Int32.Parse(txtboxNumb2.Text) + 1;
                richtxtboxNumb1.Text = (Int32.Parse(txtboxNumb2.Text) + 1).ToString();
            }
            txtboxNumb1.Text = numericNumb1.Value.ToString();
            richtxtboxNumb1.Text = numericNumb1.Value.ToString();
        }

        private void numericNumb2_ValueChanged(object sender, EventArgs e)
        {
            if (numericNumb1.Value <= numericNumb2.Value)
            {
                txtboxNumb1.Text = (numericNumb2.Value + 1).ToString();
                numericNumb1.Value = numericNumb2.Value + 1;
                richtxtboxNumb1.Text = (numericNumb2.Value + 1).ToString();
            }
            txtboxNumb2.Text = numericNumb2.Value.ToString();
            richtxtboxNumb2.Text = numericNumb2.Value.ToString();
        }

        private void richtxtboxNumb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Int32.Parse(richtxtboxNumb1.Text) <= Int32.Parse(richtxtboxNumb2.Text))
            {
                txtboxNumb1.Text = (Int32.Parse(richtxtboxNumb2.Text) + 1).ToString();
                numericNumb1.Value = Int32.Parse(richtxtboxNumb2.Text) + 1;
                richtxtboxNumb1.Text = (Int32.Parse(richtxtboxNumb2.Text) + 1).ToString();
            }
            txtboxNumb1.Text = richtxtboxNumb1.Text;
            numericNumb1.Value = Int32.Parse(richtxtboxNumb1.Text);
        }

        private void richtxtboxNumb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Int32.Parse(richtxtboxNumb1.Text) <= Int32.Parse(richtxtboxNumb2.Text))
            {
                txtboxNumb1.Text = (Int32.Parse(richtxtboxNumb2.Text) + 1).ToString();
                numericNumb1.Value = Int32.Parse(richtxtboxNumb2.Text) + 1;
                richtxtboxNumb1.Text = (Int32.Parse(richtxtboxNumb2.Text) + 1).ToString();
            }
            txtboxNumb2.Text = richtxtboxNumb2.Text;
            numericNumb2.Value = Int32.Parse(richtxtboxNumb2.Text);
        }
    }
}
