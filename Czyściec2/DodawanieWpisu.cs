using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Czyściec2
{
    public partial class DodawanieWpisu : Form
    {
        OknoGlowne zrodlo;
        bool modyfikacja;

        public DodawanieWpisu(OknoGlowne okno_zrodla, bool czy_modyfikacja)
        {
            zrodlo = okno_zrodla;
            
            InitializeComponent();
            modyfikacja = czy_modyfikacja;
            this.Text = modyfikacja ? "Modyfikacja Wpisu" : "Dodawanie Wpisu";
            uzupelnij_formatke_wpisu();
        }

        private void b_anuluj_wpis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uzupelnij_formatke_wpisu()
        {
            dtp_kiedy_wyzej.Value = DateTime.Today;
            cb_typ_zgloszenia.DataSource = zrodlo.pobierz_elementy_slownika("TypZgloszenia", false, 0, "", "");
            cb_typ_zgloszenia.ValueMember = "IdElementu";
            cb_typ_zgloszenia.DisplayMember = "Element";
            cb_stan.DataSource = zrodlo.pobierz_elementy_slownika("Stan", false, 0, "", "");
            cb_stan.ValueMember = "IdElementu";
            cb_stan.DisplayMember = "Element";
            cb_typ_funkcjonalnosci.DataSource = zrodlo.pobierz_elementy_slownika("TypFunkcji", false, 0, "", "");
            cb_typ_funkcjonalnosci.ValueMember = "IdElementu";
            cb_typ_funkcjonalnosci.DisplayMember = "Element";
            uzupelnij_programy();
            if (modyfikacja)
            {
                SqlCommand zapytanie_dane_wpisu = zrodlo.polaczenie_do_bazy.CreateCommand();
                zapytanie_dane_wpisu.CommandText = "SELECT w.TypZgloszenia, w.DataCzasWpisu, w.Tresc, w.Stan, w.PriorytetWpisu, w.KiedyPrzekazaneWyzej, w.Funkcjonalnosc, f.TypFunkcji, f.Program FROM Wpis as w, Funkcjonalnosc as f WHERE w.Funkcjonalnosc = f.Id AND w.IdWpisu = " + zrodlo.dgv_wpisy.CurrentRow.Cells["IdWpisu"].FormattedValue+"";
                SqlDataAdapter adapter_dane_wpisu = new SqlDataAdapter(zapytanie_dane_wpisu);
                DataTable tabela_danych_wpisu = new DataTable();
                adapter_dane_wpisu.Fill(tabela_danych_wpisu);
                cb_typ_zgloszenia.SelectedValue = tabela_danych_wpisu.Rows[0]["TypZgloszenia"];
                cb_stan.SelectedValue = tabela_danych_wpisu.Rows[0]["Stan"];
                cb_typ_funkcjonalnosci.SelectedValue = tabela_danych_wpisu.Rows[0]["TypFunkcji"];
                cb_program.SelectedValue = tabela_danych_wpisu.Rows[0]["Program"];
                aktualizuj_liste_funkcjonalnosci(int.Parse(cb_typ_funkcjonalnosci.SelectedValue.ToString()), int.Parse(cb_program.SelectedValue.ToString()), tb_funkcjonalnosc.Text);
                lb_funkcjonalnosc.SelectedValue = tabela_danych_wpisu.Rows[0]["Funkcjonalnosc"].ToString();
                tb_tresc.Text = tabela_danych_wpisu.Rows[0]["Tresc"].ToString();
                nud_priorytet_wpisu.Value = int.Parse(tabela_danych_wpisu.Rows[0]["PriorytetWpisu"].ToString());
                if (tabela_danych_wpisu.Rows[0]["KiedyPrzekazaneWyzej"].ToString() != "")
                {
                    dtp_kiedy_wyzej.Checked = true;
                    dtp_kiedy_wyzej.Value = DateTime.Parse(tabela_danych_wpisu.Rows[0]["KiedyPrzekazaneWyzej"].ToString());
                }
            }
            else
            {
                aktualizuj_liste_funkcjonalnosci(int.Parse(cb_typ_funkcjonalnosci.SelectedValue.ToString()), int.Parse(cb_program.SelectedValue.ToString()), tb_funkcjonalnosc.Text);
                lb_funkcjonalnosc.ClearSelected();
            }
        }

        private void aktualizuj_liste_funkcjonalnosci(int typ_funkcji, int program, string nazwa)
        {
            string warunek = " WHERE Nazwa LIKE '%"+ nazwa + "%'";
            if (typ_funkcji >= 0) warunek += " AND TypFunkcji=" + typ_funkcji + "";
            if (program >= 0 ) warunek += " AND Program=" + program + "";
            
            SqlCommand zapytanie_funkcjonalnosci = zrodlo.polaczenie_do_bazy.CreateCommand();
            zapytanie_funkcjonalnosci.CommandText = "SELECT Id, Nazwa FROM Funkcjonalnosc "+ warunek + "";
            DataTable tabela_funkcjonalnosci = new DataTable();
            zrodlo.polaczenie_do_bazy.Open();
            SqlDataAdapter adapter_funkcjonalnosci = new SqlDataAdapter(zapytanie_funkcjonalnosci);
            adapter_funkcjonalnosci.Fill(tabela_funkcjonalnosci);
            zrodlo.polaczenie_do_bazy.Close();
            lb_funkcjonalnosc.DataSource = tabela_funkcjonalnosci;
            lb_funkcjonalnosc.DisplayMember = "Nazwa";
            lb_funkcjonalnosc.ValueMember = "Id";
        }

        private void uzupelnij_programy()
        {
            SqlCommand zapytanie_programy = zrodlo.polaczenie_do_bazy.CreateCommand();
            zapytanie_programy.CommandText = "SELECT IdProgramu, Nazwa FROM Program";
            SqlDataAdapter adapter_programy = new SqlDataAdapter(zapytanie_programy);
            DataTable tabela_programy = new DataTable();
            zrodlo.polaczenie_do_bazy.Open();
            adapter_programy.Fill(tabela_programy);
            zrodlo.polaczenie_do_bazy.Close();
            cb_program.DataSource = tabela_programy;
            cb_program.DisplayMember = "Nazwa";
            cb_program.ValueMember = "IdProgramu";
        }

        private void tb_funkcjonalnosc_TextChanged(object sender, EventArgs e)
        {
            aktualizuj_liste_funkcjonalnosci(int.Parse(cb_typ_funkcjonalnosci.SelectedValue.ToString()), int.Parse(cb_program.SelectedValue.ToString()), tb_funkcjonalnosc.Text);
        }

        private void cb_typ_funkcjonalnosci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_typ_funkcjonalnosci.Focused) aktualizuj_liste_funkcjonalnosci(int.Parse(cb_typ_funkcjonalnosci.SelectedValue.ToString()), int.Parse(cb_program.SelectedValue.ToString()), tb_funkcjonalnosc.Text);
            lb_funkcjonalnosc.ClearSelected();
        }

        private void cb_program_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_program.Focused) aktualizuj_liste_funkcjonalnosci(int.Parse(cb_typ_funkcjonalnosci.SelectedValue.ToString()), int.Parse(cb_program.SelectedValue.ToString()), tb_funkcjonalnosc.Text);
            lb_funkcjonalnosc.ClearSelected();
        }

        private void b_zatwierdz_wpis_Click(object sender, EventArgs e)
        {
            if (tb_tresc.Text != "" && (lb_funkcjonalnosc.SelectedItems.Count > 0 || tb_funkcjonalnosc.Text != ""))
            {
                int id_funkcjonalnosci;
                
                if (lb_funkcjonalnosc.SelectedItems.Count == 0)
                {
                    SqlCommand zapytanie_dodanie_funkcjonalnosci = zrodlo.polaczenie_do_bazy.CreateCommand();
                    zapytanie_dodanie_funkcjonalnosci.CommandText = "INSERT INTO Funkcjonalnosc (Nazwa, TypFunkcji, Program) VALUES ('" + tb_funkcjonalnosc.Text + "', " + cb_typ_funkcjonalnosci.SelectedValue + ", " + cb_program.SelectedValue + ")";
                    zrodlo.polaczenie_do_bazy.Open();
                    zapytanie_dodanie_funkcjonalnosci.ExecuteNonQuery();
                    zrodlo.polaczenie_do_bazy.Close();

                    SqlCommand zapytanie_sprawdzenie_id_funkcjonalnosci = zrodlo.polaczenie_do_bazy.CreateCommand();
                    zapytanie_sprawdzenie_id_funkcjonalnosci.CommandText = "SELECT Id FROM Funkcjonalnosc WHERE Nazwa = '" + tb_funkcjonalnosc.Text + "' AND TypFunkcji = " + cb_typ_funkcjonalnosci.SelectedValue + " AND Program = " + cb_program.SelectedValue + "";
                    SqlDataAdapter adapter_pobranie_id_funkcjonalnosci = new SqlDataAdapter(zapytanie_sprawdzenie_id_funkcjonalnosci);
                    DataTable tabela_id_funkcjonalnosci = new DataTable();
                    adapter_pobranie_id_funkcjonalnosci.Fill(tabela_id_funkcjonalnosci);
                    id_funkcjonalnosci = int.Parse(tabela_id_funkcjonalnosci.Rows[0][0].ToString());
                }
                else
                {
                    id_funkcjonalnosci = int.Parse(lb_funkcjonalnosc.SelectedValue.ToString());
                }
                string data_kiedy_wyzej = dtp_kiedy_wyzej.Checked ? "'" + dtp_kiedy_wyzej.Value.Year + "-" + dtp_kiedy_wyzej.Value.Month + "-" + dtp_kiedy_wyzej.Value.Day + " 00:00:00.000'" : "NULL";

                SqlCommand zapytanie_dodanie_wpisu = zrodlo.polaczenie_do_bazy.CreateCommand();
                if (modyfikacja)
                {
                    zapytanie_dodanie_wpisu.CommandText = "UPDATE Wpis SET TypZgloszenia="+ cb_typ_zgloszenia.SelectedValue + ", DataCzasWpisu=GETDATE(), Autor='1', Tresc='"+ tb_tresc.Text + "', Stan="+ cb_stan.SelectedValue + ", PriorytetWpisu=" + nud_priorytet_wpisu.Value + ", KiedyPrzekazaneWyzej="+ data_kiedy_wyzej + ", Funkcjonalnosc="+ id_funkcjonalnosci + " WHERE IdWpisu="+ zrodlo.dgv_wpisy.CurrentRow.Cells["IdWpisu"].FormattedValue + "";
                }
                else
                {
                    zapytanie_dodanie_wpisu.CommandText = "INSERT INTO Wpis (TypZgloszenia, DataCzasWpisu, Autor, Tresc, Stan, PriorytetWpisu, KiedyPrzekazaneWyzej, Funkcjonalnosc) VALUES ('" + cb_typ_zgloszenia.SelectedValue + "', GETDATE(), '1', '" + tb_tresc.Text + "', '" + cb_stan.SelectedValue + "', '" + nud_priorytet_wpisu.Value + "', " + data_kiedy_wyzej + ", " + id_funkcjonalnosci + ")";
                }
                zrodlo.polaczenie_do_bazy.Open();
                zapytanie_dodanie_wpisu.ExecuteNonQuery();
                zrodlo.polaczenie_do_bazy.Close();
                zrodlo.odswiez_grid_wpisow();
                zrodlo.odswiez_grid_notatek();
                zrodlo.odswierz_dgv_funkcjonalnosci();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Proszę uzupełnić brakujące dane.", "Komunikat");
            }
        }
    }
}
