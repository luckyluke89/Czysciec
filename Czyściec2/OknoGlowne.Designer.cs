using System;

namespace Czyściec2
{
    partial class OknoGlowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_wpisy = new System.Windows.Forms.DataGridView();
            this.b_dodaj_wpis = new System.Windows.Forms.Button();
            this.b_usun_wpis = new System.Windows.Forms.Button();
            this.b_edytuj_wpis = new System.Windows.Forms.Button();
            this.dgv_notatki = new System.Windows.Forms.DataGridView();
            this.b_dodaj_notatke = new System.Windows.Forms.Button();
            this.b_usun_notatke = new System.Windows.Forms.Button();
            this.b_edytuj_notatke = new System.Windows.Forms.Button();
            this.tc_zakladki_okno_glowne = new System.Windows.Forms.TabControl();
            this.tp_wpisy_notki = new System.Windows.Forms.TabPage();
            this.l_s_priorytetnotatka_do = new System.Windows.Forms.Label();
            this.l_s_priorytetnotatka_od = new System.Windows.Forms.Label();
            this.nud_s_priorytetnotatka_do = new System.Windows.Forms.NumericUpDown();
            this.nud_s_priorytetnotatka_od = new System.Windows.Forms.NumericUpDown();
            this.l_s_priorytetwpisu_do = new System.Windows.Forms.Label();
            this.l_s_priorytetwpisu_od = new System.Windows.Forms.Label();
            this.nud_s_priorytetwpis_do = new System.Windows.Forms.NumericUpDown();
            this.nud_s_priorytetwpis_od = new System.Windows.Forms.NumericUpDown();
            this.l_s_klientnotatka = new System.Windows.Forms.Label();
            this.tb_s_klientnotatka = new System.Windows.Forms.TextBox();
            this.l_s_oddzwonicnotatka = new System.Windows.Forms.Label();
            this.cb_s_oddzwonicnotatka = new System.Windows.Forms.ComboBox();
            this.l_s_priorytetnotatka = new System.Windows.Forms.Label();
            this.l_s_autornotatka = new System.Windows.Forms.Label();
            this.tb_s_autornotatka = new System.Windows.Forms.TextBox();
            this.l_s_datanotatka = new System.Windows.Forms.Label();
            this.dtp_s_datanotatka = new System.Windows.Forms.DateTimePicker();
            this.l_s_trescnotatka = new System.Windows.Forms.Label();
            this.tb_s_trescnotatka = new System.Windows.Forms.TextBox();
            this.l_s_idnotatka = new System.Windows.Forms.Label();
            this.tb_s_idnotatka = new System.Windows.Forms.TextBox();
            this.l_s_typzgloszeniawpis = new System.Windows.Forms.Label();
            this.cb_s_typzgloszeniawpis = new System.Windows.Forms.ComboBox();
            this.l_s_stanwpis = new System.Windows.Forms.Label();
            this.cb_s_stanwpis = new System.Windows.Forms.ComboBox();
            this.l_s_autorwpis = new System.Windows.Forms.Label();
            this.tb_s_autorwpis = new System.Windows.Forms.TextBox();
            this.l_s_datawpisu = new System.Windows.Forms.Label();
            this.dtp_s_datawpisu = new System.Windows.Forms.DateTimePicker();
            this.l_s_kiedy_wyzejwpis = new System.Windows.Forms.Label();
            this.dtp_s_kiedy_wyzejwpis = new System.Windows.Forms.DateTimePicker();
            this.l_s_typfunkcjiwpis = new System.Windows.Forms.Label();
            this.cb_s_typfunkcjiwpis = new System.Windows.Forms.ComboBox();
            this.l_s_programwpis = new System.Windows.Forms.Label();
            this.cb_s_programwpis = new System.Windows.Forms.ComboBox();
            this.l_s_funkcjawpis = new System.Windows.Forms.Label();
            this.tb_s_funkcjawpis = new System.Windows.Forms.TextBox();
            this.l_s_priorytetwpisu = new System.Windows.Forms.Label();
            this.l_s_trescwpisu = new System.Windows.Forms.Label();
            this.tb_s_trescwpisu = new System.Windows.Forms.TextBox();
            this.l_s_idwpisu = new System.Windows.Forms.Label();
            this.tb_s_idwpisu = new System.Windows.Forms.TextBox();
            this.tb_szczegoly_notatki = new System.Windows.Forms.TextBox();
            this.tb_szczegoly_wpisu = new System.Windows.Forms.TextBox();
            this.tp_slowniki = new System.Windows.Forms.TabPage();
            this.gb_funkcjonalnosc = new System.Windows.Forms.GroupBox();
            this.l_program = new System.Windows.Forms.Label();
            this.l_typ_funkcji = new System.Windows.Forms.Label();
            this.cb_e_funkcjonalnosc_program = new System.Windows.Forms.ComboBox();
            this.cb_s_funkcjonalnosc_program = new System.Windows.Forms.ComboBox();
            this.cb_e_funkcjonalnosc_typ_funkcji = new System.Windows.Forms.ComboBox();
            this.cb_s_funkcjonalnosc_typ_funkcji = new System.Windows.Forms.ComboBox();
            this.b_funkcjonalnosc_edytuj = new System.Windows.Forms.Button();
            this.b_funkcjonalnosc_anuluj = new System.Windows.Forms.Button();
            this.b_funkcjonalnosc_usun = new System.Windows.Forms.Button();
            this.b_funkcjonalnosc_zatwierdz = new System.Windows.Forms.Button();
            this.b_funkcjonalnosc_dodaj = new System.Windows.Forms.Button();
            this.dgv_funkcjonalnosci = new System.Windows.Forms.DataGridView();
            this.l_funkcjonalnosc_szukaj = new System.Windows.Forms.Label();
            this.tb_s_funkcjonalnosc_nazwa = new System.Windows.Forms.TextBox();
            this.tb_e_funkcjonalnosc_id = new System.Windows.Forms.TextBox();
            this.tb_s_funkcjonalnosc_id = new System.Windows.Forms.TextBox();
            this.tb_e_funkcjonalnosc_nazwa = new System.Windows.Forms.TextBox();
            this.l_funkcjonalnosc_funkcjonalnosci = new System.Windows.Forms.Label();
            this.l_funkcjonalnosc_id = new System.Windows.Forms.Label();
            this.gb_programy = new System.Windows.Forms.GroupBox();
            this.b_program_edytuj = new System.Windows.Forms.Button();
            this.b_program_anuluj = new System.Windows.Forms.Button();
            this.b_program_usun = new System.Windows.Forms.Button();
            this.b_program_zatwierdz = new System.Windows.Forms.Button();
            this.b_program_dodaj = new System.Windows.Forms.Button();
            this.dgv_programy = new System.Windows.Forms.DataGridView();
            this.l_program_szukaj = new System.Windows.Forms.Label();
            this.tb_s_program_nazwa = new System.Windows.Forms.TextBox();
            this.tb_e_program_id = new System.Windows.Forms.TextBox();
            this.tb_s_program_id = new System.Windows.Forms.TextBox();
            this.tb_e_program_nazwa = new System.Windows.Forms.TextBox();
            this.l_program_nazwa = new System.Windows.Forms.Label();
            this.l_program_id = new System.Windows.Forms.Label();
            this.gb_klienci = new System.Windows.Forms.GroupBox();
            this.b_klient_edytuj = new System.Windows.Forms.Button();
            this.b_klient_anuluj = new System.Windows.Forms.Button();
            this.b_klient_usun = new System.Windows.Forms.Button();
            this.b_klient_zatwierdz = new System.Windows.Forms.Button();
            this.b_klient_dodaj = new System.Windows.Forms.Button();
            this.dgv_klienci = new System.Windows.Forms.DataGridView();
            this.l_klienci_szukaj = new System.Windows.Forms.Label();
            this.tb_s_klient_nazwa = new System.Windows.Forms.TextBox();
            this.tb_e_klient_id = new System.Windows.Forms.TextBox();
            this.tb_s_klient_id = new System.Windows.Forms.TextBox();
            this.tb_e_klient_nazwa = new System.Windows.Forms.TextBox();
            this.l_klient_nazwa = new System.Windows.Forms.Label();
            this.l_klient_id = new System.Windows.Forms.Label();
            this.gb_slowniki = new System.Windows.Forms.GroupBox();
            this.dgv_slowniki = new System.Windows.Forms.DataGridView();
            this.b_slowniki_edytuj = new System.Windows.Forms.Button();
            this.b_slowniki_anuluj = new System.Windows.Forms.Button();
            this.b_slowniki_zatwierdz = new System.Windows.Forms.Button();
            this.b_slowniki_usun = new System.Windows.Forms.Button();
            this.b_slowniki_dodaj = new System.Windows.Forms.Button();
            this.tb_e_slowniki_id = new System.Windows.Forms.TextBox();
            this.tb_e_slowniki_nazwa = new System.Windows.Forms.TextBox();
            this.l_slownik_id = new System.Windows.Forms.Label();
            this.l_slownik_nazwaelementu = new System.Windows.Forms.Label();
            this.tb_s_slowniki_id = new System.Windows.Forms.TextBox();
            this.tb_s_slowniki_nazwa = new System.Windows.Forms.TextBox();
            this.l_slowniki_szukaj = new System.Windows.Forms.Label();
            this.l_slownik = new System.Windows.Forms.Label();
            this.cb_slowniki = new System.Windows.Forms.ComboBox();
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.połączenieZBaząToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmianaHaslaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzytkownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radźSobieSamDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l_status = new System.Windows.Forms.Label();
            this.l_status_serwer = new System.Windows.Forms.Label();
            this.l_status_logowanie = new System.Windows.Forms.Label();
            this.l_s_klientwpis = new System.Windows.Forms.Label();
            this.tb_s_klientwpis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_wpisy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notatki)).BeginInit();
            this.tc_zakladki_okno_glowne.SuspendLayout();
            this.tp_wpisy_notki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s_priorytetnotatka_do)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s_priorytetnotatka_od)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s_priorytetwpis_do)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s_priorytetwpis_od)).BeginInit();
            this.tp_slowniki.SuspendLayout();
            this.gb_funkcjonalnosc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funkcjonalnosci)).BeginInit();
            this.gb_programy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_programy)).BeginInit();
            this.gb_klienci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klienci)).BeginInit();
            this.gb_slowniki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_slowniki)).BeginInit();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_wpisy
            // 
            this.dgv_wpisy.AllowUserToAddRows = false;
            this.dgv_wpisy.AllowUserToDeleteRows = false;
            this.dgv_wpisy.AllowUserToResizeRows = false;
            this.dgv_wpisy.ColumnHeadersHeight = 30;
            this.dgv_wpisy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_wpisy.Location = new System.Drawing.Point(52, 110);
            this.dgv_wpisy.MultiSelect = false;
            this.dgv_wpisy.Name = "dgv_wpisy";
            this.dgv_wpisy.ReadOnly = true;
            this.dgv_wpisy.RowHeadersVisible = false;
            this.dgv_wpisy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_wpisy.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_wpisy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_wpisy.Size = new System.Drawing.Size(789, 287);
            this.dgv_wpisy.TabIndex = 0;
            this.dgv_wpisy.SelectionChanged += new System.EventHandler(this.Dgv_wpisy_CellMouseClick);
            // 
            // b_dodaj_wpis
            // 
            this.b_dodaj_wpis.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_dodaj_wpis.Location = new System.Drawing.Point(6, 110);
            this.b_dodaj_wpis.Name = "b_dodaj_wpis";
            this.b_dodaj_wpis.Size = new System.Drawing.Size(40, 40);
            this.b_dodaj_wpis.TabIndex = 1;
            this.b_dodaj_wpis.Text = "+";
            this.b_dodaj_wpis.UseVisualStyleBackColor = true;
            this.b_dodaj_wpis.Click += new System.EventHandler(this.b_dodaj_wpis_Click);
            // 
            // b_usun_wpis
            // 
            this.b_usun_wpis.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_usun_wpis.Location = new System.Drawing.Point(6, 202);
            this.b_usun_wpis.Name = "b_usun_wpis";
            this.b_usun_wpis.Size = new System.Drawing.Size(40, 40);
            this.b_usun_wpis.TabIndex = 2;
            this.b_usun_wpis.Text = "-";
            this.b_usun_wpis.UseVisualStyleBackColor = true;
            this.b_usun_wpis.Click += new System.EventHandler(this.b_usun_wpis_Click);
            // 
            // b_edytuj_wpis
            // 
            this.b_edytuj_wpis.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_edytuj_wpis.Location = new System.Drawing.Point(6, 156);
            this.b_edytuj_wpis.Name = "b_edytuj_wpis";
            this.b_edytuj_wpis.Size = new System.Drawing.Size(40, 40);
            this.b_edytuj_wpis.TabIndex = 3;
            this.b_edytuj_wpis.Text = "I";
            this.b_edytuj_wpis.UseVisualStyleBackColor = true;
            this.b_edytuj_wpis.Click += new System.EventHandler(this.b_edytuj_wpis_Click);
            // 
            // dgv_notatki
            // 
            this.dgv_notatki.AllowUserToAddRows = false;
            this.dgv_notatki.AllowUserToDeleteRows = false;
            this.dgv_notatki.AllowUserToResizeRows = false;
            this.dgv_notatki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_notatki.ColumnHeadersHeight = 30;
            this.dgv_notatki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_notatki.Location = new System.Drawing.Point(52, 471);
            this.dgv_notatki.Name = "dgv_notatki";
            this.dgv_notatki.ReadOnly = true;
            this.dgv_notatki.RowHeadersVisible = false;
            this.dgv_notatki.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_notatki.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_notatki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_notatki.Size = new System.Drawing.Size(789, 303);
            this.dgv_notatki.TabIndex = 4;
            this.dgv_notatki.SelectionChanged += new System.EventHandler(this.Dgv_notatki_CellMouseClick);
            // 
            // b_dodaj_notatke
            // 
            this.b_dodaj_notatke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_dodaj_notatke.Location = new System.Drawing.Point(6, 471);
            this.b_dodaj_notatke.Name = "b_dodaj_notatke";
            this.b_dodaj_notatke.Size = new System.Drawing.Size(40, 40);
            this.b_dodaj_notatke.TabIndex = 5;
            this.b_dodaj_notatke.Text = "+";
            this.b_dodaj_notatke.UseVisualStyleBackColor = true;
            this.b_dodaj_notatke.Click += new System.EventHandler(this.b_dodaj_notatke_Click);
            // 
            // b_usun_notatke
            // 
            this.b_usun_notatke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_usun_notatke.Location = new System.Drawing.Point(6, 563);
            this.b_usun_notatke.Name = "b_usun_notatke";
            this.b_usun_notatke.Size = new System.Drawing.Size(40, 40);
            this.b_usun_notatke.TabIndex = 6;
            this.b_usun_notatke.Text = "-";
            this.b_usun_notatke.UseVisualStyleBackColor = true;
            this.b_usun_notatke.Click += new System.EventHandler(this.b_usun_notatke_Click);
            // 
            // b_edytuj_notatke
            // 
            this.b_edytuj_notatke.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_edytuj_notatke.Location = new System.Drawing.Point(6, 517);
            this.b_edytuj_notatke.Name = "b_edytuj_notatke";
            this.b_edytuj_notatke.Size = new System.Drawing.Size(40, 40);
            this.b_edytuj_notatke.TabIndex = 7;
            this.b_edytuj_notatke.Text = "I";
            this.b_edytuj_notatke.UseVisualStyleBackColor = true;
            this.b_edytuj_notatke.Click += new System.EventHandler(this.b_edytuj_notatke_Click);
            // 
            // tc_zakladki_okno_glowne
            // 
            this.tc_zakladki_okno_glowne.Controls.Add(this.tp_wpisy_notki);
            this.tc_zakladki_okno_glowne.Controls.Add(this.tp_slowniki);
            this.tc_zakladki_okno_glowne.Enabled = false;
            this.tc_zakladki_okno_glowne.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tc_zakladki_okno_glowne.Location = new System.Drawing.Point(11, 43);
            this.tc_zakladki_okno_glowne.Name = "tc_zakladki_okno_glowne";
            this.tc_zakladki_okno_glowne.SelectedIndex = 0;
            this.tc_zakladki_okno_glowne.Size = new System.Drawing.Size(1160, 806);
            this.tc_zakladki_okno_glowne.TabIndex = 10;
            // 
            // tp_wpisy_notki
            // 
            this.tp_wpisy_notki.BackColor = System.Drawing.Color.Transparent;
            this.tp_wpisy_notki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tp_wpisy_notki.Controls.Add(this.l_s_klientwpis);
            this.tp_wpisy_notki.Controls.Add(this.l_s_priorytetnotatka_do);
            this.tp_wpisy_notki.Controls.Add(this.tb_s_klientwpis);
            this.tp_wpisy_notki.Controls.Add(this.l_s_priorytetnotatka_od);
            this.tp_wpisy_notki.Controls.Add(this.nud_s_priorytetnotatka_do);
            this.tp_wpisy_notki.Controls.Add(this.nud_s_priorytetnotatka_od);
            this.tp_wpisy_notki.Controls.Add(this.l_s_priorytetwpisu_do);
            this.tp_wpisy_notki.Controls.Add(this.l_s_priorytetwpisu_od);
            this.tp_wpisy_notki.Controls.Add(this.nud_s_priorytetwpis_do);
            this.tp_wpisy_notki.Controls.Add(this.nud_s_priorytetwpis_od);
            this.tp_wpisy_notki.Controls.Add(this.l_s_klientnotatka);
            this.tp_wpisy_notki.Controls.Add(this.tb_s_klientnotatka);
            this.tp_wpisy_notki.Controls.Add(this.l_s_oddzwonicnotatka);
            this.tp_wpisy_notki.Controls.Add(this.cb_s_oddzwonicnotatka);
            this.tp_wpisy_notki.Controls.Add(this.l_s_priorytetnotatka);
            this.tp_wpisy_notki.Controls.Add(this.l_s_autornotatka);
            this.tp_wpisy_notki.Controls.Add(this.tb_s_autornotatka);
            this.tp_wpisy_notki.Controls.Add(this.l_s_datanotatka);
            this.tp_wpisy_notki.Controls.Add(this.dtp_s_datanotatka);
            this.tp_wpisy_notki.Controls.Add(this.l_s_trescnotatka);
            this.tp_wpisy_notki.Controls.Add(this.tb_s_trescnotatka);
            this.tp_wpisy_notki.Controls.Add(this.l_s_idnotatka);
            this.tp_wpisy_notki.Controls.Add(this.tb_s_idnotatka);
            this.tp_wpisy_notki.Controls.Add(this.l_s_typzgloszeniawpis);
            this.tp_wpisy_notki.Controls.Add(this.cb_s_typzgloszeniawpis);
            this.tp_wpisy_notki.Controls.Add(this.l_s_stanwpis);
            this.tp_wpisy_notki.Controls.Add(this.cb_s_stanwpis);
            this.tp_wpisy_notki.Controls.Add(this.l_s_autorwpis);
            this.tp_wpisy_notki.Controls.Add(this.tb_s_autorwpis);
            this.tp_wpisy_notki.Controls.Add(this.l_s_datawpisu);
            this.tp_wpisy_notki.Controls.Add(this.dtp_s_datawpisu);
            this.tp_wpisy_notki.Controls.Add(this.l_s_kiedy_wyzejwpis);
            this.tp_wpisy_notki.Controls.Add(this.dtp_s_kiedy_wyzejwpis);
            this.tp_wpisy_notki.Controls.Add(this.l_s_typfunkcjiwpis);
            this.tp_wpisy_notki.Controls.Add(this.cb_s_typfunkcjiwpis);
            this.tp_wpisy_notki.Controls.Add(this.l_s_programwpis);
            this.tp_wpisy_notki.Controls.Add(this.cb_s_programwpis);
            this.tp_wpisy_notki.Controls.Add(this.l_s_funkcjawpis);
            this.tp_wpisy_notki.Controls.Add(this.tb_s_funkcjawpis);
            this.tp_wpisy_notki.Controls.Add(this.l_s_priorytetwpisu);
            this.tp_wpisy_notki.Controls.Add(this.l_s_trescwpisu);
            this.tp_wpisy_notki.Controls.Add(this.tb_s_trescwpisu);
            this.tp_wpisy_notki.Controls.Add(this.l_s_idwpisu);
            this.tp_wpisy_notki.Controls.Add(this.tb_s_idwpisu);
            this.tp_wpisy_notki.Controls.Add(this.tb_szczegoly_notatki);
            this.tp_wpisy_notki.Controls.Add(this.tb_szczegoly_wpisu);
            this.tp_wpisy_notki.Controls.Add(this.b_edytuj_wpis);
            this.tp_wpisy_notki.Controls.Add(this.b_dodaj_wpis);
            this.tp_wpisy_notki.Controls.Add(this.b_edytuj_notatke);
            this.tp_wpisy_notki.Controls.Add(this.b_usun_notatke);
            this.tp_wpisy_notki.Controls.Add(this.b_usun_wpis);
            this.tp_wpisy_notki.Controls.Add(this.b_dodaj_notatke);
            this.tp_wpisy_notki.Controls.Add(this.dgv_wpisy);
            this.tp_wpisy_notki.Controls.Add(this.dgv_notatki);
            this.tp_wpisy_notki.Location = new System.Drawing.Point(4, 22);
            this.tp_wpisy_notki.Name = "tp_wpisy_notki";
            this.tp_wpisy_notki.Padding = new System.Windows.Forms.Padding(3);
            this.tp_wpisy_notki.Size = new System.Drawing.Size(1152, 780);
            this.tp_wpisy_notki.TabIndex = 0;
            this.tp_wpisy_notki.Text = "Wpisy i notatki";
            this.tp_wpisy_notki.UseVisualStyleBackColor = true;
            // 
            // l_s_priorytetnotatka_do
            // 
            this.l_s_priorytetnotatka_do.AutoSize = true;
            this.l_s_priorytetnotatka_do.Location = new System.Drawing.Point(598, 429);
            this.l_s_priorytetnotatka_do.Name = "l_s_priorytetnotatka_do";
            this.l_s_priorytetnotatka_do.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_s_priorytetnotatka_do.Size = new System.Drawing.Size(30, 13);
            this.l_s_priorytetnotatka_do.TabIndex = 56;
            this.l_s_priorytetnotatka_do.Text = "Max:";
            this.l_s_priorytetnotatka_do.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_s_priorytetnotatka_od
            // 
            this.l_s_priorytetnotatka_od.AutoSize = true;
            this.l_s_priorytetnotatka_od.Location = new System.Drawing.Point(539, 429);
            this.l_s_priorytetnotatka_od.Name = "l_s_priorytetnotatka_od";
            this.l_s_priorytetnotatka_od.Size = new System.Drawing.Size(27, 13);
            this.l_s_priorytetnotatka_od.TabIndex = 55;
            this.l_s_priorytetnotatka_od.Text = "Min:";
            // 
            // nud_s_priorytetnotatka_do
            // 
            this.nud_s_priorytetnotatka_do.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nud_s_priorytetnotatka_do.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_s_priorytetnotatka_do.Location = new System.Drawing.Point(588, 445);
            this.nud_s_priorytetnotatka_do.Name = "nud_s_priorytetnotatka_do";
            this.nud_s_priorytetnotatka_do.Size = new System.Drawing.Size(40, 20);
            this.nud_s_priorytetnotatka_do.TabIndex = 54;
            this.nud_s_priorytetnotatka_do.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_s_priorytetnotatka_do.ValueChanged += new System.EventHandler(this.nud_s_priorytetnotatka_do_ValueChanged);
            // 
            // nud_s_priorytetnotatka_od
            // 
            this.nud_s_priorytetnotatka_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nud_s_priorytetnotatka_od.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_s_priorytetnotatka_od.Location = new System.Drawing.Point(542, 445);
            this.nud_s_priorytetnotatka_od.Name = "nud_s_priorytetnotatka_od";
            this.nud_s_priorytetnotatka_od.Size = new System.Drawing.Size(40, 20);
            this.nud_s_priorytetnotatka_od.TabIndex = 53;
            this.nud_s_priorytetnotatka_od.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_s_priorytetnotatka_od.ValueChanged += new System.EventHandler(this.nud_s_priorytetnotatka_od_ValueChanged);
            // 
            // l_s_priorytetwpisu_do
            // 
            this.l_s_priorytetwpisu_do.AutoSize = true;
            this.l_s_priorytetwpisu_do.Location = new System.Drawing.Point(434, 29);
            this.l_s_priorytetwpisu_do.Name = "l_s_priorytetwpisu_do";
            this.l_s_priorytetwpisu_do.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_s_priorytetwpisu_do.Size = new System.Drawing.Size(30, 13);
            this.l_s_priorytetwpisu_do.TabIndex = 52;
            this.l_s_priorytetwpisu_do.Text = "Max:";
            this.l_s_priorytetwpisu_do.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_s_priorytetwpisu_od
            // 
            this.l_s_priorytetwpisu_od.AutoSize = true;
            this.l_s_priorytetwpisu_od.Location = new System.Drawing.Point(375, 29);
            this.l_s_priorytetwpisu_od.Name = "l_s_priorytetwpisu_od";
            this.l_s_priorytetwpisu_od.Size = new System.Drawing.Size(27, 13);
            this.l_s_priorytetwpisu_od.TabIndex = 51;
            this.l_s_priorytetwpisu_od.Text = "Min:";
            // 
            // nud_s_priorytetwpis_do
            // 
            this.nud_s_priorytetwpis_do.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nud_s_priorytetwpis_do.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_s_priorytetwpis_do.Location = new System.Drawing.Point(424, 45);
            this.nud_s_priorytetwpis_do.Name = "nud_s_priorytetwpis_do";
            this.nud_s_priorytetwpis_do.Size = new System.Drawing.Size(40, 20);
            this.nud_s_priorytetwpis_do.TabIndex = 50;
            this.nud_s_priorytetwpis_do.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_s_priorytetwpis_do.ValueChanged += new System.EventHandler(this.nud_s_priorytetwpis_do_ValueChanged);
            // 
            // nud_s_priorytetwpis_od
            // 
            this.nud_s_priorytetwpis_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nud_s_priorytetwpis_od.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_s_priorytetwpis_od.Location = new System.Drawing.Point(378, 45);
            this.nud_s_priorytetwpis_od.Name = "nud_s_priorytetwpis_od";
            this.nud_s_priorytetwpis_od.Size = new System.Drawing.Size(40, 20);
            this.nud_s_priorytetwpis_od.TabIndex = 49;
            this.nud_s_priorytetwpis_od.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_s_priorytetwpis_od.ValueChanged += new System.EventHandler(this.nud_s_priorytetwpis_od_ValueChanged);
            // 
            // l_s_klientnotatka
            // 
            this.l_s_klientnotatka.AutoSize = true;
            this.l_s_klientnotatka.Location = new System.Drawing.Point(754, 429);
            this.l_s_klientnotatka.Name = "l_s_klientnotatka";
            this.l_s_klientnotatka.Size = new System.Drawing.Size(36, 13);
            this.l_s_klientnotatka.TabIndex = 47;
            this.l_s_klientnotatka.Text = "Klient:";
            // 
            // tb_s_klientnotatka
            // 
            this.tb_s_klientnotatka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_s_klientnotatka.Location = new System.Drawing.Point(757, 445);
            this.tb_s_klientnotatka.Name = "tb_s_klientnotatka";
            this.tb_s_klientnotatka.Size = new System.Drawing.Size(128, 20);
            this.tb_s_klientnotatka.TabIndex = 48;
            this.tb_s_klientnotatka.TextChanged += new System.EventHandler(this.tb_s_klientnotatka_TextChanged);
            // 
            // l_s_oddzwonicnotatka
            // 
            this.l_s_oddzwonicnotatka.AutoSize = true;
            this.l_s_oddzwonicnotatka.Location = new System.Drawing.Point(631, 429);
            this.l_s_oddzwonicnotatka.Name = "l_s_oddzwonicnotatka";
            this.l_s_oddzwonicnotatka.Size = new System.Drawing.Size(63, 13);
            this.l_s_oddzwonicnotatka.TabIndex = 46;
            this.l_s_oddzwonicnotatka.Text = "Oddzwonić:";
            // 
            // cb_s_oddzwonicnotatka
            // 
            this.cb_s_oddzwonicnotatka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_s_oddzwonicnotatka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_s_oddzwonicnotatka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_s_oddzwonicnotatka.FormattingEnabled = true;
            this.cb_s_oddzwonicnotatka.Location = new System.Drawing.Point(634, 444);
            this.cb_s_oddzwonicnotatka.MaxDropDownItems = 99;
            this.cb_s_oddzwonicnotatka.Name = "cb_s_oddzwonicnotatka";
            this.cb_s_oddzwonicnotatka.Size = new System.Drawing.Size(117, 21);
            this.cb_s_oddzwonicnotatka.TabIndex = 45;
            this.cb_s_oddzwonicnotatka.SelectedIndexChanged += new System.EventHandler(this.cb_s_oddzwonicnotatka_SelectedIndexChanged);
            // 
            // l_s_priorytetnotatka
            // 
            this.l_s_priorytetnotatka.AutoSize = true;
            this.l_s_priorytetnotatka.Location = new System.Drawing.Point(556, 416);
            this.l_s_priorytetnotatka.Name = "l_s_priorytetnotatka";
            this.l_s_priorytetnotatka.Size = new System.Drawing.Size(48, 13);
            this.l_s_priorytetnotatka.TabIndex = 43;
            this.l_s_priorytetnotatka.Text = "Priorytet:";
            // 
            // l_s_autornotatka
            // 
            this.l_s_autornotatka.AutoSize = true;
            this.l_s_autornotatka.Location = new System.Drawing.Point(430, 429);
            this.l_s_autornotatka.Name = "l_s_autornotatka";
            this.l_s_autornotatka.Size = new System.Drawing.Size(35, 13);
            this.l_s_autornotatka.TabIndex = 41;
            this.l_s_autornotatka.Text = "Autor:";
            // 
            // tb_s_autornotatka
            // 
            this.tb_s_autornotatka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_s_autornotatka.Location = new System.Drawing.Point(433, 445);
            this.tb_s_autornotatka.Name = "tb_s_autornotatka";
            this.tb_s_autornotatka.Size = new System.Drawing.Size(103, 20);
            this.tb_s_autornotatka.TabIndex = 42;
            this.tb_s_autornotatka.TextChanged += new System.EventHandler(this.tb_s_autornotatka_TextChanged);
            // 
            // l_s_datanotatka
            // 
            this.l_s_datanotatka.AutoSize = true;
            this.l_s_datanotatka.Location = new System.Drawing.Point(311, 429);
            this.l_s_datanotatka.Name = "l_s_datanotatka";
            this.l_s_datanotatka.Size = new System.Drawing.Size(68, 13);
            this.l_s_datanotatka.TabIndex = 40;
            this.l_s_datanotatka.Text = "Data notatki:";
            // 
            // dtp_s_datanotatka
            // 
            this.dtp_s_datanotatka.Checked = false;
            this.dtp_s_datanotatka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_s_datanotatka.Location = new System.Drawing.Point(314, 445);
            this.dtp_s_datanotatka.Name = "dtp_s_datanotatka";
            this.dtp_s_datanotatka.ShowCheckBox = true;
            this.dtp_s_datanotatka.Size = new System.Drawing.Size(113, 20);
            this.dtp_s_datanotatka.TabIndex = 39;
            this.dtp_s_datanotatka.ValueChanged += new System.EventHandler(this.dtp_s_datanotatka_ValueChanged);
            // 
            // l_s_trescnotatka
            // 
            this.l_s_trescnotatka.AutoSize = true;
            this.l_s_trescnotatka.Location = new System.Drawing.Point(124, 429);
            this.l_s_trescnotatka.Name = "l_s_trescnotatka";
            this.l_s_trescnotatka.Size = new System.Drawing.Size(37, 13);
            this.l_s_trescnotatka.TabIndex = 37;
            this.l_s_trescnotatka.Text = "Treść:";
            // 
            // tb_s_trescnotatka
            // 
            this.tb_s_trescnotatka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_s_trescnotatka.Location = new System.Drawing.Point(127, 445);
            this.tb_s_trescnotatka.Name = "tb_s_trescnotatka";
            this.tb_s_trescnotatka.Size = new System.Drawing.Size(181, 20);
            this.tb_s_trescnotatka.TabIndex = 38;
            this.tb_s_trescnotatka.TextChanged += new System.EventHandler(this.tb_s_trescnotatka_TextChanged);
            // 
            // l_s_idnotatka
            // 
            this.l_s_idnotatka.AutoSize = true;
            this.l_s_idnotatka.Location = new System.Drawing.Point(49, 429);
            this.l_s_idnotatka.Name = "l_s_idnotatka";
            this.l_s_idnotatka.Size = new System.Drawing.Size(19, 13);
            this.l_s_idnotatka.TabIndex = 35;
            this.l_s_idnotatka.Text = "Id:";
            // 
            // tb_s_idnotatka
            // 
            this.tb_s_idnotatka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_s_idnotatka.Location = new System.Drawing.Point(52, 445);
            this.tb_s_idnotatka.Name = "tb_s_idnotatka";
            this.tb_s_idnotatka.Size = new System.Drawing.Size(69, 20);
            this.tb_s_idnotatka.TabIndex = 36;
            this.tb_s_idnotatka.TextChanged += new System.EventHandler(this.tb_s_idnotatka_TextChanged);
            // 
            // l_s_typzgloszeniawpis
            // 
            this.l_s_typzgloszeniawpis.AutoSize = true;
            this.l_s_typzgloszeniawpis.Location = new System.Drawing.Point(1037, 29);
            this.l_s_typzgloszeniawpis.Name = "l_s_typzgloszeniawpis";
            this.l_s_typzgloszeniawpis.Size = new System.Drawing.Size(82, 13);
            this.l_s_typzgloszeniawpis.TabIndex = 34;
            this.l_s_typzgloszeniawpis.Text = "Typ zgłoszenia:";
            // 
            // cb_s_typzgloszeniawpis
            // 
            this.cb_s_typzgloszeniawpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_s_typzgloszeniawpis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_s_typzgloszeniawpis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_s_typzgloszeniawpis.FormattingEnabled = true;
            this.cb_s_typzgloszeniawpis.Location = new System.Drawing.Point(1040, 44);
            this.cb_s_typzgloszeniawpis.MaxDropDownItems = 99;
            this.cb_s_typzgloszeniawpis.Name = "cb_s_typzgloszeniawpis";
            this.cb_s_typzgloszeniawpis.Size = new System.Drawing.Size(106, 21);
            this.cb_s_typzgloszeniawpis.TabIndex = 33;
            this.cb_s_typzgloszeniawpis.SelectedIndexChanged += new System.EventHandler(this.cb_s_typzgloszeniawpis_SelectedIndexChanged);
            // 
            // l_s_stanwpis
            // 
            this.l_s_stanwpis.AutoSize = true;
            this.l_s_stanwpis.Location = new System.Drawing.Point(947, 29);
            this.l_s_stanwpis.Name = "l_s_stanwpis";
            this.l_s_stanwpis.Size = new System.Drawing.Size(32, 13);
            this.l_s_stanwpis.TabIndex = 32;
            this.l_s_stanwpis.Text = "Stan:";
            // 
            // cb_s_stanwpis
            // 
            this.cb_s_stanwpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_s_stanwpis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_s_stanwpis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_s_stanwpis.FormattingEnabled = true;
            this.cb_s_stanwpis.Location = new System.Drawing.Point(950, 44);
            this.cb_s_stanwpis.MaxDropDownItems = 99;
            this.cb_s_stanwpis.Name = "cb_s_stanwpis";
            this.cb_s_stanwpis.Size = new System.Drawing.Size(84, 21);
            this.cb_s_stanwpis.TabIndex = 31;
            this.cb_s_stanwpis.SelectedIndexChanged += new System.EventHandler(this.cb_s_stanwpis_SelectedIndexChanged);
            // 
            // l_s_autorwpis
            // 
            this.l_s_autorwpis.AutoSize = true;
            this.l_s_autorwpis.Location = new System.Drawing.Point(774, 28);
            this.l_s_autorwpis.Name = "l_s_autorwpis";
            this.l_s_autorwpis.Size = new System.Drawing.Size(35, 13);
            this.l_s_autorwpis.TabIndex = 29;
            this.l_s_autorwpis.Text = "Autor:";
            // 
            // tb_s_autorwpis
            // 
            this.tb_s_autorwpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_s_autorwpis.Location = new System.Drawing.Point(777, 45);
            this.tb_s_autorwpis.Name = "tb_s_autorwpis";
            this.tb_s_autorwpis.Size = new System.Drawing.Size(73, 20);
            this.tb_s_autorwpis.TabIndex = 30;
            this.tb_s_autorwpis.TextChanged += new System.EventHandler(this.tb_s_nickwpis_TextChanged);
            // 
            // l_s_datawpisu
            // 
            this.l_s_datawpisu.AutoSize = true;
            this.l_s_datawpisu.Location = new System.Drawing.Point(124, 29);
            this.l_s_datawpisu.Name = "l_s_datawpisu";
            this.l_s_datawpisu.Size = new System.Drawing.Size(63, 13);
            this.l_s_datawpisu.TabIndex = 28;
            this.l_s_datawpisu.Text = "Data wpisu:";
            // 
            // dtp_s_datawpisu
            // 
            this.dtp_s_datawpisu.Checked = false;
            this.dtp_s_datawpisu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_s_datawpisu.Location = new System.Drawing.Point(127, 45);
            this.dtp_s_datawpisu.Name = "dtp_s_datawpisu";
            this.dtp_s_datawpisu.ShowCheckBox = true;
            this.dtp_s_datawpisu.Size = new System.Drawing.Size(110, 20);
            this.dtp_s_datawpisu.TabIndex = 27;
            this.dtp_s_datawpisu.ValueChanged += new System.EventHandler(this.dtp_s_datawpisu_ValueChanged);
            // 
            // l_s_kiedy_wyzejwpis
            // 
            this.l_s_kiedy_wyzejwpis.AutoSize = true;
            this.l_s_kiedy_wyzejwpis.Location = new System.Drawing.Point(467, 29);
            this.l_s_kiedy_wyzejwpis.Name = "l_s_kiedy_wyzejwpis";
            this.l_s_kiedy_wyzejwpis.Size = new System.Drawing.Size(69, 13);
            this.l_s_kiedy_wyzejwpis.TabIndex = 26;
            this.l_s_kiedy_wyzejwpis.Text = "Przek. wyżej:";
            // 
            // dtp_s_kiedy_wyzejwpis
            // 
            this.dtp_s_kiedy_wyzejwpis.Checked = false;
            this.dtp_s_kiedy_wyzejwpis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_s_kiedy_wyzejwpis.Location = new System.Drawing.Point(470, 45);
            this.dtp_s_kiedy_wyzejwpis.Name = "dtp_s_kiedy_wyzejwpis";
            this.dtp_s_kiedy_wyzejwpis.ShowCheckBox = true;
            this.dtp_s_kiedy_wyzejwpis.Size = new System.Drawing.Size(108, 20);
            this.dtp_s_kiedy_wyzejwpis.TabIndex = 25;
            this.dtp_s_kiedy_wyzejwpis.ValueChanged += new System.EventHandler(this.dtp_s_kiedy_wyzejwpis_ValueChanged);
            // 
            // l_s_typfunkcjiwpis
            // 
            this.l_s_typfunkcjiwpis.AutoSize = true;
            this.l_s_typfunkcjiwpis.Location = new System.Drawing.Point(853, 29);
            this.l_s_typfunkcjiwpis.Name = "l_s_typfunkcjiwpis";
            this.l_s_typfunkcjiwpis.Size = new System.Drawing.Size(62, 13);
            this.l_s_typfunkcjiwpis.TabIndex = 24;
            this.l_s_typfunkcjiwpis.Text = "Typ funkcji:";
            // 
            // cb_s_typfunkcjiwpis
            // 
            this.cb_s_typfunkcjiwpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_s_typfunkcjiwpis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_s_typfunkcjiwpis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_s_typfunkcjiwpis.FormattingEnabled = true;
            this.cb_s_typfunkcjiwpis.Location = new System.Drawing.Point(856, 44);
            this.cb_s_typfunkcjiwpis.MaxDropDownItems = 99;
            this.cb_s_typfunkcjiwpis.Name = "cb_s_typfunkcjiwpis";
            this.cb_s_typfunkcjiwpis.Size = new System.Drawing.Size(88, 21);
            this.cb_s_typfunkcjiwpis.TabIndex = 23;
            this.cb_s_typfunkcjiwpis.SelectedIndexChanged += new System.EventHandler(this.cb_s_typfunkcjiwpis_SelectedIndexChanged);
            // 
            // l_s_programwpis
            // 
            this.l_s_programwpis.AutoSize = true;
            this.l_s_programwpis.Location = new System.Drawing.Point(660, 29);
            this.l_s_programwpis.Name = "l_s_programwpis";
            this.l_s_programwpis.Size = new System.Drawing.Size(49, 13);
            this.l_s_programwpis.TabIndex = 22;
            this.l_s_programwpis.Text = "Program:";
            // 
            // cb_s_programwpis
            // 
            this.cb_s_programwpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cb_s_programwpis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_s_programwpis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_s_programwpis.FormattingEnabled = true;
            this.cb_s_programwpis.Location = new System.Drawing.Point(663, 45);
            this.cb_s_programwpis.MaxDropDownItems = 99;
            this.cb_s_programwpis.Name = "cb_s_programwpis";
            this.cb_s_programwpis.Size = new System.Drawing.Size(108, 21);
            this.cb_s_programwpis.TabIndex = 21;
            this.cb_s_programwpis.SelectedIndexChanged += new System.EventHandler(this.cb_s_programwpis_SelectedIndexChanged);
            // 
            // l_s_funkcjawpis
            // 
            this.l_s_funkcjawpis.AutoSize = true;
            this.l_s_funkcjawpis.Location = new System.Drawing.Point(581, 29);
            this.l_s_funkcjawpis.Name = "l_s_funkcjawpis";
            this.l_s_funkcjawpis.Size = new System.Drawing.Size(48, 13);
            this.l_s_funkcjawpis.TabIndex = 17;
            this.l_s_funkcjawpis.Text = "Funkcja:";
            // 
            // tb_s_funkcjawpis
            // 
            this.tb_s_funkcjawpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_s_funkcjawpis.Location = new System.Drawing.Point(584, 45);
            this.tb_s_funkcjawpis.Name = "tb_s_funkcjawpis";
            this.tb_s_funkcjawpis.Size = new System.Drawing.Size(73, 20);
            this.tb_s_funkcjawpis.TabIndex = 18;
            this.tb_s_funkcjawpis.TextChanged += new System.EventHandler(this.tb_s_funkcjawpis_TextChanged);
            // 
            // l_s_priorytetwpisu
            // 
            this.l_s_priorytetwpisu.AutoSize = true;
            this.l_s_priorytetwpisu.Location = new System.Drawing.Point(394, 16);
            this.l_s_priorytetwpisu.Name = "l_s_priorytetwpisu";
            this.l_s_priorytetwpisu.Size = new System.Drawing.Size(48, 13);
            this.l_s_priorytetwpisu.TabIndex = 15;
            this.l_s_priorytetwpisu.Text = "Priorytet:";
            // 
            // l_s_trescwpisu
            // 
            this.l_s_trescwpisu.AutoSize = true;
            this.l_s_trescwpisu.Location = new System.Drawing.Point(240, 29);
            this.l_s_trescwpisu.Name = "l_s_trescwpisu";
            this.l_s_trescwpisu.Size = new System.Drawing.Size(37, 13);
            this.l_s_trescwpisu.TabIndex = 13;
            this.l_s_trescwpisu.Text = "Treść:";
            // 
            // tb_s_trescwpisu
            // 
            this.tb_s_trescwpisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_s_trescwpisu.Location = new System.Drawing.Point(243, 45);
            this.tb_s_trescwpisu.Name = "tb_s_trescwpisu";
            this.tb_s_trescwpisu.Size = new System.Drawing.Size(129, 20);
            this.tb_s_trescwpisu.TabIndex = 14;
            this.tb_s_trescwpisu.TextChanged += new System.EventHandler(this.tb_s_trescwpisu_TextChanged);
            // 
            // l_s_idwpisu
            // 
            this.l_s_idwpisu.AutoSize = true;
            this.l_s_idwpisu.Location = new System.Drawing.Point(49, 29);
            this.l_s_idwpisu.Name = "l_s_idwpisu";
            this.l_s_idwpisu.Size = new System.Drawing.Size(19, 13);
            this.l_s_idwpisu.TabIndex = 12;
            this.l_s_idwpisu.Text = "Id:";
            // 
            // tb_s_idwpisu
            // 
            this.tb_s_idwpisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_s_idwpisu.Location = new System.Drawing.Point(52, 45);
            this.tb_s_idwpisu.Name = "tb_s_idwpisu";
            this.tb_s_idwpisu.Size = new System.Drawing.Size(69, 20);
            this.tb_s_idwpisu.TabIndex = 12;
            this.tb_s_idwpisu.TextChanged += new System.EventHandler(this.tb_s_idwpisu_TextChanged);
            // 
            // tb_szczegoly_notatki
            // 
            this.tb_szczegoly_notatki.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_szczegoly_notatki.Location = new System.Drawing.Point(847, 471);
            this.tb_szczegoly_notatki.Multiline = true;
            this.tb_szczegoly_notatki.Name = "tb_szczegoly_notatki";
            this.tb_szczegoly_notatki.ReadOnly = true;
            this.tb_szczegoly_notatki.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_szczegoly_notatki.Size = new System.Drawing.Size(299, 303);
            this.tb_szczegoly_notatki.TabIndex = 11;
            // 
            // tb_szczegoly_wpisu
            // 
            this.tb_szczegoly_wpisu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_szczegoly_wpisu.Location = new System.Drawing.Point(847, 110);
            this.tb_szczegoly_wpisu.MaxLength = 999999;
            this.tb_szczegoly_wpisu.Multiline = true;
            this.tb_szczegoly_wpisu.Name = "tb_szczegoly_wpisu";
            this.tb_szczegoly_wpisu.ReadOnly = true;
            this.tb_szczegoly_wpisu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_szczegoly_wpisu.Size = new System.Drawing.Size(299, 287);
            this.tb_szczegoly_wpisu.TabIndex = 10;
            // 
            // tp_slowniki
            // 
            this.tp_slowniki.BackColor = System.Drawing.Color.Transparent;
            this.tp_slowniki.Controls.Add(this.gb_funkcjonalnosc);
            this.tp_slowniki.Controls.Add(this.gb_programy);
            this.tp_slowniki.Controls.Add(this.gb_klienci);
            this.tp_slowniki.Controls.Add(this.gb_slowniki);
            this.tp_slowniki.Location = new System.Drawing.Point(4, 22);
            this.tp_slowniki.Name = "tp_slowniki";
            this.tp_slowniki.Padding = new System.Windows.Forms.Padding(3);
            this.tp_slowniki.Size = new System.Drawing.Size(1152, 780);
            this.tp_slowniki.TabIndex = 1;
            this.tp_slowniki.Text = "Słowniki";
            this.tp_slowniki.UseVisualStyleBackColor = true;
            // 
            // gb_funkcjonalnosc
            // 
            this.gb_funkcjonalnosc.BackColor = System.Drawing.Color.Transparent;
            this.gb_funkcjonalnosc.Controls.Add(this.l_program);
            this.gb_funkcjonalnosc.Controls.Add(this.l_typ_funkcji);
            this.gb_funkcjonalnosc.Controls.Add(this.cb_e_funkcjonalnosc_program);
            this.gb_funkcjonalnosc.Controls.Add(this.cb_s_funkcjonalnosc_program);
            this.gb_funkcjonalnosc.Controls.Add(this.cb_e_funkcjonalnosc_typ_funkcji);
            this.gb_funkcjonalnosc.Controls.Add(this.cb_s_funkcjonalnosc_typ_funkcji);
            this.gb_funkcjonalnosc.Controls.Add(this.b_funkcjonalnosc_edytuj);
            this.gb_funkcjonalnosc.Controls.Add(this.b_funkcjonalnosc_anuluj);
            this.gb_funkcjonalnosc.Controls.Add(this.b_funkcjonalnosc_usun);
            this.gb_funkcjonalnosc.Controls.Add(this.b_funkcjonalnosc_zatwierdz);
            this.gb_funkcjonalnosc.Controls.Add(this.b_funkcjonalnosc_dodaj);
            this.gb_funkcjonalnosc.Controls.Add(this.dgv_funkcjonalnosci);
            this.gb_funkcjonalnosc.Controls.Add(this.l_funkcjonalnosc_szukaj);
            this.gb_funkcjonalnosc.Controls.Add(this.tb_s_funkcjonalnosc_nazwa);
            this.gb_funkcjonalnosc.Controls.Add(this.tb_e_funkcjonalnosc_id);
            this.gb_funkcjonalnosc.Controls.Add(this.tb_s_funkcjonalnosc_id);
            this.gb_funkcjonalnosc.Controls.Add(this.tb_e_funkcjonalnosc_nazwa);
            this.gb_funkcjonalnosc.Controls.Add(this.l_funkcjonalnosc_funkcjonalnosci);
            this.gb_funkcjonalnosc.Controls.Add(this.l_funkcjonalnosc_id);
            this.gb_funkcjonalnosc.Location = new System.Drawing.Point(429, 473);
            this.gb_funkcjonalnosc.Name = "gb_funkcjonalnosc";
            this.gb_funkcjonalnosc.Size = new System.Drawing.Size(717, 257);
            this.gb_funkcjonalnosc.TabIndex = 26;
            this.gb_funkcjonalnosc.TabStop = false;
            this.gb_funkcjonalnosc.Text = "Funkcjonalności";
            // 
            // l_program
            // 
            this.l_program.AutoSize = true;
            this.l_program.Location = new System.Drawing.Point(527, 15);
            this.l_program.Name = "l_program";
            this.l_program.Size = new System.Drawing.Size(46, 13);
            this.l_program.TabIndex = 30;
            this.l_program.Text = "Program";
            // 
            // l_typ_funkcji
            // 
            this.l_typ_funkcji.AutoSize = true;
            this.l_typ_funkcji.Location = new System.Drawing.Point(400, 15);
            this.l_typ_funkcji.Name = "l_typ_funkcji";
            this.l_typ_funkcji.Size = new System.Drawing.Size(59, 13);
            this.l_typ_funkcji.TabIndex = 29;
            this.l_typ_funkcji.Text = "Typ funkcji";
            // 
            // cb_e_funkcjonalnosc_program
            // 
            this.cb_e_funkcjonalnosc_program.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_e_funkcjonalnosc_program.Enabled = false;
            this.cb_e_funkcjonalnosc_program.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_e_funkcjonalnosc_program.FormattingEnabled = true;
            this.cb_e_funkcjonalnosc_program.Location = new System.Drawing.Point(530, 194);
            this.cb_e_funkcjonalnosc_program.Name = "cb_e_funkcjonalnosc_program";
            this.cb_e_funkcjonalnosc_program.Size = new System.Drawing.Size(101, 21);
            this.cb_e_funkcjonalnosc_program.TabIndex = 28;
            // 
            // cb_s_funkcjonalnosc_program
            // 
            this.cb_s_funkcjonalnosc_program.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_s_funkcjonalnosc_program.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_s_funkcjonalnosc_program.FormattingEnabled = true;
            this.cb_s_funkcjonalnosc_program.Location = new System.Drawing.Point(530, 31);
            this.cb_s_funkcjonalnosc_program.Name = "cb_s_funkcjonalnosc_program";
            this.cb_s_funkcjonalnosc_program.Size = new System.Drawing.Size(101, 21);
            this.cb_s_funkcjonalnosc_program.TabIndex = 27;
            this.cb_s_funkcjonalnosc_program.SelectedIndexChanged += new System.EventHandler(this.cb_s_funkcjonalnosc_program_SelectedIndexChanged);
            // 
            // cb_e_funkcjonalnosc_typ_funkcji
            // 
            this.cb_e_funkcjonalnosc_typ_funkcji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_e_funkcjonalnosc_typ_funkcji.Enabled = false;
            this.cb_e_funkcjonalnosc_typ_funkcji.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_e_funkcjonalnosc_typ_funkcji.FormattingEnabled = true;
            this.cb_e_funkcjonalnosc_typ_funkcji.Location = new System.Drawing.Point(403, 194);
            this.cb_e_funkcjonalnosc_typ_funkcji.Name = "cb_e_funkcjonalnosc_typ_funkcji";
            this.cb_e_funkcjonalnosc_typ_funkcji.Size = new System.Drawing.Size(121, 21);
            this.cb_e_funkcjonalnosc_typ_funkcji.TabIndex = 26;
            // 
            // cb_s_funkcjonalnosc_typ_funkcji
            // 
            this.cb_s_funkcjonalnosc_typ_funkcji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_s_funkcjonalnosc_typ_funkcji.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_s_funkcjonalnosc_typ_funkcji.FormattingEnabled = true;
            this.cb_s_funkcjonalnosc_typ_funkcji.Location = new System.Drawing.Point(403, 30);
            this.cb_s_funkcjonalnosc_typ_funkcji.Name = "cb_s_funkcjonalnosc_typ_funkcji";
            this.cb_s_funkcjonalnosc_typ_funkcji.Size = new System.Drawing.Size(121, 21);
            this.cb_s_funkcjonalnosc_typ_funkcji.TabIndex = 25;
            this.cb_s_funkcjonalnosc_typ_funkcji.SelectedIndexChanged += new System.EventHandler(this.cb_s_funkcjonalnosc_typ_funkcji_SelectedIndexChanged);
            // 
            // b_funkcjonalnosc_edytuj
            // 
            this.b_funkcjonalnosc_edytuj.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_funkcjonalnosc_edytuj.Location = new System.Drawing.Point(6, 93);
            this.b_funkcjonalnosc_edytuj.Name = "b_funkcjonalnosc_edytuj";
            this.b_funkcjonalnosc_edytuj.Size = new System.Drawing.Size(30, 30);
            this.b_funkcjonalnosc_edytuj.TabIndex = 18;
            this.b_funkcjonalnosc_edytuj.Text = "I";
            this.b_funkcjonalnosc_edytuj.UseVisualStyleBackColor = true;
            this.b_funkcjonalnosc_edytuj.Click += new System.EventHandler(this.b_funkcjonalnosc_edytuj_Click);
            // 
            // b_funkcjonalnosc_anuluj
            // 
            this.b_funkcjonalnosc_anuluj.Enabled = false;
            this.b_funkcjonalnosc_anuluj.Location = new System.Drawing.Point(639, 221);
            this.b_funkcjonalnosc_anuluj.Name = "b_funkcjonalnosc_anuluj";
            this.b_funkcjonalnosc_anuluj.Size = new System.Drawing.Size(72, 28);
            this.b_funkcjonalnosc_anuluj.TabIndex = 17;
            this.b_funkcjonalnosc_anuluj.Text = "Anuluj";
            this.b_funkcjonalnosc_anuluj.UseVisualStyleBackColor = true;
            this.b_funkcjonalnosc_anuluj.Click += new System.EventHandler(this.b_funkcjonalnosc_anuluj_Click);
            // 
            // b_funkcjonalnosc_usun
            // 
            this.b_funkcjonalnosc_usun.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_funkcjonalnosc_usun.Location = new System.Drawing.Point(6, 129);
            this.b_funkcjonalnosc_usun.Name = "b_funkcjonalnosc_usun";
            this.b_funkcjonalnosc_usun.Size = new System.Drawing.Size(30, 30);
            this.b_funkcjonalnosc_usun.TabIndex = 17;
            this.b_funkcjonalnosc_usun.Text = "-";
            this.b_funkcjonalnosc_usun.UseVisualStyleBackColor = true;
            this.b_funkcjonalnosc_usun.Click += new System.EventHandler(this.b_funkcjonalnosc_usun_Click);
            // 
            // b_funkcjonalnosc_zatwierdz
            // 
            this.b_funkcjonalnosc_zatwierdz.Enabled = false;
            this.b_funkcjonalnosc_zatwierdz.Location = new System.Drawing.Point(562, 221);
            this.b_funkcjonalnosc_zatwierdz.Name = "b_funkcjonalnosc_zatwierdz";
            this.b_funkcjonalnosc_zatwierdz.Size = new System.Drawing.Size(71, 28);
            this.b_funkcjonalnosc_zatwierdz.TabIndex = 16;
            this.b_funkcjonalnosc_zatwierdz.Text = "Zatwierdź";
            this.b_funkcjonalnosc_zatwierdz.UseVisualStyleBackColor = true;
            this.b_funkcjonalnosc_zatwierdz.Click += new System.EventHandler(this.b_funkcjonalnosc_zatwierdz_Click);
            // 
            // b_funkcjonalnosc_dodaj
            // 
            this.b_funkcjonalnosc_dodaj.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_funkcjonalnosc_dodaj.Location = new System.Drawing.Point(6, 57);
            this.b_funkcjonalnosc_dodaj.Name = "b_funkcjonalnosc_dodaj";
            this.b_funkcjonalnosc_dodaj.Size = new System.Drawing.Size(30, 30);
            this.b_funkcjonalnosc_dodaj.TabIndex = 16;
            this.b_funkcjonalnosc_dodaj.Text = "+";
            this.b_funkcjonalnosc_dodaj.UseVisualStyleBackColor = true;
            this.b_funkcjonalnosc_dodaj.Click += new System.EventHandler(this.b_funkcjonalnosc_dodaj_Click);
            // 
            // dgv_funkcjonalnosci
            // 
            this.dgv_funkcjonalnosci.AllowUserToAddRows = false;
            this.dgv_funkcjonalnosci.AllowUserToDeleteRows = false;
            this.dgv_funkcjonalnosci.AllowUserToOrderColumns = true;
            this.dgv_funkcjonalnosci.AllowUserToResizeRows = false;
            this.dgv_funkcjonalnosci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_funkcjonalnosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funkcjonalnosci.Location = new System.Drawing.Point(54, 57);
            this.dgv_funkcjonalnosci.MultiSelect = false;
            this.dgv_funkcjonalnosci.Name = "dgv_funkcjonalnosci";
            this.dgv_funkcjonalnosci.ReadOnly = true;
            this.dgv_funkcjonalnosci.RowHeadersVisible = false;
            this.dgv_funkcjonalnosci.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_funkcjonalnosci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_funkcjonalnosci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_funkcjonalnosci.Size = new System.Drawing.Size(657, 132);
            this.dgv_funkcjonalnosci.TabIndex = 24;
            this.dgv_funkcjonalnosci.SelectionChanged += new System.EventHandler(this.dgv_funkcjonalnosci_CellMouseClick);
            // 
            // l_funkcjonalnosc_szukaj
            // 
            this.l_funkcjonalnosc_szukaj.AutoSize = true;
            this.l_funkcjonalnosc_szukaj.Location = new System.Drawing.Point(6, 34);
            this.l_funkcjonalnosc_szukaj.Name = "l_funkcjonalnosc_szukaj";
            this.l_funkcjonalnosc_szukaj.Size = new System.Drawing.Size(42, 13);
            this.l_funkcjonalnosc_szukaj.TabIndex = 13;
            this.l_funkcjonalnosc_szukaj.Text = "Szukaj:";
            // 
            // tb_s_funkcjonalnosc_nazwa
            // 
            this.tb_s_funkcjonalnosc_nazwa.Location = new System.Drawing.Point(54, 31);
            this.tb_s_funkcjonalnosc_nazwa.Name = "tb_s_funkcjonalnosc_nazwa";
            this.tb_s_funkcjonalnosc_nazwa.Size = new System.Drawing.Size(343, 20);
            this.tb_s_funkcjonalnosc_nazwa.TabIndex = 14;
            this.tb_s_funkcjonalnosc_nazwa.TextChanged += new System.EventHandler(this.tb_s_funkcjonalnosc_nazwa_TextChanged);
            // 
            // tb_e_funkcjonalnosc_id
            // 
            this.tb_e_funkcjonalnosc_id.Enabled = false;
            this.tb_e_funkcjonalnosc_id.Location = new System.Drawing.Point(637, 195);
            this.tb_e_funkcjonalnosc_id.Name = "tb_e_funkcjonalnosc_id";
            this.tb_e_funkcjonalnosc_id.Size = new System.Drawing.Size(74, 20);
            this.tb_e_funkcjonalnosc_id.TabIndex = 20;
            // 
            // tb_s_funkcjonalnosc_id
            // 
            this.tb_s_funkcjonalnosc_id.Location = new System.Drawing.Point(637, 31);
            this.tb_s_funkcjonalnosc_id.Name = "tb_s_funkcjonalnosc_id";
            this.tb_s_funkcjonalnosc_id.Size = new System.Drawing.Size(74, 20);
            this.tb_s_funkcjonalnosc_id.TabIndex = 15;
            this.tb_s_funkcjonalnosc_id.TextChanged += new System.EventHandler(this.tb_s_funkcjonalnosc_id_TextChanged);
            // 
            // tb_e_funkcjonalnosc_nazwa
            // 
            this.tb_e_funkcjonalnosc_nazwa.Enabled = false;
            this.tb_e_funkcjonalnosc_nazwa.Location = new System.Drawing.Point(54, 195);
            this.tb_e_funkcjonalnosc_nazwa.Name = "tb_e_funkcjonalnosc_nazwa";
            this.tb_e_funkcjonalnosc_nazwa.Size = new System.Drawing.Size(343, 20);
            this.tb_e_funkcjonalnosc_nazwa.TabIndex = 19;
            // 
            // l_funkcjonalnosc_funkcjonalnosci
            // 
            this.l_funkcjonalnosc_funkcjonalnosci.AutoSize = true;
            this.l_funkcjonalnosc_funkcjonalnosci.Location = new System.Drawing.Point(51, 15);
            this.l_funkcjonalnosc_funkcjonalnosci.Name = "l_funkcjonalnosc_funkcjonalnosci";
            this.l_funkcjonalnosc_funkcjonalnosci.Size = new System.Drawing.Size(40, 13);
            this.l_funkcjonalnosc_funkcjonalnosci.TabIndex = 16;
            this.l_funkcjonalnosc_funkcjonalnosci.Text = "Nazwa";
            // 
            // l_funkcjonalnosc_id
            // 
            this.l_funkcjonalnosc_id.AutoSize = true;
            this.l_funkcjonalnosc_id.Location = new System.Drawing.Point(634, 15);
            this.l_funkcjonalnosc_id.Name = "l_funkcjonalnosc_id";
            this.l_funkcjonalnosc_id.Size = new System.Drawing.Size(33, 13);
            this.l_funkcjonalnosc_id.TabIndex = 17;
            this.l_funkcjonalnosc_id.Text = "Nr. Id";
            // 
            // gb_programy
            // 
            this.gb_programy.BackColor = System.Drawing.Color.Transparent;
            this.gb_programy.Controls.Add(this.b_program_edytuj);
            this.gb_programy.Controls.Add(this.b_program_anuluj);
            this.gb_programy.Controls.Add(this.b_program_usun);
            this.gb_programy.Controls.Add(this.b_program_zatwierdz);
            this.gb_programy.Controls.Add(this.b_program_dodaj);
            this.gb_programy.Controls.Add(this.dgv_programy);
            this.gb_programy.Controls.Add(this.l_program_szukaj);
            this.gb_programy.Controls.Add(this.tb_s_program_nazwa);
            this.gb_programy.Controls.Add(this.tb_e_program_id);
            this.gb_programy.Controls.Add(this.tb_s_program_id);
            this.gb_programy.Controls.Add(this.tb_e_program_nazwa);
            this.gb_programy.Controls.Add(this.l_program_nazwa);
            this.gb_programy.Controls.Add(this.l_program_id);
            this.gb_programy.Location = new System.Drawing.Point(429, 240);
            this.gb_programy.Name = "gb_programy";
            this.gb_programy.Size = new System.Drawing.Size(717, 227);
            this.gb_programy.TabIndex = 25;
            this.gb_programy.TabStop = false;
            this.gb_programy.Text = "Programy";
            // 
            // b_program_edytuj
            // 
            this.b_program_edytuj.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_program_edytuj.Location = new System.Drawing.Point(6, 93);
            this.b_program_edytuj.Name = "b_program_edytuj";
            this.b_program_edytuj.Size = new System.Drawing.Size(30, 30);
            this.b_program_edytuj.TabIndex = 18;
            this.b_program_edytuj.Text = "I";
            this.b_program_edytuj.UseVisualStyleBackColor = true;
            this.b_program_edytuj.Click += new System.EventHandler(this.b_program_edytuj_Click);
            // 
            // b_program_anuluj
            // 
            this.b_program_anuluj.Enabled = false;
            this.b_program_anuluj.Location = new System.Drawing.Point(639, 191);
            this.b_program_anuluj.Name = "b_program_anuluj";
            this.b_program_anuluj.Size = new System.Drawing.Size(72, 28);
            this.b_program_anuluj.TabIndex = 17;
            this.b_program_anuluj.Text = "Anuluj";
            this.b_program_anuluj.UseVisualStyleBackColor = true;
            this.b_program_anuluj.Click += new System.EventHandler(this.b_program_anuluj_Click);
            // 
            // b_program_usun
            // 
            this.b_program_usun.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_program_usun.Location = new System.Drawing.Point(6, 129);
            this.b_program_usun.Name = "b_program_usun";
            this.b_program_usun.Size = new System.Drawing.Size(30, 30);
            this.b_program_usun.TabIndex = 17;
            this.b_program_usun.Text = "-";
            this.b_program_usun.UseVisualStyleBackColor = true;
            this.b_program_usun.Click += new System.EventHandler(this.b_program_usun_Click);
            // 
            // b_program_zatwierdz
            // 
            this.b_program_zatwierdz.Enabled = false;
            this.b_program_zatwierdz.Location = new System.Drawing.Point(562, 191);
            this.b_program_zatwierdz.Name = "b_program_zatwierdz";
            this.b_program_zatwierdz.Size = new System.Drawing.Size(71, 28);
            this.b_program_zatwierdz.TabIndex = 16;
            this.b_program_zatwierdz.Text = "Zatwierdź";
            this.b_program_zatwierdz.UseVisualStyleBackColor = true;
            this.b_program_zatwierdz.Click += new System.EventHandler(this.b_program_zatwierdz_Click);
            // 
            // b_program_dodaj
            // 
            this.b_program_dodaj.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_program_dodaj.Location = new System.Drawing.Point(6, 57);
            this.b_program_dodaj.Name = "b_program_dodaj";
            this.b_program_dodaj.Size = new System.Drawing.Size(30, 30);
            this.b_program_dodaj.TabIndex = 16;
            this.b_program_dodaj.Text = "+";
            this.b_program_dodaj.UseVisualStyleBackColor = true;
            this.b_program_dodaj.Click += new System.EventHandler(this.b_program_dodaj_Click);
            // 
            // dgv_programy
            // 
            this.dgv_programy.AllowUserToAddRows = false;
            this.dgv_programy.AllowUserToDeleteRows = false;
            this.dgv_programy.AllowUserToResizeRows = false;
            this.dgv_programy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_programy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_programy.Location = new System.Drawing.Point(54, 57);
            this.dgv_programy.MultiSelect = false;
            this.dgv_programy.Name = "dgv_programy";
            this.dgv_programy.ReadOnly = true;
            this.dgv_programy.RowHeadersVisible = false;
            this.dgv_programy.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_programy.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_programy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_programy.Size = new System.Drawing.Size(657, 102);
            this.dgv_programy.TabIndex = 24;
            this.dgv_programy.SelectionChanged += new System.EventHandler(this.dgv_programy_CellMouseClick);
            // 
            // l_program_szukaj
            // 
            this.l_program_szukaj.AutoSize = true;
            this.l_program_szukaj.Location = new System.Drawing.Point(6, 34);
            this.l_program_szukaj.Name = "l_program_szukaj";
            this.l_program_szukaj.Size = new System.Drawing.Size(42, 13);
            this.l_program_szukaj.TabIndex = 13;
            this.l_program_szukaj.Text = "Szukaj:";
            // 
            // tb_s_program_nazwa
            // 
            this.tb_s_program_nazwa.Location = new System.Drawing.Point(54, 31);
            this.tb_s_program_nazwa.Name = "tb_s_program_nazwa";
            this.tb_s_program_nazwa.Size = new System.Drawing.Size(577, 20);
            this.tb_s_program_nazwa.TabIndex = 14;
            this.tb_s_program_nazwa.TextChanged += new System.EventHandler(this.tb_s_program_nazwa_TextChanged);
            // 
            // tb_e_program_id
            // 
            this.tb_e_program_id.Enabled = false;
            this.tb_e_program_id.Location = new System.Drawing.Point(637, 165);
            this.tb_e_program_id.Name = "tb_e_program_id";
            this.tb_e_program_id.Size = new System.Drawing.Size(74, 20);
            this.tb_e_program_id.TabIndex = 20;
            // 
            // tb_s_program_id
            // 
            this.tb_s_program_id.Location = new System.Drawing.Point(637, 31);
            this.tb_s_program_id.Name = "tb_s_program_id";
            this.tb_s_program_id.Size = new System.Drawing.Size(74, 20);
            this.tb_s_program_id.TabIndex = 15;
            this.tb_s_program_id.TextChanged += new System.EventHandler(this.tb_s_program_id_TextChanged);
            // 
            // tb_e_program_nazwa
            // 
            this.tb_e_program_nazwa.Enabled = false;
            this.tb_e_program_nazwa.Location = new System.Drawing.Point(54, 165);
            this.tb_e_program_nazwa.Name = "tb_e_program_nazwa";
            this.tb_e_program_nazwa.Size = new System.Drawing.Size(577, 20);
            this.tb_e_program_nazwa.TabIndex = 19;
            // 
            // l_program_nazwa
            // 
            this.l_program_nazwa.AutoSize = true;
            this.l_program_nazwa.Location = new System.Drawing.Point(51, 15);
            this.l_program_nazwa.Name = "l_program_nazwa";
            this.l_program_nazwa.Size = new System.Drawing.Size(40, 13);
            this.l_program_nazwa.TabIndex = 16;
            this.l_program_nazwa.Text = "Nazwa";
            // 
            // l_program_id
            // 
            this.l_program_id.AutoSize = true;
            this.l_program_id.Location = new System.Drawing.Point(634, 15);
            this.l_program_id.Name = "l_program_id";
            this.l_program_id.Size = new System.Drawing.Size(33, 13);
            this.l_program_id.TabIndex = 17;
            this.l_program_id.Text = "Nr. Id";
            // 
            // gb_klienci
            // 
            this.gb_klienci.BackColor = System.Drawing.Color.Transparent;
            this.gb_klienci.Controls.Add(this.b_klient_edytuj);
            this.gb_klienci.Controls.Add(this.b_klient_anuluj);
            this.gb_klienci.Controls.Add(this.b_klient_usun);
            this.gb_klienci.Controls.Add(this.b_klient_zatwierdz);
            this.gb_klienci.Controls.Add(this.b_klient_dodaj);
            this.gb_klienci.Controls.Add(this.dgv_klienci);
            this.gb_klienci.Controls.Add(this.l_klienci_szukaj);
            this.gb_klienci.Controls.Add(this.tb_s_klient_nazwa);
            this.gb_klienci.Controls.Add(this.tb_e_klient_id);
            this.gb_klienci.Controls.Add(this.tb_s_klient_id);
            this.gb_klienci.Controls.Add(this.tb_e_klient_nazwa);
            this.gb_klienci.Controls.Add(this.l_klient_nazwa);
            this.gb_klienci.Controls.Add(this.l_klient_id);
            this.gb_klienci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_klienci.Location = new System.Drawing.Point(429, 6);
            this.gb_klienci.Name = "gb_klienci";
            this.gb_klienci.Size = new System.Drawing.Size(717, 228);
            this.gb_klienci.TabIndex = 2;
            this.gb_klienci.TabStop = false;
            this.gb_klienci.Text = "Klienci";
            // 
            // b_klient_edytuj
            // 
            this.b_klient_edytuj.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_klient_edytuj.Location = new System.Drawing.Point(6, 93);
            this.b_klient_edytuj.Name = "b_klient_edytuj";
            this.b_klient_edytuj.Size = new System.Drawing.Size(30, 30);
            this.b_klient_edytuj.TabIndex = 18;
            this.b_klient_edytuj.Text = "I";
            this.b_klient_edytuj.UseVisualStyleBackColor = true;
            this.b_klient_edytuj.Click += new System.EventHandler(this.b_klient_edytuj_Click);
            // 
            // b_klient_anuluj
            // 
            this.b_klient_anuluj.Enabled = false;
            this.b_klient_anuluj.Location = new System.Drawing.Point(639, 191);
            this.b_klient_anuluj.Name = "b_klient_anuluj";
            this.b_klient_anuluj.Size = new System.Drawing.Size(72, 28);
            this.b_klient_anuluj.TabIndex = 17;
            this.b_klient_anuluj.Text = "Anuluj";
            this.b_klient_anuluj.UseVisualStyleBackColor = true;
            this.b_klient_anuluj.Click += new System.EventHandler(this.b_klient_anuluj_Click);
            // 
            // b_klient_usun
            // 
            this.b_klient_usun.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_klient_usun.Location = new System.Drawing.Point(6, 129);
            this.b_klient_usun.Name = "b_klient_usun";
            this.b_klient_usun.Size = new System.Drawing.Size(30, 30);
            this.b_klient_usun.TabIndex = 17;
            this.b_klient_usun.Text = "-";
            this.b_klient_usun.UseVisualStyleBackColor = true;
            this.b_klient_usun.Click += new System.EventHandler(this.b_klient_usun_Click);
            // 
            // b_klient_zatwierdz
            // 
            this.b_klient_zatwierdz.Enabled = false;
            this.b_klient_zatwierdz.Location = new System.Drawing.Point(562, 191);
            this.b_klient_zatwierdz.Name = "b_klient_zatwierdz";
            this.b_klient_zatwierdz.Size = new System.Drawing.Size(71, 28);
            this.b_klient_zatwierdz.TabIndex = 16;
            this.b_klient_zatwierdz.Text = "Zatwierdź";
            this.b_klient_zatwierdz.UseVisualStyleBackColor = true;
            this.b_klient_zatwierdz.Click += new System.EventHandler(this.b_klient_zatwierdz_Click);
            // 
            // b_klient_dodaj
            // 
            this.b_klient_dodaj.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_klient_dodaj.Location = new System.Drawing.Point(6, 57);
            this.b_klient_dodaj.Name = "b_klient_dodaj";
            this.b_klient_dodaj.Size = new System.Drawing.Size(30, 30);
            this.b_klient_dodaj.TabIndex = 16;
            this.b_klient_dodaj.Text = "+";
            this.b_klient_dodaj.UseVisualStyleBackColor = true;
            this.b_klient_dodaj.Click += new System.EventHandler(this.b_klient_dodaj_Click);
            // 
            // dgv_klienci
            // 
            this.dgv_klienci.AllowUserToAddRows = false;
            this.dgv_klienci.AllowUserToDeleteRows = false;
            this.dgv_klienci.AllowUserToResizeRows = false;
            this.dgv_klienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_klienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klienci.Location = new System.Drawing.Point(54, 57);
            this.dgv_klienci.MultiSelect = false;
            this.dgv_klienci.Name = "dgv_klienci";
            this.dgv_klienci.ReadOnly = true;
            this.dgv_klienci.RowHeadersVisible = false;
            this.dgv_klienci.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_klienci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_klienci.Size = new System.Drawing.Size(657, 102);
            this.dgv_klienci.TabIndex = 24;
            this.dgv_klienci.SelectionChanged += new System.EventHandler(this.dgv_klienci_CellMouseClick);
            // 
            // l_klienci_szukaj
            // 
            this.l_klienci_szukaj.AutoSize = true;
            this.l_klienci_szukaj.Location = new System.Drawing.Point(6, 34);
            this.l_klienci_szukaj.Name = "l_klienci_szukaj";
            this.l_klienci_szukaj.Size = new System.Drawing.Size(42, 13);
            this.l_klienci_szukaj.TabIndex = 13;
            this.l_klienci_szukaj.Text = "Szukaj:";
            // 
            // tb_s_klient_nazwa
            // 
            this.tb_s_klient_nazwa.Location = new System.Drawing.Point(54, 31);
            this.tb_s_klient_nazwa.Name = "tb_s_klient_nazwa";
            this.tb_s_klient_nazwa.Size = new System.Drawing.Size(577, 20);
            this.tb_s_klient_nazwa.TabIndex = 14;
            this.tb_s_klient_nazwa.TextChanged += new System.EventHandler(this.tb_s_klient_nazwa_TextChanged);
            // 
            // tb_e_klient_id
            // 
            this.tb_e_klient_id.Enabled = false;
            this.tb_e_klient_id.Location = new System.Drawing.Point(637, 165);
            this.tb_e_klient_id.Name = "tb_e_klient_id";
            this.tb_e_klient_id.Size = new System.Drawing.Size(74, 20);
            this.tb_e_klient_id.TabIndex = 20;
            // 
            // tb_s_klient_id
            // 
            this.tb_s_klient_id.Location = new System.Drawing.Point(637, 31);
            this.tb_s_klient_id.Name = "tb_s_klient_id";
            this.tb_s_klient_id.Size = new System.Drawing.Size(74, 20);
            this.tb_s_klient_id.TabIndex = 15;
            this.tb_s_klient_id.TextChanged += new System.EventHandler(this.tb_s_klient_id_TextChanged);
            // 
            // tb_e_klient_nazwa
            // 
            this.tb_e_klient_nazwa.Enabled = false;
            this.tb_e_klient_nazwa.Location = new System.Drawing.Point(54, 165);
            this.tb_e_klient_nazwa.Name = "tb_e_klient_nazwa";
            this.tb_e_klient_nazwa.Size = new System.Drawing.Size(577, 20);
            this.tb_e_klient_nazwa.TabIndex = 19;
            // 
            // l_klient_nazwa
            // 
            this.l_klient_nazwa.AutoSize = true;
            this.l_klient_nazwa.Location = new System.Drawing.Point(51, 15);
            this.l_klient_nazwa.Name = "l_klient_nazwa";
            this.l_klient_nazwa.Size = new System.Drawing.Size(40, 13);
            this.l_klient_nazwa.TabIndex = 16;
            this.l_klient_nazwa.Text = "Nazwa";
            // 
            // l_klient_id
            // 
            this.l_klient_id.AutoSize = true;
            this.l_klient_id.Location = new System.Drawing.Point(634, 15);
            this.l_klient_id.Name = "l_klient_id";
            this.l_klient_id.Size = new System.Drawing.Size(33, 13);
            this.l_klient_id.TabIndex = 17;
            this.l_klient_id.Text = "Nr. Id";
            // 
            // gb_slowniki
            // 
            this.gb_slowniki.BackColor = System.Drawing.Color.Transparent;
            this.gb_slowniki.Controls.Add(this.dgv_slowniki);
            this.gb_slowniki.Controls.Add(this.b_slowniki_edytuj);
            this.gb_slowniki.Controls.Add(this.b_slowniki_anuluj);
            this.gb_slowniki.Controls.Add(this.b_slowniki_zatwierdz);
            this.gb_slowniki.Controls.Add(this.b_slowniki_usun);
            this.gb_slowniki.Controls.Add(this.b_slowniki_dodaj);
            this.gb_slowniki.Controls.Add(this.tb_e_slowniki_id);
            this.gb_slowniki.Controls.Add(this.tb_e_slowniki_nazwa);
            this.gb_slowniki.Controls.Add(this.l_slownik_id);
            this.gb_slowniki.Controls.Add(this.l_slownik_nazwaelementu);
            this.gb_slowniki.Controls.Add(this.tb_s_slowniki_id);
            this.gb_slowniki.Controls.Add(this.tb_s_slowniki_nazwa);
            this.gb_slowniki.Controls.Add(this.l_slowniki_szukaj);
            this.gb_slowniki.Controls.Add(this.l_slownik);
            this.gb_slowniki.Controls.Add(this.cb_slowniki);
            this.gb_slowniki.Location = new System.Drawing.Point(6, 6);
            this.gb_slowniki.Name = "gb_slowniki";
            this.gb_slowniki.Size = new System.Drawing.Size(417, 461);
            this.gb_slowniki.TabIndex = 1;
            this.gb_slowniki.TabStop = false;
            this.gb_slowniki.Text = "Słowniki";
            // 
            // dgv_slowniki
            // 
            this.dgv_slowniki.AllowUserToAddRows = false;
            this.dgv_slowniki.AllowUserToDeleteRows = false;
            this.dgv_slowniki.AllowUserToResizeRows = false;
            this.dgv_slowniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_slowniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_slowniki.Location = new System.Drawing.Point(52, 102);
            this.dgv_slowniki.MultiSelect = false;
            this.dgv_slowniki.Name = "dgv_slowniki";
            this.dgv_slowniki.ReadOnly = true;
            this.dgv_slowniki.RowHeadersVisible = false;
            this.dgv_slowniki.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_slowniki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_slowniki.Size = new System.Drawing.Size(359, 291);
            this.dgv_slowniki.TabIndex = 15;
            this.dgv_slowniki.SelectionChanged += new System.EventHandler(this.Dgv_slowniki_CellMouseClick);
            // 
            // b_slowniki_edytuj
            // 
            this.b_slowniki_edytuj.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_slowniki_edytuj.Location = new System.Drawing.Point(6, 138);
            this.b_slowniki_edytuj.Name = "b_slowniki_edytuj";
            this.b_slowniki_edytuj.Size = new System.Drawing.Size(30, 30);
            this.b_slowniki_edytuj.TabIndex = 14;
            this.b_slowniki_edytuj.Text = "I";
            this.b_slowniki_edytuj.UseVisualStyleBackColor = true;
            this.b_slowniki_edytuj.Click += new System.EventHandler(this.b_slowniki_edytuj_Click);
            // 
            // b_slowniki_anuluj
            // 
            this.b_slowniki_anuluj.Enabled = false;
            this.b_slowniki_anuluj.Location = new System.Drawing.Point(339, 425);
            this.b_slowniki_anuluj.Name = "b_slowniki_anuluj";
            this.b_slowniki_anuluj.Size = new System.Drawing.Size(72, 28);
            this.b_slowniki_anuluj.TabIndex = 13;
            this.b_slowniki_anuluj.Text = "Anuluj";
            this.b_slowniki_anuluj.UseVisualStyleBackColor = true;
            this.b_slowniki_anuluj.Click += new System.EventHandler(this.b_slowniki_anuluj_Click);
            // 
            // b_slowniki_zatwierdz
            // 
            this.b_slowniki_zatwierdz.Enabled = false;
            this.b_slowniki_zatwierdz.Location = new System.Drawing.Point(262, 425);
            this.b_slowniki_zatwierdz.Name = "b_slowniki_zatwierdz";
            this.b_slowniki_zatwierdz.Size = new System.Drawing.Size(71, 28);
            this.b_slowniki_zatwierdz.TabIndex = 12;
            this.b_slowniki_zatwierdz.Text = "Zatwierdź";
            this.b_slowniki_zatwierdz.UseVisualStyleBackColor = true;
            this.b_slowniki_zatwierdz.Click += new System.EventHandler(this.b_slowniki_zatwierdz_Click);
            // 
            // b_slowniki_usun
            // 
            this.b_slowniki_usun.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_slowniki_usun.Location = new System.Drawing.Point(6, 174);
            this.b_slowniki_usun.Name = "b_slowniki_usun";
            this.b_slowniki_usun.Size = new System.Drawing.Size(30, 30);
            this.b_slowniki_usun.TabIndex = 11;
            this.b_slowniki_usun.Text = "-";
            this.b_slowniki_usun.UseVisualStyleBackColor = true;
            this.b_slowniki_usun.Click += new System.EventHandler(this.b_slowniki_usun_Click);
            // 
            // b_slowniki_dodaj
            // 
            this.b_slowniki_dodaj.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.b_slowniki_dodaj.Location = new System.Drawing.Point(6, 102);
            this.b_slowniki_dodaj.Name = "b_slowniki_dodaj";
            this.b_slowniki_dodaj.Size = new System.Drawing.Size(30, 30);
            this.b_slowniki_dodaj.TabIndex = 10;
            this.b_slowniki_dodaj.Text = "+";
            this.b_slowniki_dodaj.UseVisualStyleBackColor = true;
            this.b_slowniki_dodaj.Click += new System.EventHandler(this.b_slowniki_dodaj_Click);
            // 
            // tb_e_slowniki_id
            // 
            this.tb_e_slowniki_id.Enabled = false;
            this.tb_e_slowniki_id.Location = new System.Drawing.Point(337, 399);
            this.tb_e_slowniki_id.Name = "tb_e_slowniki_id";
            this.tb_e_slowniki_id.Size = new System.Drawing.Size(74, 20);
            this.tb_e_slowniki_id.TabIndex = 9;
            // 
            // tb_e_slowniki_nazwa
            // 
            this.tb_e_slowniki_nazwa.Enabled = false;
            this.tb_e_slowniki_nazwa.Location = new System.Drawing.Point(52, 399);
            this.tb_e_slowniki_nazwa.Name = "tb_e_slowniki_nazwa";
            this.tb_e_slowniki_nazwa.Size = new System.Drawing.Size(279, 20);
            this.tb_e_slowniki_nazwa.TabIndex = 8;
            // 
            // l_slownik_id
            // 
            this.l_slownik_id.AutoSize = true;
            this.l_slownik_id.Location = new System.Drawing.Point(334, 60);
            this.l_slownik_id.Name = "l_slownik_id";
            this.l_slownik_id.Size = new System.Drawing.Size(33, 13);
            this.l_slownik_id.TabIndex = 6;
            this.l_slownik_id.Text = "Nr. Id";
            // 
            // l_slownik_nazwaelementu
            // 
            this.l_slownik_nazwaelementu.AutoSize = true;
            this.l_slownik_nazwaelementu.Location = new System.Drawing.Point(49, 60);
            this.l_slownik_nazwaelementu.Name = "l_slownik_nazwaelementu";
            this.l_slownik_nazwaelementu.Size = new System.Drawing.Size(86, 13);
            this.l_slownik_nazwaelementu.TabIndex = 5;
            this.l_slownik_nazwaelementu.Text = "Nazwa elementu";
            // 
            // tb_s_slowniki_id
            // 
            this.tb_s_slowniki_id.Location = new System.Drawing.Point(337, 76);
            this.tb_s_slowniki_id.Name = "tb_s_slowniki_id";
            this.tb_s_slowniki_id.Size = new System.Drawing.Size(74, 20);
            this.tb_s_slowniki_id.TabIndex = 4;
            this.tb_s_slowniki_id.TextChanged += new System.EventHandler(this.tb_s_slowniki_id_TextChanged);
            // 
            // tb_s_slowniki_nazwa
            // 
            this.tb_s_slowniki_nazwa.Location = new System.Drawing.Point(52, 76);
            this.tb_s_slowniki_nazwa.Name = "tb_s_slowniki_nazwa";
            this.tb_s_slowniki_nazwa.Size = new System.Drawing.Size(279, 20);
            this.tb_s_slowniki_nazwa.TabIndex = 3;
            this.tb_s_slowniki_nazwa.TextChanged += new System.EventHandler(this.tb_s_slowniki_nazwa_TextChanged);
            // 
            // l_slowniki_szukaj
            // 
            this.l_slowniki_szukaj.AutoSize = true;
            this.l_slowniki_szukaj.Location = new System.Drawing.Point(6, 79);
            this.l_slowniki_szukaj.Name = "l_slowniki_szukaj";
            this.l_slowniki_szukaj.Size = new System.Drawing.Size(42, 13);
            this.l_slowniki_szukaj.TabIndex = 2;
            this.l_slowniki_szukaj.Text = "Szukaj:";
            // 
            // l_slownik
            // 
            this.l_slownik.AutoSize = true;
            this.l_slownik.Location = new System.Drawing.Point(6, 22);
            this.l_slownik.Name = "l_slownik";
            this.l_slownik.Size = new System.Drawing.Size(47, 13);
            this.l_slownik.TabIndex = 1;
            this.l_slownik.Text = "Slownik:";
            // 
            // cb_slowniki
            // 
            this.cb_slowniki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_slowniki.FormattingEnabled = true;
            this.cb_slowniki.Location = new System.Drawing.Point(59, 19);
            this.cb_slowniki.Name = "cb_slowniki";
            this.cb_slowniki.Size = new System.Drawing.Size(352, 21);
            this.cb_slowniki.TabIndex = 0;
            this.cb_slowniki.SelectedIndexChanged += new System.EventHandler(this.cb_slowniki_SelectedIndexChanged);
            // 
            // ms_menu
            // 
            this.ms_menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ms_menu.GripMargin = new System.Windows.Forms.Padding(0);
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Padding = new System.Windows.Forms.Padding(0);
            this.ms_menu.Size = new System.Drawing.Size(1184, 24);
            this.ms_menu.TabIndex = 11;
            this.ms_menu.Text = "menuStrip1";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.AccessibleName = "";
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.połączenieZBaząToolStripMenuItem,
            this.zmianaHaslaToolStripMenuItem,
            this.uzytkownicyToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // połączenieZBaząToolStripMenuItem
            // 
            this.połączenieZBaząToolStripMenuItem.Name = "połączenieZBaząToolStripMenuItem";
            this.połączenieZBaząToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.połączenieZBaząToolStripMenuItem.Text = "Połączenie z bazą";
            this.połączenieZBaząToolStripMenuItem.Click += new System.EventHandler(this.połączenieZBaząToolStripMenuItem_Click);
            // 
            // zmianaHaslaToolStripMenuItem
            // 
            this.zmianaHaslaToolStripMenuItem.Enabled = false;
            this.zmianaHaslaToolStripMenuItem.Name = "zmianaHaslaToolStripMenuItem";
            this.zmianaHaslaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zmianaHaslaToolStripMenuItem.Text = "Zmiana hasła";
            this.zmianaHaslaToolStripMenuItem.Click += new System.EventHandler(this.zmianaHaslaToolStripMenuItem_Click);
            // 
            // uzytkownicyToolStripMenuItem
            // 
            this.uzytkownicyToolStripMenuItem.Name = "uzytkownicyToolStripMenuItem";
            this.uzytkownicyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.uzytkownicyToolStripMenuItem.Text = "Użytkownicy";
            this.uzytkownicyToolStripMenuItem.Visible = false;
            this.uzytkownicyToolStripMenuItem.Click += new System.EventHandler(this.uzytkownicyToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radźSobieSamDToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // radźSobieSamDToolStripMenuItem
            // 
            this.radźSobieSamDToolStripMenuItem.Name = "radźSobieSamDToolStripMenuItem";
            this.radźSobieSamDToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.radźSobieSamDToolStripMenuItem.Text = "Radź sobie sam :D";
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Location = new System.Drawing.Point(828, 24);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(40, 13);
            this.l_status.TabIndex = 12;
            this.l_status.Text = "Status:";
            // 
            // l_status_serwer
            // 
            this.l_status_serwer.AutoSize = true;
            this.l_status_serwer.ForeColor = System.Drawing.Color.Red;
            this.l_status_serwer.Location = new System.Drawing.Point(874, 24);
            this.l_status_serwer.Name = "l_status_serwer";
            this.l_status_serwer.Size = new System.Drawing.Size(88, 13);
            this.l_status_serwer.TabIndex = 13;
            this.l_status_serwer.Text = "Brak połączenia.";
            // 
            // l_status_logowanie
            // 
            this.l_status_logowanie.AutoSize = true;
            this.l_status_logowanie.ForeColor = System.Drawing.Color.Red;
            this.l_status_logowanie.Location = new System.Drawing.Point(994, 24);
            this.l_status_logowanie.Name = "l_status_logowanie";
            this.l_status_logowanie.Size = new System.Drawing.Size(88, 13);
            this.l_status_logowanie.TabIndex = 14;
            this.l_status_logowanie.Text = "Nie zalogowlano.";
            // 
            // l_s_klientwpis
            // 
            this.l_s_klientwpis.AutoSize = true;
            this.l_s_klientwpis.Location = new System.Drawing.Point(49, 68);
            this.l_s_klientwpis.Name = "l_s_klientwpis";
            this.l_s_klientwpis.Size = new System.Drawing.Size(36, 13);
            this.l_s_klientwpis.TabIndex = 15;
            this.l_s_klientwpis.Text = "Klient:";
            // 
            // tb_s_klientwpis
            // 
            this.tb_s_klientwpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_s_klientwpis.Location = new System.Drawing.Point(52, 84);
            this.tb_s_klientwpis.Name = "tb_s_klientwpis";
            this.tb_s_klientwpis.Size = new System.Drawing.Size(169, 20);
            this.tb_s_klientwpis.TabIndex = 16;
            this.tb_s_klientwpis.TextChanged += new System.EventHandler(this.tb_s_klientwpis_TextChanged);
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.l_status_logowanie);
            this.Controls.Add(this.l_status_serwer);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.tc_zakladki_okno_glowne);
            this.Controls.Add(this.ms_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms_menu;
            this.MaximizeBox = false;
            this.Name = "OknoGlowne";
            this.Text = "Czyściec";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_wpisy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notatki)).EndInit();
            this.tc_zakladki_okno_glowne.ResumeLayout(false);
            this.tp_wpisy_notki.ResumeLayout(false);
            this.tp_wpisy_notki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s_priorytetnotatka_do)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s_priorytetnotatka_od)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s_priorytetwpis_do)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_s_priorytetwpis_od)).EndInit();
            this.tp_slowniki.ResumeLayout(false);
            this.gb_funkcjonalnosc.ResumeLayout(false);
            this.gb_funkcjonalnosc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funkcjonalnosci)).EndInit();
            this.gb_programy.ResumeLayout(false);
            this.gb_programy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_programy)).EndInit();
            this.gb_klienci.ResumeLayout(false);
            this.gb_klienci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klienci)).EndInit();
            this.gb_slowniki.ResumeLayout(false);
            this.gb_slowniki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_slowniki)).EndInit();
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public System.Windows.Forms.DataGridView dgv_wpisy;
        private System.Windows.Forms.Button b_dodaj_wpis;
        private System.Windows.Forms.Button b_usun_wpis;
        private System.Windows.Forms.Button b_edytuj_wpis;
        public System.Windows.Forms.DataGridView dgv_notatki;
        private System.Windows.Forms.Button b_dodaj_notatke;
        private System.Windows.Forms.Button b_usun_notatke;
        private System.Windows.Forms.Button b_edytuj_notatke;
        public System.Windows.Forms.TabControl tc_zakladki_okno_glowne;
        public System.Windows.Forms.TabPage tp_wpisy_notki;
        public System.Windows.Forms.TabPage tp_slowniki;
        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem połączenieZBaząToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem zmianaHaslaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radźSobieSamDToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_szczegoly_notatki;
        private System.Windows.Forms.TextBox tb_szczegoly_wpisu;
        private System.Windows.Forms.Label l_s_idwpisu;
        private System.Windows.Forms.TextBox tb_s_idwpisu;
        private System.Windows.Forms.Label l_s_priorytetwpisu;
        private System.Windows.Forms.Label l_s_trescwpisu;
        private System.Windows.Forms.TextBox tb_s_trescwpisu;
        private System.Windows.Forms.Label l_s_funkcjawpis;
        private System.Windows.Forms.TextBox tb_s_funkcjawpis;
        private System.Windows.Forms.Label l_s_typzgloszeniawpis;
        private System.Windows.Forms.ComboBox cb_s_typzgloszeniawpis;
        private System.Windows.Forms.Label l_s_stanwpis;
        private System.Windows.Forms.ComboBox cb_s_stanwpis;
        private System.Windows.Forms.Label l_s_autorwpis;
        private System.Windows.Forms.TextBox tb_s_autorwpis;
        private System.Windows.Forms.Label l_s_datawpisu;
        private System.Windows.Forms.DateTimePicker dtp_s_datawpisu;
        private System.Windows.Forms.Label l_s_kiedy_wyzejwpis;
        private System.Windows.Forms.DateTimePicker dtp_s_kiedy_wyzejwpis;
        private System.Windows.Forms.Label l_s_typfunkcjiwpis;
        private System.Windows.Forms.ComboBox cb_s_typfunkcjiwpis;
        private System.Windows.Forms.Label l_s_programwpis;
        private System.Windows.Forms.ComboBox cb_s_programwpis;
        private System.Windows.Forms.Label l_s_autornotatka;
        private System.Windows.Forms.TextBox tb_s_autornotatka;
        private System.Windows.Forms.Label l_s_datanotatka;
        private System.Windows.Forms.DateTimePicker dtp_s_datanotatka;
        private System.Windows.Forms.Label l_s_trescnotatka;
        private System.Windows.Forms.TextBox tb_s_trescnotatka;
        private System.Windows.Forms.Label l_s_idnotatka;
        private System.Windows.Forms.TextBox tb_s_idnotatka;
        private System.Windows.Forms.Label l_s_klientnotatka;
        private System.Windows.Forms.TextBox tb_s_klientnotatka;
        private System.Windows.Forms.Label l_s_oddzwonicnotatka;
        private System.Windows.Forms.ComboBox cb_s_oddzwonicnotatka;
        private System.Windows.Forms.Label l_s_priorytetnotatka;
        private System.Windows.Forms.Label l_s_priorytetnotatka_do;
        private System.Windows.Forms.Label l_s_priorytetnotatka_od;
        private System.Windows.Forms.NumericUpDown nud_s_priorytetnotatka_do;
        private System.Windows.Forms.NumericUpDown nud_s_priorytetnotatka_od;
        private System.Windows.Forms.Label l_s_priorytetwpisu_do;
        private System.Windows.Forms.Label l_s_priorytetwpisu_od;
        private System.Windows.Forms.NumericUpDown nud_s_priorytetwpis_do;
        private System.Windows.Forms.NumericUpDown nud_s_priorytetwpis_od;
        private System.Windows.Forms.GroupBox gb_slowniki;
        private System.Windows.Forms.Label l_slowniki_szukaj;
        private System.Windows.Forms.Label l_slownik;
        private System.Windows.Forms.ComboBox cb_slowniki;
        private System.Windows.Forms.Label l_slownik_id;
        private System.Windows.Forms.Label l_slownik_nazwaelementu;
        private System.Windows.Forms.TextBox tb_s_slowniki_id;
        private System.Windows.Forms.TextBox tb_s_slowniki_nazwa;
        private System.Windows.Forms.Button b_slowniki_zatwierdz;
        private System.Windows.Forms.Button b_slowniki_usun;
        private System.Windows.Forms.Button b_slowniki_dodaj;
        private System.Windows.Forms.TextBox tb_e_slowniki_id;
        private System.Windows.Forms.TextBox tb_e_slowniki_nazwa;
        private System.Windows.Forms.GroupBox gb_klienci;
        private System.Windows.Forms.Label l_klienci_szukaj;
        private System.Windows.Forms.TextBox tb_s_klient_nazwa;
        private System.Windows.Forms.TextBox tb_e_klient_id;
        private System.Windows.Forms.TextBox tb_s_klient_id;
        private System.Windows.Forms.TextBox tb_e_klient_nazwa;
        private System.Windows.Forms.Label l_klient_nazwa;
        private System.Windows.Forms.Label l_klient_id;
        private System.Windows.Forms.Button b_slowniki_edytuj;
        private System.Windows.Forms.Button b_slowniki_anuluj;
        private System.Windows.Forms.DataGridView dgv_klienci;
        private System.Windows.Forms.DataGridView dgv_slowniki;
        private System.Windows.Forms.Button b_klient_edytuj;
        private System.Windows.Forms.Button b_klient_anuluj;
        private System.Windows.Forms.Button b_klient_usun;
        private System.Windows.Forms.Button b_klient_zatwierdz;
        private System.Windows.Forms.Button b_klient_dodaj;
        private System.Windows.Forms.GroupBox gb_programy;
        private System.Windows.Forms.Button b_program_edytuj;
        private System.Windows.Forms.Button b_program_anuluj;
        private System.Windows.Forms.Button b_program_usun;
        private System.Windows.Forms.Button b_program_zatwierdz;
        private System.Windows.Forms.Button b_program_dodaj;
        private System.Windows.Forms.DataGridView dgv_programy;
        private System.Windows.Forms.Label l_program_szukaj;
        private System.Windows.Forms.TextBox tb_s_program_nazwa;
        private System.Windows.Forms.TextBox tb_e_program_id;
        private System.Windows.Forms.TextBox tb_s_program_id;
        private System.Windows.Forms.TextBox tb_e_program_nazwa;
        private System.Windows.Forms.Label l_program_nazwa;
        private System.Windows.Forms.Label l_program_id;
        private System.Windows.Forms.GroupBox gb_funkcjonalnosc;
        private System.Windows.Forms.Button b_funkcjonalnosc_edytuj;
        private System.Windows.Forms.Button b_funkcjonalnosc_anuluj;
        private System.Windows.Forms.Button b_funkcjonalnosc_usun;
        private System.Windows.Forms.Button b_funkcjonalnosc_zatwierdz;
        private System.Windows.Forms.Button b_funkcjonalnosc_dodaj;
        private System.Windows.Forms.DataGridView dgv_funkcjonalnosci;
        private System.Windows.Forms.Label l_funkcjonalnosc_szukaj;
        private System.Windows.Forms.TextBox tb_s_funkcjonalnosc_nazwa;
        private System.Windows.Forms.TextBox tb_e_funkcjonalnosc_id;
        private System.Windows.Forms.TextBox tb_s_funkcjonalnosc_id;
        private System.Windows.Forms.TextBox tb_e_funkcjonalnosc_nazwa;
        private System.Windows.Forms.Label l_funkcjonalnosc_funkcjonalnosci;
        private System.Windows.Forms.Label l_funkcjonalnosc_id;
        private System.Windows.Forms.ComboBox cb_e_funkcjonalnosc_program;
        private System.Windows.Forms.ComboBox cb_s_funkcjonalnosc_program;
        private System.Windows.Forms.ComboBox cb_e_funkcjonalnosc_typ_funkcji;
        private System.Windows.Forms.ComboBox cb_s_funkcjonalnosc_typ_funkcji;
        private System.Windows.Forms.Label l_program;
        private System.Windows.Forms.Label l_typ_funkcji;
        private System.Windows.Forms.Label l_status;
        public System.Windows.Forms.Label l_status_serwer;
        public System.Windows.Forms.Label l_status_logowanie;
        public System.Windows.Forms.ToolStripMenuItem uzytkownicyToolStripMenuItem;
        private System.Windows.Forms.Label l_s_klientwpis;
        private System.Windows.Forms.TextBox tb_s_klientwpis;
    }
}

