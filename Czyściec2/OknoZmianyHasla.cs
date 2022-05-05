using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Czyściec2
{
    public partial class OknoZmianyHasla : Form
    {
        SqlConnection polaczenie;
        int id_uzytkownika;
        bool czy_z_potwierdzeniem;
        string haslo_dotychczasowe;

        public OknoZmianyHasla(SqlConnection polaczenie_do_bazy, string nick, int id_u, bool czy_z_potwierdzeniem)
        {
            polaczenie = polaczenie_do_bazy;
            InitializeComponent();
            l_nick_wlasciwy.Text = nick;
            id_uzytkownika = id_u;
            this.czy_z_potwierdzeniem = czy_z_potwierdzeniem;
            if (!czy_z_potwierdzeniem)
            {
                tb_hasloDotychczasowe.Enabled = false;
                b_anuluj.Enabled = false;
            }
        }

        private void b_anuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void b_zatwierdz_Click(object sender, EventArgs e)
        {
            SqlCommand zapytanie = polaczenie.CreateCommand();
            zapytanie.CommandText = "SELECT Haslo FROM Autor WHERE IdAutora="+id_uzytkownika+"";
            polaczenie.Open();
            haslo_dotychczasowe = zapytanie.ExecuteScalar().ToString();
            polaczenie.Close();
            if ((wez_hash(tb_hasloDotychczasowe.Text) != haslo_dotychczasowe) && czy_z_potwierdzeniem==true)
            {
                l_komunikat.Visible = true;
                l_komunikat.Text = "Nieprawidłowe hasło dotychczasowe.";
            }
            else if(tb_hasloNowe1.Text != tb_hasloNowe2.Text || tb_hasloNowe1.Text=="" || tb_hasloNowe2.Text=="")
            {
                l_komunikat.Visible = true;
                l_komunikat.Text = "Niezgodność nowego hasła z powtórzonym.";
            }
            else
            {
                l_komunikat.Visible = false;
                zapytanie.CommandText = "UPDATE Autor SET Haslo='"+wez_hash(tb_hasloNowe2.Text)+"' WHERE IdAutora="+id_uzytkownika+"";
                polaczenie.Open();
                zapytanie.ExecuteNonQuery();
                polaczenie.Close();
                this.Hide();
                MessageBox.Show("Hasło zostało zmienione.","Komunikat");
            }
        }

        private string wez_hash(string do_zaszyfrowania)
        {
            SHA512 mojSHA512 = SHA512.Create();
            return BitConverter.ToString(mojSHA512.ComputeHash(Encoding.ASCII.GetBytes(do_zaszyfrowania)));
        }
    }
}
