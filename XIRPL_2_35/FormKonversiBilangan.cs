using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIRPL_2_35
{
    public partial class FormKonversiBilangan : Form
    {
        public FormKonversiBilangan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int desimal, sisa;
            string hasil = "";
            desimal = Convert.ToInt32(nilai_1.Text);
            while (desimal > 0)
            {
                sisa = desimal % 2;
                desimal /= 2;
                hasil = sisa.ToString() + hasil;
            }
            lbl_hasil.Text = hasil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int desimal, sisa;
            string hasil = "";
            desimal = Convert.ToInt32(nilai_1.Text);
            while (desimal > 0)
            {
                sisa = desimal % 8;
                desimal /= 8;
                hasil = sisa.ToString() + hasil;
            }
            lbl_hasil.Text = hasil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int desimal, sisa;
            string hasil = "";
            desimal = Convert.ToInt32(nilai_1.Text);
            while (desimal > 0)
            {
                sisa = desimal % 16;
                desimal /= 16;
                if (sisa >= 10)
                {
                    char huruf = (char)(sisa - 10 + 'A'); 
                    hasil = huruf.ToString() + hasil;
                }
                else
                {
                    hasil = sisa.ToString() + hasil;
                }
            }
            lbl_hasil.Text = hasil;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int binner, desimal = 0;
            binner = Convert.ToInt32(nilai_1.Text);
            int j = 0;
            while (binner > 0)
            {
                int temp = binner % 10;
                binner /= 10;
                desimal += temp * (int)Math.Pow(2, j);
                j++;
            }
            lbl_hasil.Text = desimal.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string binner = nilai_1.Text;
            int desimal = 0;
            int j = 0;
            for (int i = binner.Length - 1; i >= 0; i--)
            {
                int temp = binner[i] == '1' ? 1 : 0;
                desimal += temp * (int)Math.Pow(2, j);
                j++;
            }
            lbl_hasil.Text = Convert.ToString(desimal, 8);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string binner = nilai_1.Text;
            int desimal = 0;
            int j = 0;
            for (int i = binner.Length - 1; i >= 0; i--)
            {
                int temp = binner[i] == '1' ? 1 : 0;
                desimal += temp * (int)Math.Pow(2, j);
                j++;
            }

            string hex = desimal.ToString("X");
            lbl_hasil.Text = hex;
        }
    }
}
