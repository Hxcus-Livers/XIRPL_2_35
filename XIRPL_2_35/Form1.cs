using System;

namespace XIRPL_2_35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isDecimal = false;
        private bool NumericOnly(System.Windows.Forms.KeyPressEventArgs e)
        {
            string strValid = "0123456789.";

            if (strValid.IndexOf(e.KeyChar) < 0 && !(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            //deklarasi variabel a,b,c dengan tipe data double
            double a, b, c;
            //mengkonversikan textbox yang bertipe data string dirubah menjadi tipe data double 
            a = double.Parse(nilai_1.Text);
            b = double.Parse(nilai_2.Text);
            //melakukan operasi hitungan yaitu tambah (+)
            c = a + b;
            //menampilkan hasil perhitungan yang di tampung di variabel c untuk di tampilkan di textbox
            //hasil dengan mengkonversikan kembali ke bentuk text
            hasil.Text = c.ToString();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            //deklarasi variabel a,b,c dengan tipe data double
            double a, b, c;
            //mengkonversikan textbox yang bertipe data string dirubah menjadi tipe data double 
            a = double.Parse(nilai_1.Text);
            b = double.Parse(nilai_2.Text);
            //melakukan operasi hitungan yaitu tambah (+)
            c = a - b;
            //menampilkan hasil perhitungan yang di tampung di variabel c untuk di tampilkan di textbox
            //hasil dengan mengkonversikan kembali ke bentuk text
            hasil.Text = c.ToString();
        }

        private void btn_kali_Click(object sender, EventArgs e)
        {
            //deklarasi variabel a,b,c dengan tipe data double
            double a, b, c;
            //mengkonversikan textbox yang bertipe data string dirubah menjadi tipe data double 
            a = double.Parse(nilai_1.Text);
            b = double.Parse(nilai_2.Text);
            //melakukan operasi hitungan yaitu tambah (+)
            c = a * b;
            //menampilkan hasil perhitungan yang di tampung di variabel c untuk di tampilkan di textbox
            //hasil dengan mengkonversikan kembali ke bentuk text
            hasil.Text = c.ToString();
        }

        private void btn_bagi_Click(object sender, EventArgs e)
        {
            //deklarasi variabel a,b,c dengan tipe data double
            double a, b, c;
            //mengkonversikan textbox yang bertipe data string dirubah menjadi tipe data double 
            a = double.Parse(nilai_1.Text);
            b = double.Parse(nilai_2.Text);
            //melakukan operasi hitungan yaitu tambah (+)
            c = a / b;
            //menampilkan hasil perhitungan yang di tampung di variabel c untuk di tampilkan di textbox
            //hasil dengan mengkonversikan kembali ke bentuk text
            hasil.Text = c.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            hasil.Text = "";
            nilai_1.Text = "";
            nilai_2.Text = "";
        }

        private void nilai_1_TextChanged(object sender, EventArgs e)
        {
            isDecimal = false;

            int index = ((TextBox)sender).Text.IndexOf(".");
            isDecimal = !(index < 0);
        }

        private void nilai_2_TextChanged(object sender, EventArgs e)
        {
            isDecimal = false;

            int index = ((TextBox)sender).Text.IndexOf(".");
            isDecimal = !(index < 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_suhu_Click(object sender, EventArgs e)
        {
            FormKalkulatorSuhu konversiSuhu = new FormKalkulatorSuhu();
            konversiSuhu.Show();
        }

        private void btn_bilangan_Click(object sender, EventArgs e)
        {
            FormKonversiBilangan konversiBilangan = new FormKonversiBilangan();
            konversiBilangan.Show();
        }
    }
}