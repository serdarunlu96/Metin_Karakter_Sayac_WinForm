namespace Metin_Karakter_Sayac_WinForm
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
            txtMetin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblToplamKarakterSayisi = new Label();
            label3 = new Label();
            label4 = new Label();
            lblKelimeSayisi = new Label();
            label5 = new Label();
            lblEnUzun = new Label();
            SuspendLayout();
            // 
            // txtMetin
            // 
            txtMetin.Location = new Point(30, 60);
            txtMetin.Multiline = true;
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(356, 289);
            txtMetin.TabIndex = 0;
            txtMetin.TextChanged += txtMetin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Metin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 364);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 2;
            label2.Text = "Toplam Karakter Sayısı:";
            // 
            // lblToplamKarakterSayisi
            // 
            lblToplamKarakterSayisi.AutoSize = true;
            lblToplamKarakterSayisi.Location = new Point(163, 364);
            lblToplamKarakterSayisi.Name = "lblToplamKarakterSayisi";
            lblToplamKarakterSayisi.Size = new Size(0, 15);
            lblToplamKarakterSayisi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 395);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 389);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 6;
            label4.Text = "Toplam Kelime Sayısı:";
            // 
            // lblKelimeSayisi
            // 
            lblKelimeSayisi.AutoSize = true;
            lblKelimeSayisi.Location = new Point(163, 389);
            lblKelimeSayisi.Name = "lblKelimeSayisi";
            lblKelimeSayisi.Size = new Size(0, 15);
            lblKelimeSayisi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 416);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 8;
            label5.Text = "En Uzun Kelime:";
            // 
            // lblEnUzun
            // 
            lblEnUzun.AutoSize = true;
            lblEnUzun.Location = new Point(163, 416);
            lblEnUzun.Name = "lblEnUzun";
            lblEnUzun.Size = new Size(0, 15);
            lblEnUzun.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 450);
            Controls.Add(lblEnUzun);
            Controls.Add(label5);
            Controls.Add(lblKelimeSayisi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblToplamKarakterSayisi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMetin);
            Name = "Form1";
            Text = "Metin Karakter Sayaci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMetin;
        private Label label1;
        private Label label2;
        private Label lblToplamKarakterSayisi;
        private Label label3;
        private Label label4;
        private Label lblKelimeSayisi;
        private Label label5;
        private Label lblEnUzun;
    }
}