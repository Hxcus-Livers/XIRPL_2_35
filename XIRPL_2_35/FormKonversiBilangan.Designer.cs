namespace XIRPL_2_35
{
    partial class FormKonversiBilangan
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
            lbl_hasil = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Masukkan Bilangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 30);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 1;
            label2.Text = ":";
            label2.Click += label2_Click;
            // 
            // nilai_1
            // 
            nilai_1.Location = new Point(177, 30);
            nilai_1.Name = "nilai_1";
            nilai_1.Size = new Size(173, 23);
            nilai_1.TabIndex = 2;
            // 
            // lbl_hasil
            // 
            lbl_hasil.AutoSize = true;
            lbl_hasil.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_hasil.Location = new Point(117, 68);
            lbl_hasil.Name = "lbl_hasil";
            lbl_hasil.Size = new Size(82, 99);
            lbl_hasil.TabIndex = 3;
            lbl_hasil.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(35, 179);
            button1.Name = "button1";
            button1.Size = new Size(194, 44);
            button1.TabIndex = 4;
            button1.Text = "Desimal Ke Binner";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(35, 250);
            button2.Name = "button2";
            button2.Size = new Size(194, 39);
            button2.TabIndex = 5;
            button2.Text = "Desimal Ke Okta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(35, 316);
            button3.Name = "button3";
            button3.Size = new Size(194, 43);
            button3.TabIndex = 6;
            button3.Text = "Desimal Ke Hexadecimal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(378, 179);
            button4.Name = "button4";
            button4.Size = new Size(171, 44);
            button4.TabIndex = 7;
            button4.Text = "Binner Ke Desimal";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(378, 250);
            button5.Name = "button5";
            button5.Size = new Size(171, 39);
            button5.TabIndex = 8;
            button5.Text = "Binner Ke Oktal";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(378, 316);
            button6.Name = "button6";
            button6.Size = new Size(171, 43);
            button6.TabIndex = 9;
            button6.Text = "Binner Ke Hexadecimal";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // FormKonversiBilangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_hasil);
            Controls.Add(nilai_1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormKonversiBilangan";
            Text = "FormKonversiBilangan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nilai_1;
        private Label lbl_hasil;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}