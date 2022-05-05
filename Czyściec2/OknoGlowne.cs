using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace Czyściec2
{
    public partial class OknoGlowne : Form
    {
        public SqlConnection polaczenie_do_bazy;
        SqlCommand zapytanie_sql_notatki;
        SqlCommand zapytanie_sql_wpisy;
        SqlDataAdapter adapter_wpisow;
        SqlDataAdapter adapter_notatek;
        DataTable tabela_wpisow;
        DataTable tabela_notatek;
        OknoUstawienPolaczenia okno_ustawien;
        DodawanieNotatki okno_dodawania_notatki;
        DodawanieWpisu okno_dodawania_wpisu;
        OknoLogowania okno_logowania;
        OknoZmianyHasla okno_zmiany_hasla;
        OknoUzytkownicy okno_uzytkonicy;
        public string nazwa_serwera, nazwa_instancji, nazwa_bazy, nazwa_uzytkownika, haslo_sql;
        Color kolor_szukajek_nieaktywnych, kolor_szukajek_aktywnych;
        public int id_uzytkownika;
        public string imie_uzytkownika, nazwisko_uzytkownika, nick;
        public RijndaelManaged moj_aes;

        public void generator_polaczenia_i_zapytan(string polaczenie)
        {
            polaczenie_do_bazy = new SqlConnection(@"" + polaczenie + "");
            
            zapytanie_sql_wpisy = polaczenie_do_bazy.CreateCommand();
            zapytanie_sql_notatki = polaczenie_do_bazy.CreateCommand();
            zapytanie_sql_wpisy.CommandText = "SELECT IdWpisu, DataCzasWpisu, Tresc, PriorytetWpisu, KiedyPrzekazaneWyzej, NazwaFunkcji, NazwaProgramu, Autor, TypFunkcji, Stan, TypZgloszenia FROM WkWpis";
            zapytanie_sql_notatki.CommandText = "SELECT * FROM WkNotatka";
            adapter_wpisow = new SqlDataAdapter(zapytanie_sql_wpisy);
            adapter_notatek = new SqlDataAdapter(zapytanie_sql_notatki);
            tabela_wpisow = new DataTable();
            tabela_notatek = new DataTable();
        }

        public OknoGlowne()
        {
            moj_aes = new RijndaelManaged();
            moj_aes.KeySize = 256;
            moj_aes.Key = Convert.FromBase64String("LFnuQH7lXF6qXFX3c2SqsrNREmbNWkRWYZTViU2Watc=");
            moj_aes.IV = Convert.FromBase64String("m2BX1RoxPmrHYrS8Q6G9fw==");

            kolor_szukajek_aktywnych = Color.DeepSkyBlue;
            kolor_szukajek_nieaktywnych = Color.FromArgb(192, 255, 192);
            id_uzytkownika = 0;

            string[] parametry = File.ReadAllLines("konfiguracja.txt");

            for (int i=0; i<parametry.Count(); i++)
            {
                if (parametry[i].IndexOf("serwer=") == 0)
                {
                    nazwa_serwera = parametry[i].Substring(parametry[i].IndexOf('=') + 1);
                }
                else if(parametry[i].IndexOf("instancja=") == 0)
                {
                    nazwa_instancji = parametry[i].Substring(parametry[i].IndexOf('=') + 1);
                }
                else if (parametry[i].IndexOf("baza=") == 0)
                {
                    nazwa_bazy = parametry[i].Substring(parametry[i].IndexOf('=') + 1);
                }
                else if (parametry[i].IndexOf("uzytkownik=") == 0)
                {
                    nazwa_uzytkownika = parametry[i].Substring(parametry[i].IndexOf('=') + 1);
                }
                else if (parametry[i].IndexOf("haslo=") == 0)
                {
                    haslo_sql = odszyfrowanie(parametry[i].Substring(parametry[i].IndexOf('=') + 1), moj_aes.Key, moj_aes.IV);
                }
            }

            InitializeComponent();
            tb_s_slowniki_id.BackColor = kolor_szukajek_nieaktywnych;
            tb_s_slowniki_nazwa.BackColor = kolor_szukajek_nieaktywnych;
            tb_s_klient_nazwa.BackColor = kolor_szukajek_nieaktywnych;
            tb_s_klient_id.BackColor = kolor_szukajek_nieaktywnych;
            tb_s_program_id.BackColor = kolor_szukajek_nieaktywnych;
            tb_s_program_nazwa.BackColor = kolor_szukajek_nieaktywnych;
            tb_s_funkcjonalnosc_nazwa.BackColor = kolor_szukajek_nieaktywnych;
            cb_s_funkcjonalnosc_typ_funkcji.BackColor = kolor_szukajek_nieaktywnych;
            cb_s_funkcjonalnosc_program.BackColor = kolor_szukajek_nieaktywnych;
            tb_s_funkcjonalnosc_id.BackColor = kolor_szukajek_nieaktywnych;
        }

        void połączenieZBaząToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okno_ustawien = new OknoUstawienPolaczenia(this);
            okno_ustawien.Show();
        }

        public void logowanie(OknoGlowne glowne)
        {
            okno_logowania = new OknoLogowania(glowne);
            okno_logowania.Show();
        }

        public string odszyfrowanie(string do_odszyfrowania, byte[] klucz, byte[] iv)
        {
            try
            {
                byte[] orginal = Convert.FromBase64String(do_odszyfrowania);
                byte[] wynik = new byte[orginal.Length];
                ICryptoTransform dekryptor = moj_aes.CreateDecryptor(klucz, iv);
                MemoryStream mDekryptora = new MemoryStream(orginal);
                CryptoStream sDekryptora = new CryptoStream(mDekryptora, dekryptor, CryptoStreamMode.Read);
                sDekryptora.Read(wynik, 0, wynik.Length);
                mDekryptora.Close();
                sDekryptora.Close();
                return Encoding.UTF8.GetString(wynik);
            }
            catch
            {
                return "";
            }
        }

        public string zaszyfrowanie(string do_zaszyfrowania, byte[] klucz, byte[] iv)
        {
            byte[] orginal = Encoding.UTF8.GetBytes(do_zaszyfrowania);
            ICryptoTransform enkryptor = moj_aes.CreateEncryptor(klucz, iv);
            MemoryStream mEnkryptora = new MemoryStream();
            CryptoStream sEnkryptora = new CryptoStream(mEnkryptora, enkryptor, CryptoStreamMode.Write);
            sEnkryptora.Write(orginal, 0, orginal.Length);
            sEnkryptora.FlushFinalBlock();
            mEnkryptora.Close();
            sEnkryptora.Close();
            return Convert.ToBase64String(mEnkryptora.ToArray());
        }

        public void wypelnij_datagridy()
        {
            polaczenie_do_bazy.Open();

            adapter_wpisow.Fill(tabela_wpisow);
            adapter_notatek.Fill(tabela_notatek);

            dgv_wpisy.DataSource = tabela_wpisow;
            dgv_notatki.DataSource = tabela_notatek;

            polaczenie_do_bazy.Close();
            if (dgv_notatki.Rows.Count == 0) b_usun_notatke.Enabled = false;
            if (dgv_wpisy.Rows.Count == 0) b_usun_wpis.Enabled = false;
        }

        private void b_dodaj_notatke_Click(object sender, EventArgs e)
        {
            okno_dodawania_notatki = new DodawanieNotatki(this, false);
            okno_dodawania_notatki.Show();
        }

        private void b_edytuj_notatke_Click(object sender, EventArgs e)
        {
            okno_dodawania_notatki = new DodawanieNotatki(this, true);
            okno_dodawania_notatki.Show();
        }

        private void b_usun_notatke_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy potwierdzasz usunięcie notatki?", "Potwierdzenie", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                SqlCommand usuwanie_notatki = polaczenie_do_bazy.CreateCommand();
                usuwanie_notatki.CommandText = "DELETE FROM Notatka WHERE IdNotatki = "+ dgv_notatki.CurrentRow.Cells["IdNotatki"].FormattedValue + "";
                polaczenie_do_bazy.Open();
                usuwanie_notatki.ExecuteNonQuery();
                polaczenie_do_bazy.Close();
                odswiez_grid_notatek();
            }
        }

        private void b_dodaj_wpis_Click(object sender, EventArgs e)
        {
            okno_dodawania_wpisu = new DodawanieWpisu(this, false);
            okno_dodawania_wpisu.Show();
        }

        private void b_edytuj_wpis_Click(object sender, EventArgs e)
        {
            okno_dodawania_wpisu = new DodawanieWpisu(this, true);
            okno_dodawania_wpisu.Show();
        }

        private void b_usun_wpis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy potwierdzasz usunięcie wpisu oraz powiązanych z nim notatek?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand usuwanie_wpisu = polaczenie_do_bazy.CreateCommand();
                usuwanie_wpisu.CommandText = "DELETE FROM Wpis WHERE IdWpisu = " + dgv_wpisy.CurrentRow.Cells["IdWpisu"].FormattedValue + "";
                polaczenie_do_bazy.Open();
                usuwanie_wpisu.ExecuteNonQuery();
                polaczenie_do_bazy.Close();
                odswiez_grid_wpisow();
                odswiez_grid_notatek();
            }
        }

        void Dgv_wpisy_CellMouseClick(object sender, EventArgs e)
        {
            if (dgv_wpisy.SelectedRows.Count>0)
            {
                tb_szczegoly_wpisu.Text = dgv_wpisy.CurrentRow.Cells["Tresc"].FormattedValue + "";
                odswiez_grid_notatek();
            }
        }

        void Dgv_notatki_CellMouseClick(object sender, EventArgs e)
        {
            if (dgv_notatki.SelectedRows.Count > 0)
            {
                tb_szczegoly_notatki.Text = dgv_notatki.CurrentRow.Cells["Tresc"].FormattedValue + "";
            }
        }

        public void odswiez_grid_notatek()
        {
            zapytanie_sql_notatki.CommandText = "SELECT IdNotatki, Tresc, DataCzasNotki, Osoba, PriorytetNotatki, Oddzwonic, Klient FROM WkNotatka WHERE Wpis=" + (dgv_wpisy.Rows.Count.Equals(0) ? -1 : dgv_wpisy.CurrentRow.Cells["IdWpisu"].FormattedValue) + " AND IdNotatki LIKE '%" + tb_s_idnotatka.Text + "%' AND Tresc LIKE '%" + tb_s_trescnotatka.Text + "%' " + (dtp_s_datanotatka.Checked ? "AND CONVERT(varchar, DataCzasNotki, 104) LIKE '%" + dtp_s_datanotatka.Value.ToShortDateString() + "%'" : "") + " AND PriorytetNotatki >= " + nud_s_priorytetnotatka_od.Value + " AND PriorytetNotatki <= " + nud_s_priorytetnotatka_do.Value + " AND id_Oddzwonic LIKE '%" + cb_s_oddzwonicnotatka.SelectedValue + "%' AND Klient LIKE '%" + tb_s_klientnotatka.Text + "%' AND Osoba LIKE '%" + tb_s_autornotatka.Text + "%'";
            tabela_notatek = new DataTable();
            adapter_notatek.Fill(tabela_notatek);
            dgv_notatki.DataSource = tabela_notatek;
            if (dgv_notatki.RowCount > 0)
            {
                b_usun_notatke.Enabled = true;
                b_edytuj_notatke.Enabled = true;
                tb_szczegoly_notatki.Text = dgv_notatki.CurrentRow.Cells["Tresc"].FormattedValue + "";
            }
            else
            {
                b_usun_notatke.Enabled = false;
                b_edytuj_notatke.Enabled = false;
                tb_szczegoly_notatki.Text = "";
            }
        }

        public void odswiez_grid_wpisow()
        {
            zapytanie_sql_wpisy.CommandText = "SELECT DISTINCT wkw.IdWpisu, wkw.DataCzasWpisu, wkw.Tresc, wkw.PriorytetWpisu, wkw.KiedyPrzekazaneWyzej, wkw.NazwaFunkcji, wkw.NazwaProgramu, wkw.Autor, wkw.TypFunkcji, wkw.Stan, wkw.TypZgloszenia FROM WkWpis wkw LEFT JOIN WkNotatka wkn ON wkw.IdWpisu = wkn.Wpis WHERE " +
                "wkw.IdWpisu LIKE '%" + tb_s_idwpisu.Text + "%' " + (dtp_s_datawpisu.Checked ? "" +
                "AND CONVERT(varchar, wkw.DataCzasWpisu, 104) LIKE '%" + dtp_s_datawpisu.Value.ToShortDateString() + "%'" : "") + " " +
                "AND wkw.Tresc LIKE '%" + tb_s_trescwpisu.Text + "%' " +
                "AND wkw.PriorytetWpisu >= " + nud_s_priorytetwpis_od.Value + " " +
                "AND wkw.PriorytetWpisu <= " + nud_s_priorytetwpis_do.Value + "" + (dtp_s_kiedy_wyzejwpis.Checked ? " " +
                "AND CONVERT(varchar, wkw.KiedyPrzekazaneWyzej, 104) LIKE '%" + dtp_s_kiedy_wyzejwpis.Value.ToShortDateString() + "%' " : "") + " " +
                "AND wkw.NazwaFunkcji LIKE '%" + tb_s_funkcjawpis.Text + "%' " +
                "AND wkw.Autor LIKE '%" + tb_s_autorwpis.Text + "%' " +
                "AND wkw.IdProgramu LIKE '%" + (cb_s_programwpis.SelectedIndex > 0 ? cb_s_programwpis.SelectedValue.ToString() : "") + "%' " +
                "AND wkw.id_Stan LIKE '%" + (cb_s_stanwpis.SelectedIndex > 0 ? cb_s_stanwpis.SelectedValue.ToString() : "") + "%' " +
                "AND wkw.id_TypFunkcji LIKE '%" + (cb_s_typfunkcjiwpis.SelectedIndex > 0 ? cb_s_typfunkcjiwpis.SelectedValue.ToString() : "") + "%' " +
                "AND wkw.id_TypZgloszenia LIKE '%" + (cb_s_typzgloszeniawpis.SelectedIndex > 0 ? cb_s_typzgloszeniawpis.SelectedValue.ToString() : "") + "%' " +
                "" + (tb_s_klientwpis.Text == "" ? "" : "AND wkn.Klient LIKE '%" + tb_s_klientwpis.Text + "%'") + "";

            tabela_wpisow = new DataTable();
            adapter_wpisow.Fill(tabela_wpisow);
            dgv_wpisy.DataSource = tabela_wpisow;
            if (dgv_wpisy.RowCount > 0)
            {
                b_usun_wpis.Enabled = true;
                b_edytuj_wpis.Enabled = true;
                tb_szczegoly_wpisu.Text = dgv_wpisy.CurrentRow.Cells["Tresc"].FormattedValue + "";
            }
            else
            {
                b_usun_wpis.Enabled = false;
                b_edytuj_wpis.Enabled = false;
                tb_szczegoly_wpisu.Text = "";
            }
            odswiez_grid_notatek();
        }

        public void odswierz_dgv_programow()
        {
            SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
            zapytanie.CommandText = "SELECT Nazwa, IdProgramu FROM Program WHERE Nazwa LIKE '%" + tb_s_program_nazwa.Text + "%' AND IdProgramu LIKE '%" + tb_s_program_id.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(zapytanie);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dgv_programy.DataSource = tabela;
            if (dgv_programy.Rows.Count > 0)
            {
                b_program_edytuj.Enabled = true;
                b_program_usun.Enabled = true;
            }
            else
            {
                tb_e_program_nazwa.Text = "";
                tb_e_program_id.Text = "";
                b_program_usun.Enabled = false;
                b_program_edytuj.Enabled = false;
            }
        }

        public void odswierz_dgv_funkcjonalnosci()
        {
            SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
            zapytanie.CommandText = "SELECT f.Nazwa, slownik.Element as 'Typ funkcji', p.Nazwa as 'Program', f.Id FROM Funkcjonalnosc as f LEFT JOIN (SELECT IdElementu, Element FROM Slowniki WHERE NazwaSlownika='TypFunkcji') as slownik ON f.TypFunkcji=slownik.IdElementu LEFT JOIN Program as p ON f.Program=p.IdProgramu WHERE f.Nazwa LIKE '%" + tb_s_funkcjonalnosc_nazwa.Text + "%' AND f.Id LIKE '%" + tb_s_funkcjonalnosc_id.Text + "%' " + (cb_s_funkcjonalnosc_typ_funkcji.SelectedIndex > 0 ? "AND f.TypFunkcji=" + cb_s_funkcjonalnosc_typ_funkcji.SelectedValue.ToString() : "") + " " + (cb_s_funkcjonalnosc_program.SelectedIndex > 0 ? " AND f.Program= " + cb_s_funkcjonalnosc_program.SelectedValue.ToString() : "") + "";
            SqlDataAdapter adapter = new SqlDataAdapter(zapytanie);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dgv_funkcjonalnosci.DataSource = tabela;
            if (dgv_funkcjonalnosci.Rows.Count > 0)
            {
                b_funkcjonalnosc_edytuj.Enabled = true;
                b_funkcjonalnosc_usun.Enabled = true;
            }
            else
            {
                tb_e_funkcjonalnosc_nazwa.Text = "";
                tb_e_funkcjonalnosc_id.Text = "";
                b_funkcjonalnosc_usun.Enabled = false;
                b_funkcjonalnosc_edytuj.Enabled = false;
            }
        }

        public void odswierz_dgv_klientow()
        {
            SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
            zapytanie.CommandText = "SELECT Nazwa, IdKlienta FROM Klient WHERE Nazwa LIKE '%" + tb_s_klient_nazwa.Text + "%' AND IdKlienta LIKE '%" + tb_s_klient_id.Text + "%' ORDER BY IdKlienta";
            SqlDataAdapter adapter = new SqlDataAdapter(zapytanie);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dgv_klienci.DataSource = tabela;
            if (dgv_klienci.Rows.Count > 0)
            {
                b_klient_usun.Enabled = true;
                b_klient_edytuj.Enabled = true;
            }
            else
            {
                tb_e_klient_nazwa.Text = "";
                tb_e_klient_id.Text = "";
                b_klient_usun.Enabled = false;
                b_klient_edytuj.Enabled = false;
            }
        }

        public void odswierz_dgv_slownikow()
        {
            dgv_slowniki.DataSource = pobierz_elementy_slownika(cb_slowniki.SelectedValue.ToString(), false, 0, "", " AND Element LIKE '%" + tb_s_slowniki_nazwa.Text + "%' AND IdElementu LIKE '%" + tb_s_slowniki_id.Text + "%'");
            if (dgv_slowniki.Rows.Count > 0)
            {
                b_slowniki_usun.Enabled = true;
                b_slowniki_edytuj.Enabled = true;
            }
            else
            {
                tb_e_slowniki_nazwa.Text = "";
                tb_e_slowniki_id.Text = "";
                b_slowniki_usun.Enabled = false;
                b_slowniki_edytuj.Enabled = false;
            }
        }
        
        public void wypelnij_comboboxy_wyszukiwania()
        {
            cb_s_typzgloszeniawpis.DataSource = pobierz_elementy_slownika("TypZgloszenia", true, 0, "", "");
            cb_s_typzgloszeniawpis.ValueMember = "IdElementu";
            cb_s_typzgloszeniawpis.DisplayMember = "Element";
            cb_s_stanwpis.DataSource = pobierz_elementy_slownika("Stan", true, 0, "", "");
            cb_s_stanwpis.ValueMember = "IdElementu";
            cb_s_stanwpis.DisplayMember = "Element";
            cb_s_typfunkcjiwpis.DataSource = pobierz_elementy_slownika("TypFunkcji", true, 0, "", "");
            cb_s_typfunkcjiwpis.ValueMember = "IdElementu";
            cb_s_typfunkcjiwpis.DisplayMember = "Element";
            cb_s_oddzwonicnotatka.DataSource = pobierz_elementy_slownika("Oddzwonic", true, 0, "", "");
            cb_s_oddzwonicnotatka.ValueMember = "IdElementu";
            cb_s_oddzwonicnotatka.DisplayMember = "Element";
            cb_s_funkcjonalnosc_typ_funkcji.DataSource = pobierz_elementy_slownika("TypFunkcji", true, 0, "", "");
            cb_s_funkcjonalnosc_typ_funkcji.ValueMember = "IdElementu";
            cb_s_funkcjonalnosc_typ_funkcji.DisplayMember = "Element";
            cb_e_funkcjonalnosc_typ_funkcji.DataSource = pobierz_elementy_slownika("TypFunkcji", true, 0, "", "");
            cb_e_funkcjonalnosc_typ_funkcji.ValueMember = "IdElementu";
            cb_e_funkcjonalnosc_typ_funkcji.DisplayMember = "Element";


            SqlCommand zapytanie_programy = polaczenie_do_bazy.CreateCommand();
            zapytanie_programy.CommandText = "SELECT '0' as IdProgramu, '' as Nazwa UNION SELECT IdProgramu, Nazwa FROM Program";
            SqlDataAdapter adapter_programy = new SqlDataAdapter(zapytanie_programy);
            DataTable tabela_programy = new DataTable();
            DataTable tabela_s_funkcjonalnosc_programy = new DataTable();
            DataTable tabela_e_funkcjonalnosc_programy = new DataTable();
            adapter_programy.Fill(tabela_programy);
            adapter_programy.Fill(tabela_s_funkcjonalnosc_programy);
            adapter_programy.Fill(tabela_e_funkcjonalnosc_programy);
            cb_s_programwpis.DataSource = tabela_programy;
            cb_s_programwpis.DisplayMember = "Nazwa";
            cb_s_programwpis.ValueMember = "IdProgramu";
            cb_s_funkcjonalnosc_program.DataSource = tabela_s_funkcjonalnosc_programy;
            cb_s_funkcjonalnosc_program.DisplayMember = "Nazwa";
            cb_s_funkcjonalnosc_program.ValueMember = "IdProgramu";
            cb_e_funkcjonalnosc_program.DataSource = tabela_e_funkcjonalnosc_programy;
            cb_e_funkcjonalnosc_program.DisplayMember = "Nazwa";
            cb_e_funkcjonalnosc_program.ValueMember = "IdProgramu";
        }

        public void wypelnij_zakladke_slownikow()
        {
            //----------    TABELA SLOWNIKOWA   ---------------
            cb_slowniki.DataSource = pobierz_rodzaje_slownikow();
            cb_slowniki.DisplayMember = "NazwaSlownika";
            cb_slowniki.ValueMember = "NazwaSlownika";

            odswierz_dgv_slownikow();
            odswierz_dgv_klientow();
            odswierz_dgv_programow();
            odswierz_dgv_funkcjonalnosci();
        }

        public DataTable pobierz_elementy_slownika(string nazwa_slownika, bool czy_domyslne, int domyslnie_wartosc, string domyslnie_tekst, string dodatkowy_warunek)
        {
            DataTable tabela_slownika = new DataTable();
            SqlCommand zapytanie_slownika = polaczenie_do_bazy.CreateCommand();
            zapytanie_slownika.CommandText = "" + (czy_domyslne ? "SELECT '" + domyslnie_tekst + "' as Element, '" + domyslnie_wartosc + "' as IdElementu UNION " : "") + "SELECT Element, IdElementu FROM Slowniki WHERE NazwaSlownika = '" + nazwa_slownika + "' " + dodatkowy_warunek + "";
            SqlDataAdapter adapter_slownika = new SqlDataAdapter(zapytanie_slownika);
            adapter_slownika.Fill(tabela_slownika);
            return tabela_slownika;
        }

        public DataTable pobierz_rodzaje_slownikow()
        {
            DataTable tabela_slownika = new DataTable();
            SqlCommand zapytanie_slownika = polaczenie_do_bazy.CreateCommand();
            zapytanie_slownika.CommandText = "SELECT DISTINCT NazwaSlownika FROM Slowniki";
            SqlDataAdapter adapter_slownika = new SqlDataAdapter(zapytanie_slownika);
            adapter_slownika.Fill(tabela_slownika);
            return tabela_slownika;
        }

        private void tb_s_idwpisu_TextChanged(object sender, EventArgs e)
        {
            tb_s_idwpisu.BackColor = tb_s_idwpisu.Text=="" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void tb_s_trescwpisu_TextChanged(object sender, EventArgs e)
        {
            tb_s_trescwpisu.BackColor = tb_s_trescwpisu.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void nud_s_priorytetwpis_od_ValueChanged(object sender, EventArgs e)
        {
            nud_s_priorytetwpis_od.BackColor = nud_s_priorytetwpis_od.Value == 0 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void nud_s_priorytetwpis_do_ValueChanged(object sender, EventArgs e)
        {
            nud_s_priorytetwpis_do.BackColor = nud_s_priorytetwpis_do.Value == 100 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void tb_s_funkcjawpis_TextChanged(object sender, EventArgs e)
        {
            tb_s_funkcjawpis.BackColor = tb_s_funkcjawpis.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void cb_s_programwpis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_s_programwpis.BackColor = cb_s_programwpis.SelectedIndex == 0 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void tb_s_nickwpis_TextChanged(object sender, EventArgs e)
        {
            tb_s_autorwpis.BackColor = tb_s_autorwpis.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void cb_s_typfunkcjiwpis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_s_typfunkcjiwpis.BackColor = cb_s_typfunkcjiwpis.SelectedIndex == 0 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void cb_s_stanwpis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_s_stanwpis.BackColor = cb_s_stanwpis.SelectedIndex == 0 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void cb_s_typzgloszeniawpis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_s_typzgloszeniawpis.BackColor = cb_s_typzgloszeniawpis.SelectedIndex == 0 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }

        private void dtp_s_datawpisu_ValueChanged(object sender, EventArgs e)
        {
            odswiez_grid_wpisow();
        }

        private void dtp_s_kiedy_wyzejwpis_ValueChanged(object sender, EventArgs e)
        {
            odswiez_grid_wpisow();
        }
        
        private void tb_s_idnotatka_TextChanged(object sender, EventArgs e)
        {
            tb_s_idnotatka.BackColor = tb_s_idnotatka.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_notatek();
        }

        private void tb_s_trescnotatka_TextChanged(object sender, EventArgs e)
        {
            tb_s_trescnotatka.BackColor = tb_s_trescnotatka.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_notatek();
        }

        private void dtp_s_datanotatka_ValueChanged(object sender, EventArgs e)
        {
            odswiez_grid_notatek();
        }

        private void tb_s_autornotatka_TextChanged(object sender, EventArgs e)
        {
            tb_s_autornotatka.BackColor = tb_s_autornotatka.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_notatek();
        }

        private void nud_s_priorytetnotatka_od_ValueChanged(object sender, EventArgs e)
        {
            nud_s_priorytetnotatka_od.BackColor = nud_s_priorytetnotatka_od.Value == 0 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_notatek();
        }

        private void nud_s_priorytetnotatka_do_ValueChanged(object sender, EventArgs e)
        {
            nud_s_priorytetnotatka_do.BackColor = nud_s_priorytetnotatka_do.Value == 100 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_notatek();
        }

        private void cb_s_oddzwonicnotatka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_s_oddzwonicnotatka.BackColor = cb_s_oddzwonicnotatka.SelectedIndex == 0 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_notatek();
        }

        private void tb_s_klientnotatka_TextChanged(object sender, EventArgs e)
        {
            tb_s_klientnotatka.BackColor = tb_s_klientnotatka.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_notatek();
        }
        
        private void cb_slowniki_SelectedIndexChanged(object sender, EventArgs e)
        {
            odswierz_dgv_slownikow();
        }

        private void tb_s_slowniki_nazwa_TextChanged(object sender, EventArgs e)
        {
            tb_s_slowniki_nazwa.BackColor = tb_s_slowniki_nazwa.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_slownikow();
        }

        private void tb_s_slowniki_id_TextChanged(object sender, EventArgs e)
        {
            tb_s_slowniki_id.BackColor = tb_s_slowniki_id.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_slownikow();
        }

        private void b_slowniki_dodaj_Click(object sender, EventArgs e)
        {
            SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
            zapytanie.CommandText = "SELECT MAX(IdElementu) FROM Slowniki WHERE NazwaSlownika LIKE '"+cb_slowniki.SelectedValue.ToString()+"'";
            polaczenie_do_bazy.Open();
            int proponowany_id = int.Parse(zapytanie.ExecuteScalar().ToString())+10;
            polaczenie_do_bazy.Close();
            proponowany_id = proponowany_id - (proponowany_id % 10);
            tb_e_slowniki_id.Text = proponowany_id.ToString();
            tb_e_slowniki_id.Enabled = true;
            tb_e_slowniki_nazwa.Enabled = true;
            tb_e_slowniki_nazwa.Text = "";
            b_slowniki_zatwierdz.Enabled = true;
            b_slowniki_anuluj.Enabled = true;
            b_slowniki_dodaj.Enabled = false;
            b_slowniki_edytuj.Enabled = false;
            b_slowniki_usun.Enabled = false;
            cb_slowniki.Enabled = false;
            tb_s_slowniki_id.Enabled = false;
            tb_s_slowniki_nazwa.Enabled = false;
            dgv_slowniki.Enabled = false;
            b_slowniki_zatwierdz.Text = "Dodaj";
            tb_e_slowniki_nazwa.Focus();
        }

        private void b_slowniki_anuluj_Click(object sender, EventArgs e)
        {
            tb_e_slowniki_id.Enabled = false;
            tb_e_slowniki_id.Text = dgv_slowniki.CurrentRow.Cells["IdElementu"].FormattedValue.ToString();
            tb_e_slowniki_nazwa.Enabled = false;
            tb_e_slowniki_nazwa.Text = dgv_slowniki.CurrentRow.Cells["Element"].FormattedValue.ToString();
            b_slowniki_zatwierdz.Enabled = false;
            b_slowniki_anuluj.Enabled = false;
            b_slowniki_dodaj.Enabled = true;
            b_slowniki_edytuj.Enabled = true;
            b_slowniki_usun.Enabled = true;
            cb_slowniki.Enabled = true;
            tb_s_slowniki_id.Enabled = true;
            tb_s_slowniki_nazwa.Enabled = true;
            dgv_slowniki.Enabled = true;
            b_slowniki_zatwierdz.Text = "Zatwierdz";
        }

        private void b_slowniki_zatwierdz_Click(object sender, EventArgs e)
        {
            if (tb_e_slowniki_nazwa.Text != "")
            {
                SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
                if (b_slowniki_zatwierdz.Text == "Dodaj")
                {
                    zapytanie.CommandText = "INSERT INTO Slowniki (NazwaSlownika, IdElementu, Element) VALUES ('" + cb_slowniki.SelectedValue.ToString() + "', '" + tb_e_slowniki_id.Text + "', '" + tb_e_slowniki_nazwa.Text + "')";
                }
                else if (b_slowniki_zatwierdz.Text == "Zatwierdz")
                {
                    zapytanie.CommandText = "UPDATE Slowniki SET Element='" + tb_e_slowniki_nazwa.Text + "' WHERE NazwaSlownika LIKE '" + cb_slowniki.SelectedValue.ToString() + "' AND IdElementu LIKE '" + dgv_slowniki.CurrentRow.Cells["IdElementu"].FormattedValue.ToString() + "'";
                }
                polaczenie_do_bazy.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie_do_bazy.Close();
                wypelnij_comboboxy_wyszukiwania();

                tb_e_slowniki_id.Enabled = false;
                tb_e_slowniki_id.Text = dgv_slowniki.CurrentRow.Cells["IdElementu"].FormattedValue.ToString();
                tb_e_slowniki_nazwa.Enabled = false;
                tb_e_slowniki_nazwa.Text = dgv_slowniki.CurrentRow.Cells["Element"].FormattedValue.ToString();
                b_slowniki_zatwierdz.Enabled = false;
                b_slowniki_anuluj.Enabled = false;
                b_slowniki_dodaj.Enabled = true;
                b_slowniki_edytuj.Enabled = true;
                b_slowniki_usun.Enabled = true;
                cb_slowniki.Enabled = true;
                tb_s_slowniki_id.Enabled = true;
                tb_s_slowniki_nazwa.Enabled = true;
                dgv_slowniki.Enabled = true;
                b_slowniki_zatwierdz.Text = "Zatwierdz";
                odswierz_dgv_slownikow();
            }
            else
            {
                MessageBox.Show("Wprowadź nazwę elementu.");
            }
        }

        private void b_slowniki_edytuj_Click(object sender, EventArgs e)
        {
            tb_e_slowniki_id.Enabled = false;
            tb_e_slowniki_nazwa.Enabled = true;
            b_slowniki_zatwierdz.Enabled = true;
            b_slowniki_anuluj.Enabled = true;
            b_slowniki_dodaj.Enabled = false;
            b_slowniki_edytuj.Enabled = false;
            b_slowniki_usun.Enabled = false;
            cb_slowniki.Enabled = false;
            tb_s_slowniki_id.Enabled = false;
            tb_s_slowniki_nazwa.Enabled = false;
            dgv_slowniki.Enabled = false;
            b_slowniki_zatwierdz.Text = "Zatwierdz";
            tb_e_slowniki_nazwa.Focus();
        }

        private void b_slowniki_usun_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy potwierdzasz usunięcie pozycji słownika?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
                zapytanie.CommandText = "DELETE FROM Slowniki WHERE NazwaSlownika LIKE '" + cb_slowniki.SelectedValue.ToString() + "' AND IdElementu LIKE '" + dgv_slowniki.CurrentRow.Cells["IdElementu"].FormattedValue.ToString() + "' AND Element LIKE '"+ dgv_slowniki.CurrentRow.Cells["Element"].FormattedValue.ToString() + "'";
                polaczenie_do_bazy.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie_do_bazy.Close();
                odswierz_dgv_slownikow();
                wypelnij_comboboxy_wyszukiwania();
            }
        }
        
        private void tb_s_klient_nazwa_TextChanged(object sender, EventArgs e)
        {
            tb_s_klient_nazwa.BackColor = tb_s_klient_nazwa.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_klientow();
        }

        private void tb_s_klient_id_TextChanged(object sender, EventArgs e)
        {
            tb_s_klient_id.BackColor = tb_s_klient_id.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_klientow();
        }

        private void dgv_klienci_CellMouseClick(object sender, EventArgs e)
        {
            if (dgv_klienci.SelectedRows.Count > 0)
            {
                tb_e_klient_nazwa.Text = dgv_klienci.CurrentRow.Cells["Nazwa"].FormattedValue.ToString();
                tb_e_klient_id.Text = dgv_klienci.CurrentRow.Cells["IdKlienta"].FormattedValue.ToString();
            }
        }

        private void b_klient_usun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy potwierdzasz usunięcie wpisu?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
                zapytanie.CommandText = "DELETE FROM Klient WHERE IdKlienta = "+dgv_klienci.CurrentRow.Cells["IdKlienta"].FormattedValue.ToString()+"";
                polaczenie_do_bazy.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie_do_bazy.Close();
                odswierz_dgv_klientow();
            }
        }

        private void b_klient_dodaj_Click(object sender, EventArgs e)
        {
            SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
            zapytanie.CommandText = "SELECT MAX(IdKlienta) FROM Klient";
            polaczenie_do_bazy.Open();
            int proponowany_id = int.Parse(zapytanie.ExecuteScalar().ToString()) + 1;
            polaczenie_do_bazy.Close();
            tb_e_klient_nazwa.Text = "";
            tb_e_klient_nazwa.Enabled = true;
            tb_e_klient_id.Text = proponowany_id.ToString();
            tb_e_klient_id.Enabled = false;
            b_klient_dodaj.Enabled = false;
            b_klient_edytuj.Enabled = false;
            b_klient_usun.Enabled = false;
            b_klient_zatwierdz.Enabled = true;
            b_klient_anuluj.Enabled = true;
            tb_s_klient_id.Enabled = false;
            tb_s_klient_nazwa.Enabled = false;
            dgv_klienci.Enabled = false;
            b_klient_zatwierdz.Text = "Dodaj";
            tb_e_klient_nazwa.Focus();
        }

        private void b_klient_anuluj_Click(object sender, EventArgs e)
        {
            tb_e_klient_nazwa.Text = dgv_klienci.CurrentRow.Cells["Nazwa"].FormattedValue.ToString();
            tb_e_klient_nazwa.Enabled = false;
            tb_e_klient_id.Text = dgv_klienci.CurrentRow.Cells["IdKlienta"].FormattedValue.ToString();
            tb_e_klient_id.Enabled = false;
            b_klient_dodaj.Enabled = true;
            b_klient_edytuj.Enabled = true;
            b_klient_usun.Enabled = true;
            b_klient_zatwierdz.Enabled = false;
            b_klient_anuluj.Enabled = false;
            tb_s_klient_id.Enabled = true;
            tb_s_klient_nazwa.Enabled = true;
            dgv_klienci.Enabled = true;
            b_klient_zatwierdz.Text = "Zatwierdź";
        }

        private void b_klient_zatwierdz_Click(object sender, EventArgs e)
        {
            if (tb_e_klient_nazwa.Text != "")
            {
                SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
                if (b_klient_zatwierdz.Text == "Dodaj")
                {
                    zapytanie.CommandText = "INSERT INTO Klient (Nazwa, IdKlienta) VALUES ('"+tb_e_klient_nazwa.Text+"', '"+tb_e_klient_id.Text+ "') SET IDENTITY_INSERT Klient OFF";
                }
                else if (b_klient_zatwierdz.Text == "Zatwierdź")
                {
                    zapytanie.CommandText = "UPDATE Klient SET Nazwa = '"+tb_e_klient_nazwa.Text+"' WHERE IdKlienta = "+int.Parse(dgv_klienci.CurrentRow.Cells["IdKlienta"].FormattedValue.ToString())+"";
                }
                polaczenie_do_bazy.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie_do_bazy.Close();

                tb_e_klient_nazwa.Text = dgv_klienci.CurrentRow.Cells["Nazwa"].FormattedValue.ToString();
                tb_e_klient_nazwa.Enabled = false;
                tb_e_klient_id.Text = dgv_klienci.CurrentRow.Cells["IdKlienta"].FormattedValue.ToString();
                tb_e_klient_id.Enabled = false;
                b_klient_dodaj.Enabled = true;
                b_klient_edytuj.Enabled = true;
                b_klient_usun.Enabled = true;
                b_klient_zatwierdz.Enabled = false;
                b_klient_anuluj.Enabled = false;
                tb_s_klient_id.Enabled = true;
                tb_s_klient_nazwa.Enabled = true;
                dgv_klienci.Enabled = true;
                b_klient_zatwierdz.Text = "Zatwierdź";
                odswierz_dgv_klientow();
            }
            else
            {
                MessageBox.Show("Wprowadź nazwę klienta.");
            }
        }

        private void b_klient_edytuj_Click(object sender, EventArgs e)
        {
            tb_e_klient_nazwa.Enabled = true;
            tb_e_klient_id.Enabled = false;
            b_klient_dodaj.Enabled = false;
            b_klient_edytuj.Enabled = false;
            b_klient_usun.Enabled = false;
            b_klient_zatwierdz.Enabled = true;
            b_klient_anuluj.Enabled = true;
            tb_s_klient_id.Enabled = false;
            tb_s_klient_nazwa.Enabled = false;
            dgv_klienci.Enabled = false;
            b_klient_zatwierdz.Text = "Zatwierdź";
            tb_e_klient_nazwa.Focus();
        }
        
        private void tb_s_program_nazwa_TextChanged(object sender, EventArgs e)
        {
            tb_s_program_nazwa.BackColor = tb_s_program_nazwa.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_programow();
        }

        private void tb_s_program_id_TextChanged(object sender, EventArgs e)
        {
            tb_s_program_id.BackColor = tb_s_program_id.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_programow();
        }

        private void dgv_programy_CellMouseClick(object sender, EventArgs e)
        {
            if (dgv_programy.SelectedRows.Count > 0)
            {
                tb_e_program_id.Text = dgv_programy.CurrentRow.Cells["IdProgramu"].FormattedValue.ToString();
                tb_e_program_nazwa.Text = dgv_programy.CurrentRow.Cells["Nazwa"].FormattedValue.ToString();
            }
        }

        private void b_program_usun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy potwierdzasz usunięcie?","Potwierdź",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
                zapytanie.CommandText = "DELETE FROM Program WHERE IdProgramu = " + dgv_programy.CurrentRow.Cells["IdProgramu"].FormattedValue.ToString() + "";
                SqlDataAdapter adapter = new SqlDataAdapter(zapytanie);
                polaczenie_do_bazy.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie_do_bazy.Close();
                odswierz_dgv_programow();
                wypelnij_comboboxy_wyszukiwania();
            }
        }

        private void b_program_dodaj_Click(object sender, EventArgs e)
        {
            SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
            zapytanie.CommandText = "SELECT MAX(IdProgramu) + 1 FROM Program";
            polaczenie_do_bazy.Open();
            tb_e_program_id.Text = zapytanie.ExecuteScalar().ToString();
            polaczenie_do_bazy.Close();;
            tb_e_program_id.Enabled = false;
            tb_e_program_nazwa.Text = "";
            tb_e_program_nazwa.Enabled = true;
            tb_s_program_id.Enabled = false;
            tb_s_program_nazwa.Enabled = false;
            dgv_programy.Enabled = false;
            b_program_dodaj.Enabled = false;
            b_program_edytuj.Enabled = false;
            b_program_usun.Enabled = false;
            b_program_anuluj.Enabled = true;
            b_program_zatwierdz.Enabled = true;
            b_program_zatwierdz.Text = "Dodaj";
            tb_e_program_nazwa.Focus();
        }

        private void b_program_anuluj_Click(object sender, EventArgs e)
        {
            tb_e_program_id.Enabled = false;
            tb_e_program_nazwa.Enabled = false;
            tb_s_program_id.Enabled = true;
            tb_s_program_nazwa.Enabled = true;
            dgv_programy.Enabled = true;
            b_program_dodaj.Enabled = true;
            b_program_edytuj.Enabled = true;
            b_program_usun.Enabled = true;
            b_program_anuluj.Enabled = false;
            b_program_zatwierdz.Enabled = false;
            b_program_zatwierdz.Text = "Zatwierdź";
            odswierz_dgv_programow();
        }

        private void b_program_zatwierdz_Click(object sender, EventArgs e)
        {
            if (tb_e_program_nazwa.Text != "")
            {
                SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
                if (b_program_zatwierdz.Text == "Dodaj")
                {
                    zapytanie.CommandText = "SET IDENTITY_INSERT Program ON INSERT INTO Program (IdProgramu, Nazwa) VALUES (" + tb_e_program_id.Text + ",'" + tb_e_program_nazwa.Text + "') SET IDENTITY_INSERT Program OFF";
                }
                else if (b_program_zatwierdz.Text == "Zatwierdź")
                {
                    zapytanie.CommandText = "UPDATE Program SET Nazwa = '" + tb_e_program_nazwa.Text + "' WHERE IdProgramu = " + dgv_programy.CurrentRow.Cells["IdProgramu"].FormattedValue + "";
                }

                polaczenie_do_bazy.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie_do_bazy.Close();

                tb_e_program_id.Enabled = false;
                tb_e_program_nazwa.Enabled = false;
                tb_s_program_id.Enabled = true;
                tb_s_program_nazwa.Enabled = true;
                dgv_programy.Enabled = true;
                b_program_dodaj.Enabled = true;
                b_program_edytuj.Enabled = true;
                b_program_usun.Enabled = true;
                b_program_anuluj.Enabled = false;
                b_program_zatwierdz.Enabled = false;
                b_program_zatwierdz.Text = "Zatwierdź";
                odswierz_dgv_programow();
                wypelnij_comboboxy_wyszukiwania();
            }
            else
            {
                MessageBox.Show("Uzupełnij brakujące dane.");
            }
        }

        private void b_program_edytuj_Click(object sender, EventArgs e)
        {
            tb_e_program_id.Enabled = false;
            tb_e_program_nazwa.Enabled = true;
            tb_s_program_id.Enabled = false;
            tb_s_program_nazwa.Enabled = false;
            dgv_programy.Enabled = false;
            b_program_dodaj.Enabled = false;
            b_program_edytuj.Enabled = false;
            b_program_usun.Enabled = false;
            b_program_anuluj.Enabled = true;
            b_program_zatwierdz.Enabled = true;
            b_program_zatwierdz.Text = "Zatwierdź";
            tb_e_program_nazwa.Focus();
        }
        
        private void tb_s_funkcjonalnosc_nazwa_TextChanged(object sender, EventArgs e)
        {
            tb_s_funkcjonalnosc_nazwa.BackColor = tb_s_funkcjonalnosc_nazwa.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_funkcjonalnosci();
        }

        private void tb_s_funkcjonalnosc_id_TextChanged(object sender, EventArgs e)
        {
            tb_s_funkcjonalnosc_id.BackColor = tb_s_funkcjonalnosc_id.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_funkcjonalnosci();
        }

        private void cb_s_funkcjonalnosc_typ_funkcji_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_s_funkcjonalnosc_typ_funkcji.BackColor = cb_s_funkcjonalnosc_typ_funkcji.SelectedIndex == 0 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_funkcjonalnosci();
        }

        private void cb_s_funkcjonalnosc_program_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_s_funkcjonalnosc_program.BackColor = cb_s_funkcjonalnosc_program.SelectedIndex == 0 ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswierz_dgv_funkcjonalnosci();
        }

        private void b_funkcjonalnosc_usun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy potwierdzasz usunięcie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
                zapytanie.CommandText = "DELETE FROM Funkcjonalnosc WHERE Id=" + dgv_funkcjonalnosci.CurrentRow.Cells["Id"].FormattedValue+"";
                polaczenie_do_bazy.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie_do_bazy.Close();
                odswierz_dgv_funkcjonalnosci();
            }
        }

        private void b_funkcjonalnosc_dodaj_Click(object sender, EventArgs e)
        {
            SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
            zapytanie.CommandText = "SELECT (MAX(Id)+1) as Id FROM Funkcjonalnosc";
            polaczenie_do_bazy.Open();
            tb_e_funkcjonalnosc_id.Text = zapytanie.ExecuteScalar().ToString();
            polaczenie_do_bazy.Close();
            dgv_funkcjonalnosci.Enabled = false;
            tb_s_funkcjonalnosc_nazwa.Enabled = false;
            tb_s_funkcjonalnosc_id.Enabled = false;
            cb_s_funkcjonalnosc_program.Enabled = false;
            cb_s_funkcjonalnosc_typ_funkcji.Enabled = false;
            b_funkcjonalnosc_dodaj.Enabled = false;
            b_funkcjonalnosc_edytuj.Enabled = false;
            b_funkcjonalnosc_usun.Enabled = false;
            tb_e_funkcjonalnosc_nazwa.Enabled = true;
            tb_e_funkcjonalnosc_nazwa.Text = "";
            tb_e_funkcjonalnosc_id.Enabled = false;
            cb_e_funkcjonalnosc_program.SelectedIndex = 0;
            cb_e_funkcjonalnosc_program.Enabled = true;
            cb_e_funkcjonalnosc_typ_funkcji.SelectedIndex = 0;
            cb_e_funkcjonalnosc_typ_funkcji.Enabled = true;
            b_funkcjonalnosc_zatwierdz.Enabled = true;
            b_funkcjonalnosc_anuluj.Enabled = true;
            b_funkcjonalnosc_zatwierdz.Text = "Dodaj";
        }

        private void b_funkcjonalnosc_anuluj_Click(object sender, EventArgs e)
        {
            tb_s_funkcjonalnosc_nazwa.Enabled = true;
            tb_s_funkcjonalnosc_id.Enabled = true;
            cb_s_funkcjonalnosc_program.Enabled = true;
            cb_s_funkcjonalnosc_typ_funkcji.Enabled = true;
            dgv_funkcjonalnosci.Enabled = true;
            b_funkcjonalnosc_dodaj.Enabled = true;
            b_funkcjonalnosc_edytuj.Enabled = true;
            b_funkcjonalnosc_usun.Enabled = true;
            tb_e_funkcjonalnosc_nazwa.Enabled = false;
            tb_e_funkcjonalnosc_id.Enabled = false;
            cb_e_funkcjonalnosc_program.Enabled = false;
            cb_e_funkcjonalnosc_typ_funkcji.Enabled = false;
            b_funkcjonalnosc_zatwierdz.Enabled = false;
            b_funkcjonalnosc_anuluj.Enabled = false;
            odswierz_dgv_funkcjonalnosci();
        }

        private void dgv_funkcjonalnosci_CellMouseClick(object sender, EventArgs e)
        {
            if (dgv_funkcjonalnosci.Rows.Count > 0)
            {
                cb_e_funkcjonalnosc_typ_funkcji.SelectedIndex = cb_e_funkcjonalnosc_typ_funkcji.FindString(dgv_funkcjonalnosci.CurrentRow.Cells["Typ funkcji"].FormattedValue.ToString());
                cb_e_funkcjonalnosc_program.SelectedIndex = cb_e_funkcjonalnosc_program.FindString(dgv_funkcjonalnosci.CurrentRow.Cells["Program"].FormattedValue.ToString());
                tb_e_funkcjonalnosc_id.Text = dgv_funkcjonalnosci.CurrentRow.Cells["Id"].FormattedValue.ToString();
                tb_e_funkcjonalnosc_nazwa.Text = dgv_funkcjonalnosci.CurrentRow.Cells["Nazwa"].FormattedValue.ToString();
            }
        }

        private void b_funkcjonalnosc_edytuj_Click(object sender, EventArgs e)
        {
            dgv_funkcjonalnosci.Enabled = false;
            tb_s_funkcjonalnosc_nazwa.Enabled = false;
            tb_s_funkcjonalnosc_id.Enabled = false;
            cb_s_funkcjonalnosc_program.Enabled = false;
            cb_s_funkcjonalnosc_typ_funkcji.Enabled = false;
            b_funkcjonalnosc_dodaj.Enabled = false;
            b_funkcjonalnosc_edytuj.Enabled = false;
            b_funkcjonalnosc_usun.Enabled = false;
            tb_e_funkcjonalnosc_nazwa.Enabled = true;
            tb_e_funkcjonalnosc_id.Enabled = false;
            cb_e_funkcjonalnosc_program.Enabled = true;
            cb_e_funkcjonalnosc_typ_funkcji.Enabled = true;
            b_funkcjonalnosc_zatwierdz.Enabled = true;
            b_funkcjonalnosc_anuluj.Enabled = true;
            b_funkcjonalnosc_zatwierdz.Text = "Zatwierdź";
        }

        private void b_funkcjonalnosc_zatwierdz_Click(object sender, EventArgs e)
        {
            if (tb_e_funkcjonalnosc_nazwa.Text != "" && cb_e_funkcjonalnosc_typ_funkcji.SelectedIndex > 0 && cb_e_funkcjonalnosc_program.SelectedIndex > 0)
            {
                SqlCommand zapytanie = polaczenie_do_bazy.CreateCommand();
                if (b_funkcjonalnosc_zatwierdz.Text == "Dodaj")
                {
                    zapytanie.CommandText = "INSERT INTO Funkcjonalnosc (Nazwa,TypFunkcji,Program) VALUES ('" + tb_e_funkcjonalnosc_nazwa.Text + "'," + cb_e_funkcjonalnosc_typ_funkcji.SelectedValue.ToString() + "," + cb_e_funkcjonalnosc_program.SelectedValue.ToString() + ")";
                }
                else if (b_funkcjonalnosc_zatwierdz.Text == "Zatwierdź")
                {
                    zapytanie.CommandText = "UPDATE Funkcjonalnosc SET Nazwa='" + tb_e_funkcjonalnosc_nazwa.Text + "', TypFunkcji=" + cb_e_funkcjonalnosc_typ_funkcji.SelectedValue.ToString() + ", Program=" + cb_e_funkcjonalnosc_program.SelectedValue.ToString() + " WHERE Id=" + dgv_funkcjonalnosci.CurrentRow.Cells["Id"].FormattedValue.ToString() + "";
                }
                polaczenie_do_bazy.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie_do_bazy.Close();
                tb_s_funkcjonalnosc_nazwa.Enabled = true;
                tb_s_funkcjonalnosc_id.Enabled = true;
                cb_s_funkcjonalnosc_program.Enabled = true;
                cb_s_funkcjonalnosc_typ_funkcji.Enabled = true;
                dgv_funkcjonalnosci.Enabled = true;
                b_funkcjonalnosc_dodaj.Enabled = true;
                b_funkcjonalnosc_edytuj.Enabled = true;
                b_funkcjonalnosc_usun.Enabled = true;
                tb_e_funkcjonalnosc_nazwa.Enabled = false;
                tb_e_funkcjonalnosc_id.Enabled = false;
                cb_e_funkcjonalnosc_program.Enabled = false;
                cb_e_funkcjonalnosc_typ_funkcji.Enabled = false;
                b_funkcjonalnosc_zatwierdz.Enabled = false;
                b_funkcjonalnosc_anuluj.Enabled = false;
                odswierz_dgv_funkcjonalnosci();
            }
            else
            {
                MessageBox.Show("Uzupełnij brakujące dane.");
            }
        }
        
        private void tb_s_klientwpis_TextChanged(object sender, EventArgs e)
        {
            tb_s_klientwpis.BackColor = tb_s_klientwpis.Text == "" ? kolor_szukajek_nieaktywnych : kolor_szukajek_aktywnych;
            odswiez_grid_wpisow();
        }
        
        public void Dgv_slowniki_CellMouseClick(object sender, EventArgs e)
        {
            if (dgv_slowniki.SelectedRows.Count > 0)
            {
                tb_e_slowniki_nazwa.Text = dgv_slowniki.CurrentRow.Cells["Element"].FormattedValue.ToString();
                tb_e_slowniki_id.Text = dgv_slowniki.CurrentRow.Cells["IdElementu"].FormattedValue.ToString();
            }
        }

        private void uzytkownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okno_uzytkonicy = new OknoUzytkownicy(polaczenie_do_bazy);
            okno_uzytkonicy.Show();
        }

        private void zmianaHaslaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okno_zmiany_hasla = new OknoZmianyHasla(polaczenie_do_bazy, nick, id_uzytkownika, true);
            okno_zmiany_hasla.Show();
        }
    }
}