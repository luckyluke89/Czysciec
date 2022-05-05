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
    public partial class OknoUzytkownicy : Form
    {
        OknoZmianyHasla okno_zmiany_hasla;
        SqlConnection polaczenie;

        public OknoUzytkownicy(SqlConnection polaczenie_do_bazy)
        {
            InitializeComponent();
            polaczenie = polaczenie_do_bazy;
            odswiezDgvUzytkownicy();
        }

        private void odswiezDgvUzytkownicy()
        {
            SqlCommand zapytanie = polaczenie.CreateCommand();
            zapytanie.CommandText = "SELECT IdAutora as Id, Nick, Imie, Nazwisko, Poziom FROM Autor";
            SqlDataAdapter adapter = new SqlDataAdapter(zapytanie);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dgv_uzytkownicy.DataSource = tabela;
            dgv_uzytkownicy.Focus();
        }

        public void dgv_uzytkownicy_CellMouseClick(object sender, EventArgs e)
        {
            if (dgv_uzytkownicy.SelectedRows.Count > 0)
            {
                tb_nick.Text = dgv_uzytkownicy.CurrentRow.Cells["Nick"].FormattedValue.ToString();
                tb_imie.Text = dgv_uzytkownicy.CurrentRow.Cells["Imie"].FormattedValue.ToString();
                tb_nazwisko.Text = dgv_uzytkownicy.CurrentRow.Cells["Nazwisko"].FormattedValue.ToString();
                nud_poziom.Value = int.Parse(dgv_uzytkownicy.CurrentRow.Cells["Poziom"].FormattedValue.ToString());
            }
        }

        private void b_zmianaHasla_Click(object sender, EventArgs e)
        {
            okno_zmiany_hasla = new OknoZmianyHasla(polaczenie, tb_nick.Text, int.Parse(dgv_uzytkownicy.CurrentRow.Cells["Id"].FormattedValue.ToString()), false);
            okno_zmiany_hasla.Show();
        }

        private void b_wyjscie_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void b_usun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy potwierdzasz usunięcie?", "Potwierdź", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                SqlCommand zapytanie = polaczenie.CreateCommand();
                zapytanie.CommandText = "DELETE FROM Autor WHERE IdAutora=" + dgv_uzytkownicy.CurrentRow.Cells["Id"].FormattedValue.ToString() + "";
                polaczenie.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie.Close();
                odswiezDgvUzytkownicy();
            }
        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {
            dgv_uzytkownicy.Enabled = false;
            b_dodaj.Enabled = false;
            b_edytuj.Enabled = false;
            b_usun.Enabled = false;
            tb_nick.Enabled = true;
            tb_nick.Text = "";
            tb_imie.Enabled = true;
            tb_imie.Text = "";
            tb_nazwisko.Enabled = true;
            tb_nazwisko.Text = "";
            nud_poziom.Enabled = true;
            nud_poziom.Value = 1;
            b_zmianaHasla.Enabled = false;
            b_zatwierdz.Enabled = true;
            b_zatwierdz.Text = "Dodaj";
            b_anuluj.Enabled = true;
            b_wyjscie.Enabled = false;
        }

        private void b_edytuj_Click(object sender, EventArgs e)
        {
            dgv_uzytkownicy.Enabled = false;
            b_dodaj.Enabled = false;
            b_edytuj.Enabled = false;
            b_usun.Enabled = false;
            tb_nick.Enabled = true;
            tb_imie.Enabled = true;
            tb_nazwisko.Enabled = true;
            nud_poziom.Enabled = true;
            b_zmianaHasla.Enabled = false;
            b_zatwierdz.Enabled = true;
            b_zatwierdz.Text = "Zatwierdź";
            b_anuluj.Enabled = true;
            b_wyjscie.Enabled = false;
        }

        private void b_anuluj_Click(object sender, EventArgs e)
        {
            dgv_uzytkownicy.Enabled = true;
            b_dodaj.Enabled = true;
            b_edytuj.Enabled = true;
            b_usun.Enabled = true;
            tb_nick.Enabled = false;
            tb_imie.Enabled = false;
            tb_nazwisko.Enabled = false;
            nud_poziom.Enabled = false;
            b_zmianaHasla.Enabled = true;
            b_zatwierdz.Enabled = false;
            b_zatwierdz.Text = "Zatwierdź";
            b_anuluj.Enabled = false;
            b_wyjscie.Enabled = true;
            tb_nick.Text = dgv_uzytkownicy.CurrentRow.Cells["Nick"].FormattedValue.ToString();
            tb_imie.Text = dgv_uzytkownicy.CurrentRow.Cells["Imie"].FormattedValue.ToString();
            tb_nazwisko.Text = dgv_uzytkownicy.CurrentRow.Cells["Nazwisko"].FormattedValue.ToString();
            nud_poziom.Value = int.Parse(dgv_uzytkownicy.CurrentRow.Cells["Poziom"].FormattedValue.ToString());
            dgv_uzytkownicy.Focus();
        }

        private void b_zatwierdz_Click(object sender, EventArgs e)
        {
            if (tb_nick.Text == "" || tb_imie.Text == "" || tb_nazwisko.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujące dane.");
            }
            else
            {
                int nowy_id_autora = 0;
                SqlCommand zapytanie = polaczenie.CreateCommand();
                if (b_zatwierdz.Text == "Dodaj")
                {
                    zapytanie.CommandText = "SELECT (MAX(IdAutora)+1) as nastepny_id FROM Autor";
                    polaczenie.Open();
                    nowy_id_autora = int.Parse(zapytanie.ExecuteScalar().ToString());
                    polaczenie.Close();

                    zapytanie.CommandText = "SET IDENTITY_INSERT Autor ON INSERT INTO Autor (IdAutora, Nick, Imie, Nazwisko, Poziom) VALUES (" + nowy_id_autora+", '"+tb_nick.Text+"', '"+tb_imie.Text+"', '"+tb_nazwisko.Text+"', "+nud_poziom.Value+ ") SET IDENTITY_INSERT Autor OFF";
                }
                else if (b_zatwierdz.Text == "Zatwierdź")
                {
                    zapytanie.CommandText = "UPDATE Autor SET Nick='"+tb_nick.Text+"', Imie='"+tb_imie.Text+"', Nazwisko='"+tb_nazwisko.Text+"', Poziom="+nud_poziom.Value+" WHERE IdAutora="+dgv_uzytkownicy.CurrentRow.Cells["Id"].FormattedValue.ToString()+"";
                }
                polaczenie.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie.Close();

                if (b_zatwierdz.Text == "Dodaj")
                {
                    okno_zmiany_hasla = new OknoZmianyHasla(polaczenie, tb_nick.Text, nowy_id_autora, false);
                    okno_zmiany_hasla.Show();
                }

                dgv_uzytkownicy.Enabled = true;
                b_dodaj.Enabled = true;
                b_edytuj.Enabled = true;
                b_usun.Enabled = true;
                tb_nick.Enabled = false;
                tb_imie.Enabled = false;
                tb_nazwisko.Enabled = false;
                nud_poziom.Enabled = false;
                b_zmianaHasla.Enabled = true;
                b_zatwierdz.Enabled = false;
                b_zatwierdz.Text = "Zatwierdź";
                b_anuluj.Enabled = false;
                b_wyjscie.Enabled = true;
                odswiezDgvUzytkownicy();
            }
        }
    }
}
