namespace Czyściec2
{
    partial class DodawanieWpisu
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
            this.b_zatwierdz_wpis = new System.Windows.Forms.Button();
            this.b_anuluj_wpis = new System.Windows.Forms.Button();
            this.tb_tresc = new System.Windows.Forms.TextBox();
            this.l_tresc_wpisu = new System.Windows.Forms.Label();
            this.cb_typ_zgloszenia = new System.Windows.Forms.ComboBox();
            this.l_typ_zgloszenia = new System.Windows.Forms.Label();
            this.cb_stan = new System.Windows.Forms.ComboBox();
            this.l_stan = new System.Windows.Forms.Label();
            this.nud_priorytet_wpisu = new System.Windows.Forms.NumericUpDown();
            this.l_priorytet_wpisu = new System.Windows.Forms.Label();
            this.tb_funkcjonalnosc = new System.Windows.Forms.TextBox();
            this.l_funkcjonalnosc = new System.Windows.Forms.Label();
            this.lb_funkcjonalnosc = new System.Windows.Forms.ListBox();
            this.l_kiedy_wyzej = new System.Windows.Forms.Label();
            this.l_program = new System.Windows.Forms.Label();
            this.cb_program = new System.Windows.Forms.ComboBox();
            this.l_typ_funkcjonalnosci = new System.Windows.Forms.Label();
            this.cb_typ_funkcjonalnosci = new System.Windows.Forms.ComboBox();
            this.dtp_kiedy_wyzej = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nud_priorytet_wpisu)).BeginInit();
            this.SuspendLayout();
            // 
            // b_zatwierdz_wpis
            // 
            this.b_zatwierdz_wpis.Location = new System.Drawing.Point(803, 389);
            this.b_zatwierdz_wpis.Name = "b_zatwierdz_wpis";
            this.b_zatwierdz_wpis.Size = new System.Drawing.Size(150, 42);
            this.b_zatwierdz_wpis.TabIndex = 0;
            this.b_zatwierdz_wpis.Text = "Zatwierdź";
            this.b_zatwierdz_wpis.UseVisualStyleBackColor = true;
            this.b_zatwierdz_wpis.Click += new System.EventHandler(this.b_zatwierdz_wpis_Click);
            // 
            // b_anuluj_wpis
            // 
            this.b_anuluj_wpis.Location = new System.Drawing.Point(12, 389);
            this.b_anuluj_wpis.Name = "b_anuluj_wpis";
            this.b_anuluj_wpis.Size = new System.Drawing.Size(150, 42);
            this.b_anuluj_wpis.TabIndex = 1;
            this.b_anuluj_wpis.Text = "Anuluj";
            this.b_anuluj_wpis.UseVisualStyleBackColor = true;
            this.b_anuluj_wpis.Click += new System.EventHandler(this.b_anuluj_wpis_Click);
            // 
            // tb_tresc
            // 
            this.tb_tresc.Location = new System.Drawing.Point(12, 241);
            this.tb_tresc.Multiline = true;
            this.tb_tresc.Name = "tb_tresc";
            this.tb_tresc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_tresc.Size = new System.Drawing.Size(941, 142);
            this.tb_tresc.TabIndex = 2;
            // 
            // l_tresc_wpisu
            // 
            this.l_tresc_wpisu.AutoSize = true;
            this.l_tresc_wpisu.Location = new System.Drawing.Point(12, 225);
            this.l_tresc_wpisu.Name = "l_tresc_wpisu";
            this.l_tresc_wpisu.Size = new System.Drawing.Size(37, 13);
            this.l_tresc_wpisu.TabIndex = 3;
            this.l_tresc_wpisu.Text = "Treść:";
            // 
            // cb_typ_zgloszenia
            // 
            this.cb_typ_zgloszenia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typ_zgloszenia.FormattingEnabled = true;
            this.cb_typ_zgloszenia.Location = new System.Drawing.Point(232, 12);
            this.cb_typ_zgloszenia.MaxDropDownItems = 99;
            this.cb_typ_zgloszenia.Name = "cb_typ_zgloszenia";
            this.cb_typ_zgloszenia.Size = new System.Drawing.Size(149, 21);
            this.cb_typ_zgloszenia.TabIndex = 4;
            // 
            // l_typ_zgloszenia
            // 
            this.l_typ_zgloszenia.AutoSize = true;
            this.l_typ_zgloszenia.Location = new System.Drawing.Point(144, 15);
            this.l_typ_zgloszenia.Name = "l_typ_zgloszenia";
            this.l_typ_zgloszenia.Size = new System.Drawing.Size(82, 13);
            this.l_typ_zgloszenia.TabIndex = 5;
            this.l_typ_zgloszenia.Text = "Typ zgłoszenia:";
            // 
            // cb_stan
            // 
            this.cb_stan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_stan.FormattingEnabled = true;
            this.cb_stan.Location = new System.Drawing.Point(435, 15);
            this.cb_stan.MaxDropDownItems = 99;
            this.cb_stan.Name = "cb_stan";
            this.cb_stan.Size = new System.Drawing.Size(149, 21);
            this.cb_stan.TabIndex = 6;
            // 
            // l_stan
            // 
            this.l_stan.AutoSize = true;
            this.l_stan.Location = new System.Drawing.Point(394, 18);
            this.l_stan.Name = "l_stan";
            this.l_stan.Size = new System.Drawing.Size(32, 13);
            this.l_stan.TabIndex = 7;
            this.l_stan.Text = "Stan:";
            // 
            // nud_priorytet_wpisu
            // 
            this.nud_priorytet_wpisu.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_priorytet_wpisu.Location = new System.Drawing.Point(64, 13);
            this.nud_priorytet_wpisu.Name = "nud_priorytet_wpisu";
            this.nud_priorytet_wpisu.Size = new System.Drawing.Size(48, 20);
            this.nud_priorytet_wpisu.TabIndex = 8;
            // 
            // l_priorytet_wpisu
            // 
            this.l_priorytet_wpisu.AutoSize = true;
            this.l_priorytet_wpisu.Location = new System.Drawing.Point(12, 15);
            this.l_priorytet_wpisu.Name = "l_priorytet_wpisu";
            this.l_priorytet_wpisu.Size = new System.Drawing.Size(48, 13);
            this.l_priorytet_wpisu.TabIndex = 9;
            this.l_priorytet_wpisu.Text = "Priorytet:";
            // 
            // tb_funkcjonalnosc
            // 
            this.tb_funkcjonalnosc.Location = new System.Drawing.Point(757, 15);
            this.tb_funkcjonalnosc.Name = "tb_funkcjonalnosc";
            this.tb_funkcjonalnosc.Size = new System.Drawing.Size(196, 20);
            this.tb_funkcjonalnosc.TabIndex = 10;
            this.tb_funkcjonalnosc.TextChanged += new System.EventHandler(this.tb_funkcjonalnosc_TextChanged);
            // 
            // l_funkcjonalnosc
            // 
            this.l_funkcjonalnosc.AutoSize = true;
            this.l_funkcjonalnosc.Location = new System.Drawing.Point(666, 18);
            this.l_funkcjonalnosc.Name = "l_funkcjonalnosc";
            this.l_funkcjonalnosc.Size = new System.Drawing.Size(85, 13);
            this.l_funkcjonalnosc.TabIndex = 11;
            this.l_funkcjonalnosc.Text = "Funkcjonalność:";
            // 
            // lb_funkcjonalnosc
            // 
            this.lb_funkcjonalnosc.FormattingEnabled = true;
            this.lb_funkcjonalnosc.Location = new System.Drawing.Point(757, 41);
            this.lb_funkcjonalnosc.Name = "lb_funkcjonalnosc";
            this.lb_funkcjonalnosc.Size = new System.Drawing.Size(196, 121);
            this.lb_funkcjonalnosc.TabIndex = 12;
            // 
            // l_kiedy_wyzej
            // 
            this.l_kiedy_wyzej.AutoSize = true;
            this.l_kiedy_wyzej.Location = new System.Drawing.Point(146, 62);
            this.l_kiedy_wyzej.Name = "l_kiedy_wyzej";
            this.l_kiedy_wyzej.Size = new System.Drawing.Size(147, 13);
            this.l_kiedy_wyzej.TabIndex = 14;
            this.l_kiedy_wyzej.Text = "Czy i kiedy przekazano wyżej:";
            // 
            // l_program
            // 
            this.l_program.AutoSize = true;
            this.l_program.Location = new System.Drawing.Point(547, 99);
            this.l_program.Name = "l_program";
            this.l_program.Size = new System.Drawing.Size(49, 13);
            this.l_program.TabIndex = 16;
            this.l_program.Text = "Program:";
            // 
            // cb_program
            // 
            this.cb_program.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_program.FormattingEnabled = true;
            this.cb_program.Location = new System.Drawing.Point(602, 96);
            this.cb_program.MaxDropDownItems = 99;
            this.cb_program.Name = "cb_program";
            this.cb_program.Size = new System.Drawing.Size(149, 21);
            this.cb_program.TabIndex = 15;
            this.cb_program.SelectedIndexChanged += new System.EventHandler(this.cb_program_SelectedIndexChanged);
            // 
            // l_typ_funkcjonalnosci
            // 
            this.l_typ_funkcjonalnosci.AutoSize = true;
            this.l_typ_funkcjonalnosci.Location = new System.Drawing.Point(491, 72);
            this.l_typ_funkcjonalnosci.Name = "l_typ_funkcjonalnosci";
            this.l_typ_funkcjonalnosci.Size = new System.Drawing.Size(105, 13);
            this.l_typ_funkcjonalnosci.TabIndex = 18;
            this.l_typ_funkcjonalnosci.Text = "Typ funkcjonalności:";
            // 
            // cb_typ_funkcjonalnosci
            // 
            this.cb_typ_funkcjonalnosci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typ_funkcjonalnosci.FormattingEnabled = true;
            this.cb_typ_funkcjonalnosci.Location = new System.Drawing.Point(602, 69);
            this.cb_typ_funkcjonalnosci.MaxDropDownItems = 99;
            this.cb_typ_funkcjonalnosci.Name = "cb_typ_funkcjonalnosci";
            this.cb_typ_funkcjonalnosci.Size = new System.Drawing.Size(149, 21);
            this.cb_typ_funkcjonalnosci.TabIndex = 17;
            this.cb_typ_funkcjonalnosci.SelectedIndexChanged += new System.EventHandler(this.cb_typ_funkcjonalnosci_SelectedIndexChanged);
            // 
            // dtp_kiedy_wyzej
            // 
            this.dtp_kiedy_wyzej.Checked = false;
            this.dtp_kiedy_wyzej.CustomFormat = "yyyy-MM-dd";
            this.dtp_kiedy_wyzej.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_kiedy_wyzej.Location = new System.Drawing.Point(299, 56);
            this.dtp_kiedy_wyzej.Name = "dtp_kiedy_wyzej";
            this.dtp_kiedy_wyzej.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_kiedy_wyzej.ShowCheckBox = true;
            this.dtp_kiedy_wyzej.Size = new System.Drawing.Size(112, 20);
            this.dtp_kiedy_wyzej.TabIndex = 19;
            // 
            // DodawanieWpisu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 443);
            this.Controls.Add(this.dtp_kiedy_wyzej);
            this.Controls.Add(this.l_typ_funkcjonalnosci);
            this.Controls.Add(this.cb_typ_funkcjonalnosci);
            this.Controls.Add(this.l_program);
            this.Controls.Add(this.cb_program);
            this.Controls.Add(this.l_kiedy_wyzej);
            this.Controls.Add(this.lb_funkcjonalnosc);
            this.Controls.Add(this.l_funkcjonalnosc);
            this.Controls.Add(this.tb_funkcjonalnosc);
            this.Controls.Add(this.l_priorytet_wpisu);
            this.Controls.Add(this.nud_priorytet_wpisu);
            this.Controls.Add(this.l_stan);
            this.Controls.Add(this.cb_stan);
            this.Controls.Add(this.l_typ_zgloszenia);
            this.Controls.Add(this.cb_typ_zgloszenia);
            this.Controls.Add(this.l_tresc_wpisu);
            this.Controls.Add(this.tb_tresc);
            this.Controls.Add(this.b_anuluj_wpis);
            this.Controls.Add(this.b_zatwierdz_wpis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DodawanieWpisu";
            this.Text = "DodawanieWpisu";
            ((System.ComponentModel.ISupportInitialize)(this.nud_priorytet_wpisu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_zatwierdz_wpis;
        private System.Windows.Forms.Button b_anuluj_wpis;
        private System.Windows.Forms.TextBox tb_tresc;
        private System.Windows.Forms.Label l_tresc_wpisu;
        private System.Windows.Forms.ComboBox cb_typ_zgloszenia;
        private System.Windows.Forms.Label l_typ_zgloszenia;
        private System.Windows.Forms.ComboBox cb_stan;
        private System.Windows.Forms.Label l_stan;
        private System.Windows.Forms.NumericUpDown nud_priorytet_wpisu;
        private System.Windows.Forms.Label l_priorytet_wpisu;
        private System.Windows.Forms.TextBox tb_funkcjonalnosc;
        private System.Windows.Forms.Label l_funkcjonalnosc;
        private System.Windows.Forms.ListBox lb_funkcjonalnosc;
        private System.Windows.Forms.Label l_kiedy_wyzej;
        private System.Windows.Forms.Label l_program;
        private System.Windows.Forms.ComboBox cb_program;
        private System.Windows.Forms.Label l_typ_funkcjonalnosci;
        private System.Windows.Forms.ComboBox cb_typ_funkcjonalnosci;
        private System.Windows.Forms.DateTimePicker dtp_kiedy_wyzej;
    }
}