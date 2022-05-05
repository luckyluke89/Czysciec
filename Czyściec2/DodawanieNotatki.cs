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
    public partial class DodawanieNotatki : Form
    {
        DataTable tabela_klienci;
        SqlDataAdapter adapter_klienci;
        SqlDataAdapter dodanie_notatki;
        SqlCommand zapytanie_klienci;
        SqlCommand zapytanie_dodanie_notatki;
        OknoGlowne zrodlo;
        bool modyfikacja;

        public DodawanieNotatki(OknoGlowne okno_zrodla, bool czy_modyfikacja)
        {
            zrodlo = okno_zrodla;
            InitializeComponent();

            this.Text = czy_modyfikacja ? "Modyfikacja Notatki" : "Dodawanie Notatki";
            modyfikacja = czy_modyfikacja;
            zapytanie_klienci = zrodlo.polaczenie_do_bazy.CreateCommand();
            zapytanie_dodanie_notatki = zrodlo.polaczenie_do_bazy.CreateCommand();
            adapter_klienci = new SqlDataAdapter(zapytanie_klienci);
            dodanie_notatki = new SqlDataAdapter(zapytanie_dodanie_notatki);
            if (modyfikacja == true)
            {
                zapytanie_klienci.CommandText = "SELECT k.IdKlienta, k.Nazwa FROM Klient k, Notatka n WHERE k.IdKlienta=n.Klient AND n.IdNotatki LIKE '" + zrodlo.dgv_notatki.CurrentRow.Cells["IdNotatki"].FormattedValue + "'";
            }
            else
            {
                zapytanie_klienci.CommandText = "SELECT IdKlienta, Nazwa FROM Klient WHERE Nazwa LIKE '%" + tb_klient_notatka.Text + "%'";
            }
            uzupelnij_formatke();
            tb_tresc_notatki.SelectionStart = tb_tresc_notatki.Text.Length;
        }

        public void uzupelnij_formatke()
        {
            aktualizuj_liste_klientow();
            if (modyfikacja)
            {
                tb_klient_notatka.Text = tabela_klienci.Rows[0][1].ToString();
                tb_tresc_notatki.Text = zrodlo.dgv_notatki.CurrentRow.Cells["Tresc"].FormattedValue.ToString();
                nud_priorytet.Value = int.Parse(zrodlo.dgv_notatki.CurrentRow.Cells["PriorytetNotatki"].FormattedValue.ToString());
            }
            else
            {
                lb_klient_notatka.ClearSelected();
            }
            uzupelnij_oddzwonic();
        }

        private void tb_klient_notatka_TextChanged(object sender, EventArgs e)
        {
            zapytanie_klienci.CommandText = "SELECT IdKlienta, Nazwa FROM Klient WHERE Nazwa LIKE '%" + tb_klient_notatka.Text + "%'";
            aktualizuj_liste_klientow();
        }

        private void aktualizuj_liste_klientow()
        {
            tabela_klienci = new DataTable();
            zrodlo.polaczenie_do_bazy.Open();
            adapter_klienci.Fill(tabela_klienci);
            zrodlo.polaczenie_do_bazy.Close();
            lb_klient_notatka.DataSource = tabela_klienci;
            lb_klient_notatka.DisplayMember = "Nazwa";
            lb_klient_notatka.ValueMember = "IdKlienta";
        }

        private void uzupelnij_oddzwonic()
        {
            cb_oddzwaniac.DataSource = zrodlo.pobierz_elementy_slownika("Oddzwonic", false, 0, "", "");
            cb_oddzwaniac.DisplayMember = "Element";
            cb_oddzwaniac.ValueMember = "IdElementu";
            if (modyfikacja)
            {
                SqlCommand zapytanie_oddzwonic_modyfikacja;
                zapytanie_oddzwonic_modyfikacja = zrodlo.polaczenie_do_bazy.CreateCommand();
                zapytanie_oddzwonic_modyfikacja.CommandText = "SELECT Oddzwonic FROM Notatka WHERE IdNotatki=" + zrodlo.dgv_notatki.CurrentRow.Cells["IdNotatki"].FormattedValue + "";
                SqlDataAdapter oddzwonic_modyfikacja_adapter = new SqlDataAdapter(zapytanie_oddzwonic_modyfikacja);
                DataTable oddzwonic_modyfikacja_table = new DataTable();
                oddzwonic_modyfikacja_adapter.Fill(oddzwonic_modyfikacja_table);
                cb_oddzwaniac.SelectedValue = oddzwonic_modyfikacja_table.Rows[0][0];
            }       
        }

        private void b_zatwierdz_Click(object sender, EventArgs e)
        {
            int id_klienta = 0;
            if (tb_tresc_notatki.Text != "" && (lb_klient_notatka.Text != "" || tb_klient_notatka.Text != ""))
            {
                if (lb_klient_notatka.SelectedValue == null)
                {
                    SqlCommand zapytanie_dodawanie_klienta = zrodlo.polaczenie_do_bazy.CreateCommand();
                    zapytanie_dodawanie_klienta.CommandText = "SET IDENTITY_INSERT Klient ON INSERT INTO Klient (Nazwa, IdKlienta) VALUES ('" + tb_klient_notatka.Text + "', ((SELECT MAX(IdKlienta) FROM Klient)+1)) SET IDENTITY_INSERT Klient OFF";
                    zrodlo.polaczenie_do_bazy.Open();
                    zapytanie_dodawanie_klienta.ExecuteNonQuery();
                    zrodlo.polaczenie_do_bazy.Close();

                    SqlCommand zapytanie_id_klienta = zrodlo.polaczenie_do_bazy.CreateCommand();
                    zapytanie_id_klienta.CommandText = "SELECT IdKlienta FROM Klient WHERE Nazwa = '" + tb_klient_notatka.Text + "'";
                    SqlDataAdapter adapter_id_klienta = new SqlDataAdapter(zapytanie_id_klienta);
                    DataTable tabela_id_klienta = new DataTable();
                    zrodlo.polaczenie_do_bazy.Open();
                    adapter_id_klienta.Fill(tabela_id_klienta);
                    zrodlo.polaczenie_do_bazy.Close();

                    id_klienta = int.Parse(tabela_id_klienta.Rows[0][0].ToString());
                }
                else
                {
                    id_klienta = int.Parse(lb_klient_notatka.SelectedValue.ToString());
                }
                if (modyfikacja)
                {
                    zapytanie_dodanie_notatki.CommandText = "UPDATE Notatka SET Tresc='" + tb_tresc_notatki.Text + "', DataCzasNotki=GETDATE(), Autor='1', PriorytetNotatki='" + nud_priorytet.Value + "', Oddzwonic='" + cb_oddzwaniac.SelectedValue + "', Klient='" + id_klienta + "' WHERE IdNotatki=" + zrodlo.dgv_notatki.CurrentRow.Cells["IdNotatki"].FormattedValue + "";
                }
                else
                {
                    zapytanie_dodanie_notatki.CommandText = "INSERT INTO Notatka (Wpis, Tresc, DataCzasNotki, Autor, PriorytetNotatki, Oddzwonic, Klient) VALUES (" + zrodlo.dgv_wpisy.CurrentRow.Cells["IdWpisu"].FormattedValue.ToString() + ",'" + tb_tresc_notatki.Text + "', GETDATE(), 1, " + nud_priorytet.Value + ", " + cb_oddzwaniac.SelectedValue + ", " + id_klienta + ")";
                }
                zrodlo.polaczenie_do_bazy.Open();
                zapytanie_dodanie_notatki.ExecuteNonQuery();
                zrodlo.polaczenie_do_bazy.Close();
                zrodlo.odswiez_grid_notatek();
                zrodlo.odswierz_dgv_klientow();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Proszę uzupełnić brakujące dane.", "Komunikat");
            }
        }

        private void b_anuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
