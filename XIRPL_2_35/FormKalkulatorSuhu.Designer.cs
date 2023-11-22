namespace XIRPL_2_35
{
    partial class FormKalkulatorSuhu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            nilai_1 = new TextBox();
            Celcius_Fahrenheit = new Button();
            Celcius_Reamur = new Button();
            Celcius_Kelvin = new Button();
            Reamur_Celcius = new Button();
            Reamur_Kelvin = new Button();
            Kelvin_Reamur = new Button();
            Kelvin_Celcius = new Button();
            lbl_hasil = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 57);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Masukkan Suhu ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 57);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // nilai_1
            // 
            nilai_1.Location = new Point(172, 54);
            nilai_1.Name = "nilai_1";
            nilai_1.Size = new Size(132, 23);
            nilai_1.TabIndex = 2;
            // 
            // Celcius_Fahrenheit
            // 
            Celcius_Fahrenheit.Location = new Point(72, 118);
            Celcius_Fahrenheit.Name = "Celcius_Fahrenheit";
            Celcius_Fahrenheit.Size = new Size(149, 44);
            Celcius_Fahrenheit.TabIndex = 3;
            Celcius_Fahrenheit.Text = "Celcius Ke Fahrenheit";
            Celcius_Fahrenheit.UseVisualStyleBackColor = true;
            Celcius_Fahrenheit.Click += Celcius_Fahrenheit_Click;
            // 
            // Celcius_Reamur
            // 
            Celcius_Reamur.Location = new Point(72, 204);
            Celcius_Reamur.Name = "Celcius_Reamur";
            Celcius_Reamur.Size = new Size(149, 42);
            Celcius_Reamur.TabIndex = 4;
            Celcius_Reamur.Text = "Celcius Ke Reamur";
            Celcius_Reamur.UseVisualStyleBackColor = true;
            Celcius_Reamur.Click += Celcius_Reamur_Click;
            // 
            // Celcius_Kelvin
            // 
            Celcius_Kelvin.Location = new Point(72, 293);
            Celcius_Kelvin.Name = "Celcius_Kelvin";
            Celcius_Kelvin.Size = new Size(149, 34);
            Celcius_Kelvin.TabIndex = 5;
            Celcius_Kelvin.Text = "Celcius Ke Kelvin";
            Celcius_Kelvin.UseVisualStyleBackColor = true;
            Celcius_Kelvin.Click += Kelvin_Click;
            // 
            // Reamur_Celcius
            // 
            Reamur_Celcius.Location = new Point(330, 118);
            Reamur_Celcius.Name = "Reamur_Celcius";
            Reamur_Celcius.Size = new Size(138, 44);
            Reamur_Celcius.TabIndex = 6;
            Reamur_Celcius.Text = "Reamur Ke Celcius";
            Reamur_Celcius.UseVisualStyleBackColor = true;
            Reamur_Celcius.Click += Reamur_Celcius_Click;
            // 
            // Reamur_Kelvin
            // 
            Reamur_Kelvin.Location = new Point(330, 204);
            Reamur_Kelvin.Name = "Reamur_Kelvin";
            Reamur_Kelvin.Size = new Size(138, 42);
            Reamur_Kelvin.TabIndex = 7;
            Reamur_Kelvin.Text = "Reamur Ke Kelvin";
            Reamur_Kelvin.UseVisualStyleBackColor = true;
            Reamur_Kelvin.Click += Reamur_Kelvin_Click;
            // 
            // Kelvin_Reamur
            // 
            Kelvin_Reamur.Location = new Point(554, 118);
            Kelvin_Reamur.Name = "Kelvin_Reamur";
            Kelvin_Reamur.Size = new Size(135, 44);
            Kelvin_Reamur.TabIndex = 8;
            Kelvin_Reamur.Text = "Kelvin Ke Reamur";
            Kelvin_Reamur.UseVisualStyleBackColor = true;
            Kelvin_Reamur.Click += Kelvin_Reamur_Click;
            // 
            // Kelvin_Celcius
            // 
            Kelvin_Celcius.Location = new Point(554, 204);
            Kelvin_Celcius.Name = "Kelvin_Celcius";
            Kelvin_Celcius.Size = new Size(135, 42);
            Kelvin_Celcius.TabIndex = 9;
            Kelvin_Celcius.Text = "Kelvin Ke Celcius";
            Kelvin_Celcius.UseVisualStyleBackColor = true;
            Kelvin_Celcius.Click += Kelvin_Celcius_Click;
            // 
            // lbl_hasil
            // 
            lbl_hasil.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_hasil.Location = new Point(355, 9);
            lbl_hasil.Name = "lbl_hasil";
            lbl_hasil.Size = new Size(421, 99);
            lbl_hasil.TabIndex = 10;
            lbl_hasil.Text = "0";
            // 
            // FormKalkulatorSuhu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_hasil);
            Controls.Add(Kelvin_Celcius);
            Controls.Add(Kelvin_Reamur);
            Controls.Add(Reamur_Kelvin);
            Controls.Add(Reamur_Celcius);
            Controls.Add(Celcius_Kelvin);
            Controls.Add(Celcius_Reamur);
            Controls.Add(Celcius_Fahrenheit);
            Controls.Add(nilai_1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormKalkulatorSuhu";
            Text = "FormKalkulatorSuhu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nilai_1;
        private Button Celcius_Fahrenheit;
        private Button Celcius_Reamur;
        private Button Celcius_Kelvin;
        private Button Reamur_Celcius;
        private Button Reamur_Kelvin;
        private Button Kelvin_Reamur;
        private Button Kelvin_Celcius;
        private Label lbl_hasil;
    }
}