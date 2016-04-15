namespace zadanie
{
    partial class Magic
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
            this.tabBox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imie_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nazwisko_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.adres_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numer_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wyswietl_btn = new System.Windows.Forms.Button();
            this.dalej_btn = new System.Windows.Forms.Button();
            this.wstecz_btn = new System.Windows.Forms.Button();
            this.tabBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBox
            // 
            this.tabBox.Controls.Add(this.tabPage1);
            this.tabBox.Controls.Add(this.tabPage2);
            this.tabBox.Controls.Add(this.tabPage3);
            this.tabBox.Controls.Add(this.tabPage4);
            this.tabBox.Location = new System.Drawing.Point(12, 12);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(357, 168);
            this.tabBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.imie_txt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(349, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Imię";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imie_txt
            // 
            this.imie_txt.Location = new System.Drawing.Point(26, 30);
            this.imie_txt.Name = "imie_txt";
            this.imie_txt.Size = new System.Drawing.Size(299, 20);
            this.imie_txt.TabIndex = 4;
            this.imie_txt.Leave += new System.EventHandler(this.zapisz_imie);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wprowadź imię";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nazwisko_txt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(349, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nazwisko";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nazwisko_txt
            // 
            this.nazwisko_txt.Location = new System.Drawing.Point(26, 30);
            this.nazwisko_txt.Name = "nazwisko_txt";
            this.nazwisko_txt.Size = new System.Drawing.Size(299, 20);
            this.nazwisko_txt.TabIndex = 4;
            this.nazwisko_txt.Leave += new System.EventHandler(this.zapisz_nazwisko);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wprowadź nazwisko";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.adres_txt);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(349, 142);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adres zamieszkania";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // adres_txt
            // 
            this.adres_txt.Location = new System.Drawing.Point(26, 30);
            this.adres_txt.Multiline = true;
            this.adres_txt.Name = "adres_txt";
            this.adres_txt.Size = new System.Drawing.Size(299, 92);
            this.adres_txt.TabIndex = 4;
            this.adres_txt.Leave += new System.EventHandler(this.zapisz_adres);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wprowadź adres zamieszkania";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.numer_txt);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(349, 142);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Numer telefonu";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numer_txt
            // 
            this.numer_txt.Location = new System.Drawing.Point(26, 30);
            this.numer_txt.Name = "numer_txt";
            this.numer_txt.Size = new System.Drawing.Size(299, 20);
            this.numer_txt.TabIndex = 4;
            this.numer_txt.Leave += new System.EventHandler(this.zapisz_numer);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wprowadź numer telefonu";
            // 
            // wyswietl_btn
            // 
            this.wyswietl_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.wyswietl_btn.Location = new System.Drawing.Point(375, 34);
            this.wyswietl_btn.Name = "wyswietl_btn";
            this.wyswietl_btn.Size = new System.Drawing.Size(89, 175);
            this.wyswietl_btn.TabIndex = 1;
            this.wyswietl_btn.Text = "Wyświetl dane";
            this.wyswietl_btn.UseVisualStyleBackColor = false;
            this.wyswietl_btn.Click += new System.EventHandler(this.wyswietl);
            // 
            // dalej_btn
            // 
            this.dalej_btn.Location = new System.Drawing.Point(197, 186);
            this.dalej_btn.Name = "dalej_btn";
            this.dalej_btn.Size = new System.Drawing.Size(168, 23);
            this.dalej_btn.TabIndex = 2;
            this.dalej_btn.Text = "dalej";
            this.dalej_btn.UseVisualStyleBackColor = true;
            this.dalej_btn.Click += new System.EventHandler(this.dalej);
            // 
            // wstecz_btn
            // 
            this.wstecz_btn.Location = new System.Drawing.Point(12, 186);
            this.wstecz_btn.Name = "wstecz_btn";
            this.wstecz_btn.Size = new System.Drawing.Size(168, 23);
            this.wstecz_btn.TabIndex = 3;
            this.wstecz_btn.Text = "wstecz";
            this.wstecz_btn.UseVisualStyleBackColor = true;
            this.wstecz_btn.Click += new System.EventHandler(this.wstecz);
            // 
            // Magic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 223);
            this.Controls.Add(this.wstecz_btn);
            this.Controls.Add(this.dalej_btn);
            this.Controls.Add(this.wyswietl_btn);
            this.Controls.Add(this.tabBox);
            this.Name = "Magic";
            this.Text = "Magic";
            this.tabBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox imie_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazwisko_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox adres_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox numer_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wyswietl_btn;
        private System.Windows.Forms.Button dalej_btn;
        private System.Windows.Forms.Button wstecz_btn;
    }
}

