namespace Czyściec2
{
    partial class OknoUstawienPolaczenia
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
            this.l_nazwa_serwera = new System.Windows.Forms.Label();
            this.l_nazwa_instancji = new System.Windows.Forms.Label();
            this.l_uzytkownik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nazwa_serwera = new System.Windows.Forms.TextBox();
            this.tb_nazwa_instancji = new System.Windows.Forms.TextBox();
            this.tb_uzytkownik = new System.Windows.Forms.TextBox();
            this.tb_haslo = new System.Windows.Forms.TextBox();
            this.b_polacz = new System.Windows.Forms.Button();
            this.b_wyjscie = new System.Windows.Forms.Button();
            this.tb_nazwa_bazy = new System.Windows.Forms.TextBox();
            this.l_nazwa_bazy = new System.Windows.Forms.Label();
            this.b_stworz_baze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_nazwa_serwera
            // 
            this.l_nazwa_serwera.AutoSize = true;
            this.l_nazwa_serwera.Location = new System.Drawing.Point(12, 15);
            this.l_nazwa_serwera.Name = "l_nazwa_serwera";
            this.l_nazwa_serwera.Size = new System.Drawing.Size(83, 13);
            this.l_nazwa_serwera.TabIndex = 0;
            this.l_nazwa_serwera.Text = "Nazwa serwera:";
            // 
            // l_nazwa_instancji
            // 
            this.l_nazwa_instancji.AutoSize = true;
            this.l_nazwa_instancji.Location = new System.Drawing.Point(12, 41);
            this.l_nazwa_instancji.Name = "l_nazwa_instancji";
            this.l_nazwa_instancji.Size = new System.Drawing.Size(85, 13);
            this.l_nazwa_instancji.TabIndex = 1;
            this.l_nazwa_instancji.Text = "Nazwa Instancji:";
            // 
            // l_uzytkownik
            // 
            this.l_uzytkownik.AutoSize = true;
            this.l_uzytkownik.Location = new System.Drawing.Point(12, 93);
            this.l_uzytkownik.Name = "l_uzytkownik";
            this.l_uzytkownik.Size = new System.Drawing.Size(105, 13);
            this.l_uzytkownik.TabIndex = 3;
            this.l_uzytkownik.Text = "Nazwa użytkownika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasło:";
            // 
            // tb_nazwa_serwera
            // 
            this.tb_nazwa_serwera.Location = new System.Drawing.Point(188, 12);
            this.tb_nazwa_serwera.Name = "tb_nazwa_serwera";
            this.tb_nazwa_serwera.Size = new System.Drawing.Size(190, 20);
            this.tb_nazwa_serwera.TabIndex = 5;
            // 
            // tb_nazwa_instancji
            // 
            this.tb_nazwa_instancji.Location = new System.Drawing.Point(188, 38);
            this.tb_nazwa_instancji.Name = "tb_nazwa_instancji";
            this.tb_nazwa_instancji.Size = new System.Drawing.Size(190, 20);
            this.tb_nazwa_instancji.TabIndex = 6;
            // 
            // tb_uzytkownik
            // 
            this.tb_uzytkownik.Location = new System.Drawing.Point(188, 90);
            this.tb_uzytkownik.Name = "tb_uzytkownik";
            this.tb_uzytkownik.Size = new System.Drawing.Size(190, 20);
            this.tb_uzytkownik.TabIndex = 8;
            // 
            // tb_haslo
            // 
            this.tb_haslo.Location = new System.Drawing.Point(188, 116);
            this.tb_haslo.Name = "tb_haslo";
            this.tb_haslo.PasswordChar = '*';
            this.tb_haslo.Size = new System.Drawing.Size(190, 20);
            this.tb_haslo.TabIndex = 9;
            // 
            // b_polacz
            // 
            this.b_polacz.Location = new System.Drawing.Point(235, 177);
            this.b_polacz.Name = "b_polacz";
            this.b_polacz.Size = new System.Drawing.Size(143, 31);
            this.b_polacz.TabIndex = 10;
            this.b_polacz.Text = "Połącz";
            this.b_polacz.UseVisualStyleBackColor = true;
            this.b_polacz.Click += new System.EventHandler(this.b_polacz_Click);
            // 
            // b_wyjscie
            // 
            this.b_wyjscie.Location = new System.Drawing.Point(12, 177);
            this.b_wyjscie.Name = "b_wyjscie";
            this.b_wyjscie.Size = new System.Drawing.Size(143, 31);
            this.b_wyjscie.TabIndex = 11;
            this.b_wyjscie.Text = "Anuluj";
            this.b_wyjscie.UseVisualStyleBackColor = true;
            this.b_wyjscie.Click += new System.EventHandler(this.b_wyjscie_Click);
            // 
            // tb_nazwa_bazy
            // 
            this.tb_nazwa_bazy.Location = new System.Drawing.Point(188, 64);
            this.tb_nazwa_bazy.Name = "tb_nazwa_bazy";
            this.tb_nazwa_bazy.Size = new System.Drawing.Size(190, 20);
            this.tb_nazwa_bazy.TabIndex = 7;
            // 
            // l_nazwa_bazy
            // 
            this.l_nazwa_bazy.AutoSize = true;
            this.l_nazwa_bazy.Location = new System.Drawing.Point(12, 67);
            this.l_nazwa_bazy.Name = "l_nazwa_bazy";
            this.l_nazwa_bazy.Size = new System.Drawing.Size(68, 13);
            this.l_nazwa_bazy.TabIndex = 2;
            this.l_nazwa_bazy.Text = "Nazwa bazy:";
            // 
            // b_stworz_baze
            // 
            this.b_stworz_baze.Location = new System.Drawing.Point(15, 135);
            this.b_stworz_baze.Name = "b_stworz_baze";
            this.b_stworz_baze.Size = new System.Drawing.Size(110, 24);
            this.b_stworz_baze.TabIndex = 12;
            this.b_stworz_baze.Text = "Stwórz bazę";
            this.b_stworz_baze.UseVisualStyleBackColor = true;
            this.b_stworz_baze.Click += new System.EventHandler(this.b_stworz_baze_Click);
            // 
            // OknoUstawienPolaczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 220);
            this.Controls.Add(this.b_stworz_baze);
            this.Controls.Add(this.tb_nazwa_bazy);
            this.Controls.Add(this.l_nazwa_bazy);
            this.Controls.Add(this.b_wyjscie);
            this.Controls.Add(this.b_polacz);
            this.Controls.Add(this.tb_haslo);
            this.Controls.Add(this.tb_uzytkownik);
            this.Controls.Add(this.tb_nazwa_instancji);
            this.Controls.Add(this.tb_nazwa_serwera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_uzytkownik);
            this.Controls.Add(this.l_nazwa_instancji);
            this.Controls.Add(this.l_nazwa_serwera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OknoUstawienPolaczenia";
            this.Text = "Ustawienia połączenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nazwa_serwera;
        private System.Windows.Forms.Label l_nazwa_instancji;
        private System.Windows.Forms.Label l_uzytkownik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nazwa_serwera;
        private System.Windows.Forms.TextBox tb_nazwa_instancji;
        private System.Windows.Forms.TextBox tb_uzytkownik;
        private System.Windows.Forms.TextBox tb_haslo;
        private System.Windows.Forms.Button b_polacz;
        private System.Windows.Forms.Button b_wyjscie;
        private System.Windows.Forms.TextBox tb_nazwa_bazy;
        private System.Windows.Forms.Label l_nazwa_bazy;
        private System.Windows.Forms.Button b_stworz_baze;
    }
}