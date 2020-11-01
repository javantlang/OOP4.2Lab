using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4._2Lab
{
    public partial class View : Form
    {
        Model model;
        public View()
        {
            InitializeComponent();
            model = new Model();
            model.changes += new System.EventHandler(this.UpdateForm);
        }

        private void txtboxNumb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValue1 = Int32.Parse(txtboxNumb1.Text);
            }
        }

        private void txtboxNumb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValue2 = Int32.Parse(txtboxNumb2.Text);
            }
        }

        private void numericNumb1_ValueChanged(object sender, EventArgs e)
        {
            model.setValue1 = (Int32)numericNumb1.Value;
        }

        private void numericNumb2_ValueChanged(object sender, EventArgs e)
        {
            model.setValue2 = (Int32)numericNumb2.Value;
        }

        private void richtxtboxNumb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValue1 = Int32.Parse(richtxtboxNumb1.Text);
            }
        }

        private void richtxtboxNumb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValue2 = Int32.Parse(richtxtboxNumb2.Text);
            }
        }

        private void UpdateForm(object sender, EventArgs e)
        {
            richtxtboxNumb1.Text = model.getValue1.ToString();
            txtboxNumb1.Text = model.getValue1.ToString();
            numericNumb1.Value = model.getValue1;

            richtxtboxNumb2.Text = model.getValue2.ToString();
            txtboxNumb2.Text = model.getValue2.ToString();
            numericNumb2.Value = model.getValue2;
        }
    }
    public class Model
    {
        private int number1;
        private int number2;
        public System.EventHandler changes;

        public Model()
        {
            number1 = 1;
            number2 = 0;
        }

        public int setValue1
        {
            set
            {
                if (value <= number2)
                {
                    number1 = number2 + 1;
                }
                else
                    number1 = value;

                changes.Invoke(this, null);
            }
        }
        public int setValue2
        {
            set
            {
                if (value >= number1)
                {
                    number2 = value;
                    number1 = number2 + 1;
                }
                else
                    number2 = value;

                changes.Invoke(this, null);
            }
        }
        public int getValue1
        {
            get => number1;
        }
        public int getValue2
        {
            get => number2;
        }
    }
}
