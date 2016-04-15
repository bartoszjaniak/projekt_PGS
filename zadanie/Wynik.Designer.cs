namespace zadanie
{
    partial class Wynik
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
            this.label1 = new System.Windows.Forms.Label();
            this.imie_txt = new System.Windows.Forms.Label();
            this.nazwisko_txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adres_txt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numer_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // imie_txt
            // 
            this.imie_txt.AutoSize = true;
            this.imie_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie_txt.Location = new System.Drawing.Point(136, 30);
            this.imie_txt.Name = "imie_txt";
            this.imie_txt.Size = new System.Drawing.Size(32, 16);
            this.imie_txt.TabIndex = 1;
            this.imie_txt.Text = "null";
            // 
            // nazwisko_txt
            // 
            this.nazwisko_txt.AutoSize = true;
            this.nazwisko_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwisko_txt.Location = new System.Drawing.Point(136, 55);
            this.nazwisko_txt.Name = "nazwisko_txt";
            this.nazwisko_txt.Size = new System.Drawing.Size(32, 16);
            this.nazwisko_txt.TabIndex = 3;
            this.nazwisko_txt.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nazwisko";
            // 
            // adres_txt
            // 
            this.adres_txt.AutoSize = true;
            this.adres_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adres_txt.Location = new System.Drawing.Point(136, 85);
            this.adres_txt.Name = "adres_txt";
            this.adres_txt.Size = new System.Drawing.Size(32, 16);
            this.adres_txt.TabIndex = 5;
            this.adres_txt.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adres zamieszkania";
            // 
            // numer_txt
            // 
            this.numer_txt.AutoSize = true;
            this.numer_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numer_txt.Location = new System.Drawing.Point(136, 170);
            this.numer_txt.Name = "numer_txt";
            this.numer_txt.Size = new System.Drawing.Size(32, 16);
            this.numer_txt.TabIndex = 7;
            this.numer_txt.Text = "null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Numer telefonu";
            // 
            // Wynik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 202);
            this.Controls.Add(this.numer_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adres_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nazwisko_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imie_txt);
            this.Controls.Add(this.label1);
            this.Name = "Wynik";
            this.Text = "Twoje dane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imie_txt;
        private System.Windows.Forms.Label nazwisko_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label adres_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numer_txt;
        private System.Windows.Forms.Label label8;
    }
}