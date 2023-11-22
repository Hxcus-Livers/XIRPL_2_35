using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIRPL_2_35
{
    public partial class FormKalkulatorSuhu : Form
    {
        public FormKalkulatorSuhu()
        {
            InitializeComponent();
        }

        private void Kelvin_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(nilai_1.Text);
            b = a + 273;
            lbl_hasil.Text = b.ToString();
        }

        private void Kelvin_Celcius_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(nilai_1.Text);
            b = a - 273;
            lbl_hasil.Text = b.ToString();
        }

        private void Celcius_Fahrenheit_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(nilai_1.Text);
            b = a * 9 / 5 + 32;
            lbl_hasil.Text = b.ToString();
        }

        private void Celcius_Reamur_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(nilai_1.Text);
            b = a * 4 / 5;
            lbl_hasil.Text = b.ToString();
        }

        private void Reamur_Celcius_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(nilai_1.Text);
            b = a * 5 / 4;
            lbl_hasil.Text = b.ToString();
        }

        private void Reamur_Kelvin_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(nilai_1.Text);
            b = (a * 5 / 4) + 273.15;
            lbl_hasil.Text = b.ToString();
        }

        private void Kelvin_Reamur_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(nilai_1.Text);
            b = (a - 273.15) * 4 / 5;
            lbl_hasil.Text = b.ToString();
        }
    }
}
