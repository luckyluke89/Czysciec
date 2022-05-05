namespace Czyściec2
{
    partial class DodawanieNotatki
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
            this.tb_tresc_notatki = new System.Windows.Forms.TextBox();
            this.l_tresc = new System.Windows.Forms.Label();
            this.l_priorytet = new System.Windows.Forms.Label();
            this.tb_klient_notatka = new System.Windows.Forms.TextBox();
            this.lb_klient_notatka = new System.Windows.Forms.ListBox();
            this.l_klient = new System.Windows.Forms.Label();
            this.b_zatwierdz = new System.Windows.Forms.Button();
            this.b_anuluj = new System.Windows.Forms.Button();
            this.nud_priorytet = new System.Windows.Forms.NumericUpDown();
            this.cb_oddzwaniac = new System.Windows.Forms.ComboBox();
            this.l_oddzwaniac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_priorytet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_tresc_notatki
            // 
            this.tb_tresc_notatki.Location = new System.Drawing.Point(15, 176);
            this.tb_tresc_notatki.MaxLength = 99999;
            this.tb_tresc_notatki.Multiline = true;
            this.tb_tresc_notatki.Name = "tb_tresc_notatki";
            this.tb_tresc_notatki.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_tresc_notatki.Size = new System.Drawing.Size(642, 212);
            this.tb_tresc_notatki.TabIndex = 0;
            // 
            // l_tresc
            // 
            this.l_tresc.AutoSize = true;
            this.l_tresc.Location = new System.Drawing.Point(12, 160);
            this.l_tresc.Name = "l_tresc";
            this.l_tresc.Size = new System.Drawing.Size(72, 13);
            this.l_tresc.TabIndex = 1;
            this.l_tresc.Text = "Treść notatki:";
            // 
            // l_priorytet
            // 
            this.l_priorytet.AutoSize = true;
            this.l_priorytet.Location = new System.Drawing.Point(9, 9);
            this.l_priorytet.Name = "l_priorytet";
            this.l_priorytet.Size = new System.Drawing.Size(48, 13);
            this.l_priorytet.TabIndex = 3;
            this.l_priorytet.Text = "Priorytet:";
            // 
            // tb_klient_notatka
            // 
            this.tb_klient_notatka.Location = new System.Drawing.Point(304, 25);
            this.tb_klient_notatka.Name = "tb_klient_notatka";
            this.tb_klient_notatka.Size = new System.Drawing.Size(353, 20);
            this.tb_klient_notatka.TabIndex = 5;
            this.tb_klient_notatka.TextChanged += new System.EventHandler(this.tb_klient_notatka_TextChanged);
            // 
            // lb_klient_notatka
            // 
            this.lb_klient_notatka.FormattingEnabled = true;
            this.lb_klient_notatka.Location = new System.Drawing.Point(304, 51);
            this.lb_klient_notatka.Name = "lb_klient_notatka";
            this.lb_klient_notatka.Size = new System.Drawing.Size(353, 108);
            this.lb_klient_notatka.TabIndex = 6;
            // 
            // l_klient
            // 
            this.l_klient.AutoSize = true;
            this.l_klient.Location = new System.Drawing.Point(301, 9);
            this.l_klient.Name = "l_klient";
            this.l_klient.Size = new System.Drawing.Size(36, 13);
            this.l_klient.TabIndex = 7;
            this.l_klient.Text = "Klient:";
            // 
            // b_zatwierdz
            // 
            this.b_zatwierdz.Location = new System.Drawing.Point(524, 394);
            this.b_zatwierdz.Name = "b_zatwierdz";
            this.b_zatwierdz.Size = new System.Drawing.Size(133, 40);
            this.b_zatwierdz.TabIndex = 9;
            this.b_zatwierdz.Text = "Zatwierdź";
            this.b_zatwierdz.UseVisualStyleBackColor = true;
            this.b_zatwierdz.Click += new System.EventHandler(this.b_zatwierdz_Click);
            // 
            // b_anuluj
            // 
            this.b_anuluj.Location = new System.Drawing.Point(12, 394);
            this.b_anuluj.Name = "b_anuluj";
            this.b_anuluj.Size = new System.Drawing.Size(133, 40);
            this.b_anuluj.TabIndex = 10;
            this.b_anuluj.Text = "Anuluj";
            this.b_anuluj.UseVisualStyleBackColor = true;
            this.b_anuluj.Click += new System.EventHandler(this.b_anuluj_Click);
            // 
            // nud_priorytet
            // 
            this.nud_priorytet.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_priorytet.Location = new System.Drawing.Point(12, 26);
            this.nud_priorytet.Name = "nud_priorytet";
            this.nud_priorytet.Size = new System.Drawing.Size(72, 20);
            this.nud_priorytet.TabIndex = 11;
            // 
            // cb_oddzwaniac
            // 
            this.cb_oddzwaniac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_oddzwaniac.Location = new System.Drawing.Point(12, 67);
            this.cb_oddzwaniac.MaxDropDownItems = 99;
            this.cb_oddzwaniac.Name = "cb_oddzwaniac";
            this.cb_oddzwaniac.Size = new System.Drawing.Size(121, 21);
            this.cb_oddzwaniac.TabIndex = 12;
            // 
            // l_oddzwaniac
            // 
            this.l_oddzwaniac.AutoSize = true;
            this.l_oddzwaniac.Location = new System.Drawing.Point(9, 49);
            this.l_oddzwaniac.Name = "l_oddzwaniac";
            this.l_oddzwaniac.Size = new System.Drawing.Size(87, 13);
            this.l_oddzwaniac.TabIndex = 13;
            this.l_oddzwaniac.Text = "Czy oddzwaniać:";
            // 
            // DodawanieNotatki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 446);
            this.Controls.Add(this.l_oddzwaniac);
            this.Controls.Add(this.cb_oddzwaniac);
            this.Controls.Add(this.nud_priorytet);
            this.Controls.Add(this.b_anuluj);
            this.Controls.Add(this.b_zatwierdz);
            this.Controls.Add(this.l_klient);
            this.Controls.Add(this.lb_klient_notatka);
            this.Controls.Add(this.tb_klient_notatka);
            this.Controls.Add(this.l_priorytet);
            this.Controls.Add(this.l_tresc);
            this.Controls.Add(this.tb_tresc_notatki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DodawanieNotatki";
            this.Text = "Dodawanie Notatki";
            ((System.ComponentModel.ISupportInitialize)(this.nud_priorytet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tresc_notatki;
        private System.Windows.Forms.Label l_tresc;
        private System.Windows.Forms.Label l_priorytet;
        private System.Windows.Forms.TextBox tb_klient_notatka;
        private System.Windows.Forms.ListBox lb_klient_notatka;
        private System.Windows.Forms.Label l_klient;
        private System.Windows.Forms.Button b_zatwierdz;
        private System.Windows.Forms.Button b_anuluj;
        private System.Windows.Forms.NumericUpDown nud_priorytet;
        private System.Windows.Forms.ComboBox cb_oddzwaniac;
        private System.Windows.Forms.Label l_oddzwaniac;
    }
}