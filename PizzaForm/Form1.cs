using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaForm
{
    public partial class Form1 : Form
    {
        double tomato = 2.5;
        double shunka = 3.0;
        double mustard = 0.10;
        double ketchup = 0.10;
        double mayones = 0.10;
        double sum = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSandwiches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSandwiches.Text == "Сандвич с домат")
            {
                pictureBox1.Image = Properties.Resources.tomato;
                sum += tomato;
                labelSum.Text = "Дължите" + sum + "лв.";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxTomatoSos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTomatoSos.CheckState == CheckState.Checked)
            {
                sum += 0.10;
            }
            
        }

        private void rbcash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcash.Checked)
            {
                sum = sum - sum * 0.5;
            }
        }

        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            double convert = double.Parse(textBoxClientPayment.Text);
            if (convert > sum)
            {
                MessageBox.Show($"Ресто:{Math.Abs(convert - sum)}лв", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Дължите още:{Math.Abs(sum - convert)}лв", "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
