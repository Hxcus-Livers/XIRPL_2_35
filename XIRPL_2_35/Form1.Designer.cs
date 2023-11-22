namespace XIRPL_2_35
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_tambah = new Button();
            btn_min = new Button();
            btn_kali = new Button();
            btn_bagi = new Button();
            btn_clear = new Button();
            btn_suhu = new Button();
            btn_bilangan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nilai_1 = new TextBox();
            nilai_2 = new TextBox();
            hasil = new TextBox();
            SuspendLayout();
            // 
            // btn_tambah
            // 
            btn_tambah.Location = new Point(55, 240);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(75, 23);
            btn_tambah.TabIndex = 0;
            btn_tambah.Text = "+";
            btn_tambah.UseVisualStyleBackColor = true;
            btn_tambah.Click += btn_tambah_Click;
            // 
            // btn_min
            // 
            btn_min.Location = new Point(156, 240);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(75, 23);
            btn_min.TabIndex = 1;
            btn_min.Text = "-";
            btn_min.UseVisualStyleBackColor = true;
            btn_min.Click += btn_min_Click;
            // 
            // btn_kali
            // 
            btn_kali.Location = new Point(260, 240);
            btn_kali.Name = "btn_kali";
            btn_kali.Size = new Size(75, 23);
            btn_kali.TabIndex = 2;
            btn_kali.Text = "*";
            btn_kali.UseVisualStyleBackColor = true;
            btn_kali.Click += btn_kali_Click;
            // 
            // btn_bagi
            // 
            btn_bagi.Location = new Point(365, 240);
            btn_bagi.Name = "btn_bagi";
            btn_bagi.Size = new Size(75, 23);
            btn_bagi.TabIndex = 3;
            btn_bagi.Text = "/";
            btn_bagi.UseVisualStyleBackColor = true;
            btn_bagi.Click += btn_bagi_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(476, 240);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 4;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_suhu
            // 
            btn_suhu.Location = new Point(112, 288);
            btn_suhu.Name = "btn_suhu";
            btn_suhu.Size = new Size(374, 23);
            btn_suhu.TabIndex = 5;
            btn_suhu.Text = "Konversi Suhu";
            btn_suhu.UseVisualStyleBackColor = true;
            btn_suhu.Click += btn_suhu_Click;
            // 
            // btn_bilangan
            // 
            btn_bilangan.Location = new Point(112, 340);
            btn_bilangan.Name = "btn_bilangan";
            btn_bilangan.Size = new Size(374, 23);
            btn_bilangan.TabIndex = 6;
            btn_bilangan.Text = "Konversi Bilangan";
            btn_bilangan.UseVisualStyleBackColor = true;
            btn_bilangan.Click += btn_bilangan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 59);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "Angka 1 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 98);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Angka 2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 134);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Hasil";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 59);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 10;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 98);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 11;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 134);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 12;
            label6.Text = ":";
            // 
            // nilai_1
            // 
            nilai_1.Location = new Point(179, 59);
            nilai_1.Name = "nilai_1";
            nilai_1.Size = new Size(100, 23);
            nilai_1.TabIndex = 13;
            nilai_1.TextChanged += nilai_1_TextChanged;
            // 
            // nilai_2
            // 
            nilai_2.Location = new Point(179, 98);
            nilai_2.Name = "nilai_2";
            nilai_2.Size = new Size(100, 23);
            nilai_2.TabIndex = 14;
            nilai_2.TextChanged += nilai_2_TextChanged;
            // 
            // hasil
            // 
            hasil.Location = new Point(179, 134);
            hasil.Name = "hasil";
            hasil.Size = new Size(100, 23);
            hasil.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hasil);
            Controls.Add(nilai_2);
            Controls.Add(nilai_1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_bilangan);
            Controls.Add(btn_suhu);
            Controls.Add(btn_clear);
            Controls.Add(btn_bagi);
            Controls.Add(btn_kali);
            Controls.Add(btn_min);
            Controls.Add(btn_tambah);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_tambah;
        private Button btn_min;
        private Button btn_kali;
        private Button btn_bagi;
        private Button btn_clear;
        private Button btn_suhu;
        private Button btn_bilangan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nilai_1;
        private TextBox nilai_2;
        private TextBox hasil;
    }
}