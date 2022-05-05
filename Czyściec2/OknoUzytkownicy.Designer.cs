namespace Czyściec2
{
    partial class OknoUzytkownicy
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
            this.dgv_uzytkownicy = new System.Windows.Forms.DataGridView();
            this.gb_uzytkownicy = new System.Windows.Forms.GroupBox();
            this.nud_poziom = new System.Windows.Forms.NumericUpDown();
            this.l_poziom = new System.Windows.Forms.Label();
            this.b_usun = new System.Windows.Forms.Button();
            this.b_edytuj = new System.Windows.Forms.Button();
            this.b_wyjscie = new System.Windows.Forms.Button();
            this.b_dodaj = new System.Windows.Forms.Button();
            this.tb_nazwisko = new System.Windows.Forms.TextBox();
            this.l_nazwisko = new System.Windows.Forms.Label();
            this.tb_imie = new System.Windows.Forms.TextBox();
            this.l_imie = new System.Windows.Forms.Label();
            this.b_zatwierdz = new System.Windows.Forms.Button();
            this.b_anuluj = new System.Windows.Forms.Button();
            this.b_zmianaHasla = new System.Windows.Forms.Button();
            this.tb_nick = new System.Windows.Forms.TextBox();
            this.l_nick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uzytkownicy)).BeginInit();
            this.gb_uzytkownicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poziom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_uzytkownicy
            // 
            this.dgv_uzytkownicy.AllowUserToAddRows = false;
            this.dgv_uzytkownicy.AllowUserToDeleteRows = false;
            this.dgv_uzytkownicy.AllowUserToResizeRows = false;
            this.dgv_uzytkownicy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_uzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_uzytkownicy.Location = new System.Drawing.Point(12, 12);
            this.dgv_uzytkownicy.MultiSelect = false;
            this.dgv_uzytkownicy.Name = "dgv_uzytkownicy";
            this.dgv_uzytkownicy.ReadOnly = true;
            this.dgv_uzytkownicy.RowHeadersVisible = false;
            this.dgv_uzytkownicy.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_uzytkownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_uzytkownicy.Size = new System.Drawing.Size(361, 617);
            this.dgv_uzytkownicy.TabIndex = 0;
            this.dgv_uzytkownicy.SelectionChanged += new System.EventHandler(this.dgv_uzytkownicy_CellMouseClick);
            // 
            // gb_uzytkownicy
            // 
            this.gb_uzytkownicy.Controls.Add(this.nud_poziom);
            this.gb_uzytkownicy.Controls.Add(this.l_poziom);
            this.gb_uzytkownicy.Controls.Add(this.b_usun);
            this.gb_uzytkownicy.Controls.Add(this.b_edytuj);
            this.gb_uzytkownicy.Controls.Add(this.b_wyjscie);
            this.gb_uzytkownicy.Controls.Add(this.b_dodaj);
            this.gb_uzytkownicy.Controls.Add(this.tb_nazwisko);
            this.gb_uzytkownicy.Controls.Add(this.l_nazwisko);
            this.gb_uzytkownicy.Controls.Add(this.tb_imie);
            this.gb_uzytkownicy.Controls.Add(this.l_imie);
            this.gb_uzytkownicy.Controls.Add(this.b_zatwierdz);
            this.gb_uzytkownicy.Controls.Add(this.b_anuluj);
            this.gb_uzytkownicy.Controls.Add(this.b_zmianaHasla);
            this.gb_uzytkownicy.Controls.Add(this.tb_nick);
            this.gb_uzytkownicy.Controls.Add(this.l_nick);
            this.gb_uzytkownicy.Location = new System.Drawing.Point(379, 12);
            this.gb_uzytkownicy.Name = "gb_uzytkownicy";
            this.gb_uzytkownicy.Size = new System.Drawing.Size(432, 617);
            this.gb_uzytkownicy.TabIndex = 1;
            this.gb_uzytkownicy.TabStop = false;
            // 
            // nud_poziom
            // 
            this.nud_poziom.Enabled = false;
            this.nud_poziom.Location = new System.Drawing.Point(373, 121);
            this.nud_poziom.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_poziom.Name = "nud_poziom";
            this.nud_poziom.Size = new System.Drawing.Size(44, 20);
            this.nud_poziom.TabIndex = 17;
            // 
            // l_poziom
            // 
            this.l_poziom.AutoSize = true;
            this.l_poziom.Location = new System.Drawing.Point(323, 123);
            this.l_poziom.Name = "l_poziom";
            this.l_poziom.Size = new System.Drawing.Size(44, 13);
            this.l_poziom.TabIndex = 15;
            this.l_poziom.Text = "Poziom:";
            // 
            // b_usun
            // 
            this.b_usun.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_usun.Location = new System.Drawing.Point(81, 19);
            this.b_usun.Name = "b_usun";
            this.b_usun.Size = new System.Drawing.Size(30, 30);
            this.b_usun.TabIndex = 14;
            this.b_usun.Text = "-";
            this.b_usun.UseVisualStyleBackColor = true;
            this.b_usun.Click += new System.EventHandler(this.b_usun_Click);
            // 
            // b_edytuj
            // 
            this.b_edytuj.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_edytuj.Location = new System.Drawing.Point(45, 19);
            this.b_edytuj.Name = "b_edytuj";
            this.b_edytuj.Size = new System.Drawing.Size(30, 30);
            this.b_edytuj.TabIndex = 11;
            this.b_edytuj.Text = "I";
            this.b_edytuj.UseVisualStyleBackColor = true;
            this.b_edytuj.Click += new System.EventHandler(this.b_edytuj_Click);
            // 
            // b_wyjscie
            // 
            this.b_wyjscie.Location = new System.Drawing.Point(306, 590);
            this.b_wyjscie.Name = "b_wyjscie";
            this.b_wyjscie.Size = new System.Drawing.Size(111, 21);
            this.b_wyjscie.TabIndex = 12;
            this.b_wyjscie.Text = "Wyjście";
            this.b_wyjscie.UseVisualStyleBackColor = true;
            this.b_wyjscie.Click += new System.EventHandler(this.b_wyjscie_Click);
            // 
            // b_dodaj
            // 
            this.b_dodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_dodaj.Location = new System.Drawing.Point(9, 19);
            this.b_dodaj.Name = "b_dodaj";
            this.b_dodaj.Size = new System.Drawing.Size(30, 30);
            this.b_dodaj.TabIndex = 13;
            this.b_dodaj.Text = "+";
            this.b_dodaj.UseVisualStyleBackColor = true;
            this.b_dodaj.Click += new System.EventHandler(this.b_dodaj_Click);
            // 
            // tb_nazwisko
            // 
            this.tb_nazwisko.Enabled = false;
            this.tb_nazwisko.Location = new System.Drawing.Point(275, 94);
            this.tb_nazwisko.Name = "tb_nazwisko";
            this.tb_nazwisko.Size = new System.Drawing.Size(142, 20);
            this.tb_nazwisko.TabIndex = 10;
            // 
            // l_nazwisko
            // 
            this.l_nazwisko.AutoSize = true;
            this.l_nazwisko.Location = new System.Drawing.Point(213, 97);
            this.l_nazwisko.Name = "l_nazwisko";
            this.l_nazwisko.Size = new System.Drawing.Size(56, 13);
            this.l_nazwisko.TabIndex = 9;
            this.l_nazwisko.Text = "Nazwisko:";
            // 
            // tb_imie
            // 
            this.tb_imie.Enabled = false;
            this.tb_imie.Location = new System.Drawing.Point(47, 94);
            this.tb_imie.Name = "tb_imie";
            this.tb_imie.Size = new System.Drawing.Size(160, 20);
            this.tb_imie.TabIndex = 8;
            // 
            // l_imie
            // 
            this.l_imie.AutoSize = true;
            this.l_imie.Location = new System.Drawing.Point(6, 97);
            this.l_imie.Name = "l_imie";
            this.l_imie.Size = new System.Drawing.Size(29, 13);
            this.l_imie.TabIndex = 7;
            this.l_imie.Text = "Imię:";
            // 
            // b_zatwierdz
            // 
            this.b_zatwierdz.Enabled = false;
            this.b_zatwierdz.Location = new System.Drawing.Point(352, 161);
            this.b_zatwierdz.Name = "b_zatwierdz";
            this.b_zatwierdz.Size = new System.Drawing.Size(65, 21);
            this.b_zatwierdz.TabIndex = 6;
            this.b_zatwierdz.Text = "Zatwierdź";
            this.b_zatwierdz.UseVisualStyleBackColor = true;
            this.b_zatwierdz.Click += new System.EventHandler(this.b_zatwierdz_Click);
            // 
            // b_anuluj
            // 
            this.b_anuluj.Enabled = false;
            this.b_anuluj.Location = new System.Drawing.Point(281, 161);
            this.b_anuluj.Name = "b_anuluj";
            this.b_anuluj.Size = new System.Drawing.Size(65, 21);
            this.b_anuluj.TabIndex = 5;
            this.b_anuluj.Text = "Anuluj";
            this.b_anuluj.UseVisualStyleBackColor = true;
            this.b_anuluj.Click += new System.EventHandler(this.b_anuluj_Click);
            // 
            // b_zmianaHasla
            // 
            this.b_zmianaHasla.Location = new System.Drawing.Point(241, 67);
            this.b_zmianaHasla.Name = "b_zmianaHasla";
            this.b_zmianaHasla.Size = new System.Drawing.Size(176, 21);
            this.b_zmianaHasla.TabIndex = 4;
            this.b_zmianaHasla.Text = "Zmień hasło";
            this.b_zmianaHasla.UseVisualStyleBackColor = true;
            this.b_zmianaHasla.Click += new System.EventHandler(this.b_zmianaHasla_Click);
            // 
            // tb_nick
            // 
            this.tb_nick.Enabled = false;
            this.tb_nick.Location = new System.Drawing.Point(47, 68);
            this.tb_nick.Name = "tb_nick";
            this.tb_nick.Size = new System.Drawing.Size(136, 20);
            this.tb_nick.TabIndex = 3;
            // 
            // l_nick
            // 
            this.l_nick.AutoSize = true;
            this.l_nick.Location = new System.Drawing.Point(6, 71);
            this.l_nick.Name = "l_nick";
            this.l_nick.Size = new System.Drawing.Size(32, 13);
            this.l_nick.TabIndex = 2;
            this.l_nick.Text = "Nick:";
            // 
            // OknoUzytkownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 641);
            this.Controls.Add(this.gb_uzytkownicy);
            this.Controls.Add(this.dgv_uzytkownicy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OknoUzytkownicy";
            this.Text = "Użytkownicy";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uzytkownicy)).EndInit();
            this.gb_uzytkownicy.ResumeLayout(false);
            this.gb_uzytkownicy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poziom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_uzytkownicy;
        private System.Windows.Forms.GroupBox gb_uzytkownicy;
        private System.Windows.Forms.Button b_edytuj;
        private System.Windows.Forms.TextBox tb_nazwisko;
        private System.Windows.Forms.Label l_nazwisko;
        private System.Windows.Forms.TextBox tb_imie;
        private System.Windows.Forms.Label l_imie;
        private System.Windows.Forms.Button b_zatwierdz;
        private System.Windows.Forms.Button b_anuluj;
        private System.Windows.Forms.Button b_zmianaHasla;
        private System.Windows.Forms.TextBox tb_nick;
        private System.Windows.Forms.Label l_nick;
        private System.Windows.Forms.Button b_wyjscie;
        private System.Windows.Forms.Button b_dodaj;
        private System.Windows.Forms.Button b_usun;
        private System.Windows.Forms.Label l_poziom;
        private System.Windows.Forms.NumericUpDown nud_poziom;
    }
}