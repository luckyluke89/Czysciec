using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Czyściec2
{
    public partial class OknoLogowania : Form
    {
        private OknoGlowne zrodlo;

        public OknoLogowania(OknoGlowne okno_zrodla)
        {
            InitializeComponent();
            this.zrodlo = okno_zrodla;
        }

        private void b_wyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_zaloguj_Click(object sender, EventArgs e)
        {
            SqlCommand zapytanie = zrodlo.polaczenie_do_bazy.CreateCommand();
            zapytanie.CommandText = "SELECT IdAutora, Nick, Imie, Nazwisko, Poziom FROM Autor WHERE Nick='" + tb_nick.Text+ "' AND Haslo='" + wez_hash(tb_haslo.Text) + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(zapytanie);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            if (tabela.Rows.Count == 1)
            {
                zrodlo.id_uzytkownika = int.Parse(tabela.Rows[0]["IdAutora"].ToString());
                zrodlo.imie_uzytkownika = tabela.Rows[0]["Imie"].ToString();
                zrodlo.nazwa_uzytkownika = tabela.Rows[0]["Nazwisko"].ToString();
                zrodlo.nick = tabela.Rows[0]["Nick"].ToString();
                zrodlo.l_status_logowanie.Text = "Zalogowany " + tabela.Rows[0]["Imie"].ToString() + " " + tabela.Rows[0]["Nazwisko"].ToString();
                zrodlo.l_status_logowanie.ForeColor = Color.Green;
                zrodlo.tc_zakladki_okno_glowne.Enabled = true;
                zrodlo.wypelnij_datagridy();
                zrodlo.wypelnij_comboboxy_wyszukiwania();
                zrodlo.wypelnij_zakladke_slownikow();
                zrodlo.zmianaHaslaToolStripMenuItem.Enabled = true;
                l_komunikat_logowania.Visible = false;
                zrodlo.uzytkownicyToolStripMenuItem.Visible = tabela.Rows[0]["Poziom"].ToString() == "0" ? true : false;
                this.Hide();
            }
            else
            {
                l_komunikat_logowania.Visible = true;
            }
        }

        private string wez_hash(string do_zaszyfrowania)
        {
            SHA512 mojSHA512 = SHA512.Create();
            return BitConverter.ToString(mojSHA512.ComputeHash(Encoding.ASCII.GetBytes(do_zaszyfrowania)));
        }
    }
}
