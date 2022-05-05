using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Security.Cryptography;

namespace Czyściec2
{
    public partial class OknoUstawienPolaczenia : Form
    {
        OknoGlowne zrodlo;

        public OknoUstawienPolaczenia(OknoGlowne okno_zrodla)
        {
            zrodlo = okno_zrodla;
            InitializeComponent();
            tb_nazwa_serwera.Text = zrodlo.nazwa_serwera;
            tb_nazwa_instancji.Text = zrodlo.nazwa_instancji;
            tb_nazwa_bazy.Text = zrodlo.nazwa_bazy;
            tb_uzytkownik.Text = zrodlo.nazwa_uzytkownika;
            tb_haslo.Text = zrodlo.haslo_sql;
        }

        private void b_polacz_Click(object sender, EventArgs e)
        {
            if (tb_nazwa_serwera.Text == "" || tb_nazwa_instancji.Text == "" || tb_nazwa_bazy.Text == "" || tb_uzytkownik.Text == "" || tb_haslo.Text == "")
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola", "Komunikat");
            }
            else
            {
                zrodlo.nazwa_serwera = tb_nazwa_serwera.Text.ToString();
                zrodlo.nazwa_instancji= tb_nazwa_instancji.Text.ToString();
                zrodlo.nazwa_bazy = tb_nazwa_bazy.Text.ToString();
                zrodlo.nazwa_uzytkownika = tb_uzytkownik.Text.ToString();
                zrodlo.haslo_sql = tb_haslo.Text.ToString();
                string polaczenie = "Data source=" + zrodlo.nazwa_serwera + "\\" + zrodlo.nazwa_instancji + "; database =" + zrodlo.nazwa_bazy + "; User id=" + zrodlo.nazwa_uzytkownika + "; Password=" + zrodlo.haslo_sql + ";";
                zrodlo.polaczenie_do_bazy = new SqlConnection(@"" + polaczenie + "");

                SqlCommand zapytanie = zrodlo.polaczenie_do_bazy.CreateCommand();
                zapytanie.CommandText = "SELECT * FROM SYSOBJECTS WHERE TYPE = 'U'";
                SqlDataAdapter adapter_test = new SqlDataAdapter(zapytanie);
                DataTable tabela_test = new DataTable();
                try
                {
                    adapter_test.Fill(tabela_test);
                }
                catch(Exception wyjatek)
                {
                    MessageBox.Show(wyjatek.Message);
                }
                if (tabela_test.Rows.Count > 0)
                {
                    zrodlo.generator_polaczenia_i_zapytan(polaczenie);
                    string konfiguracja_do_zapisu = "serwer=" + zrodlo.nazwa_serwera + "\r\ninstancja=" + zrodlo.nazwa_instancji + "\r\nbaza=" + zrodlo.nazwa_bazy + "\r\nuzytkownik=" + zrodlo.nazwa_uzytkownika + "\r\nhaslo=" + zrodlo.zaszyfrowanie(zrodlo.haslo_sql, zrodlo.moj_aes.Key, zrodlo.moj_aes.IV) + "";
                    File.WriteAllText("konfiguracja.txt", konfiguracja_do_zapisu);
                    zrodlo.l_status_serwer.Text = "Połączono z serwerem.";
                    zrodlo.l_status_serwer.ForeColor = Color.Green;
                    zrodlo.logowanie(zrodlo);
                    this.Hide();
                }
            }
        }

        private void b_wyjscie_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void b_stworz_baze_Click(object sender, EventArgs e)
        {
            zrodlo.nazwa_serwera = tb_nazwa_serwera.Text.ToString();
            zrodlo.nazwa_instancji = tb_nazwa_instancji.Text.ToString();
            zrodlo.nazwa_bazy = tb_nazwa_bazy.Text.ToString();
            zrodlo.nazwa_uzytkownika = tb_uzytkownik.Text.ToString();
            zrodlo.haslo_sql = tb_haslo.Text.ToString();
            FileInfo file = new FileInfo("skrypt_BazaCzysciec_aktualny_cz1.sql");
            FileInfo file1 = new FileInfo("skrypt_BazaCzysciec_aktualny_cz2.sql");
            FileInfo file2 = new FileInfo("skrypt_BazaCzysciec_aktualny_cz3.sql");
            FileInfo file3 = new FileInfo("skrypt_BazaCzysciec_aktualny_cz4.sql");
            string skrypt = file.OpenText().ReadToEnd();
            skrypt = skrypt.Replace("BazaCzysciec", zrodlo.nazwa_bazy);
            string skrypt1 = file1.OpenText().ReadToEnd();
            string skrypt2 = file2.OpenText().ReadToEnd();
            string skrypt3 = file3.OpenText().ReadToEnd();
            SqlConnection polaczenie_tworzenia = new SqlConnection("Data source=" + zrodlo.nazwa_serwera + "\\" + zrodlo.nazwa_instancji + "; User id=" + zrodlo.nazwa_uzytkownika + "; Password=" + zrodlo.haslo_sql + ";");
            SqlCommand zapytanie_tworzenia = polaczenie_tworzenia.CreateCommand();
            zapytanie_tworzenia.CommandText = skrypt;
            polaczenie_tworzenia.Open();
            zapytanie_tworzenia.ExecuteNonQuery();
            polaczenie_tworzenia.Close();
            polaczenie_tworzenia = new SqlConnection("Data source=" + zrodlo.nazwa_serwera + "\\" + zrodlo.nazwa_instancji + "; database =" + zrodlo.nazwa_bazy + "; User id=" + zrodlo.nazwa_uzytkownika + "; Password=" + zrodlo.haslo_sql + ";");
            zapytanie_tworzenia = polaczenie_tworzenia.CreateCommand();
            zapytanie_tworzenia.CommandText = skrypt1;
            polaczenie_tworzenia.Open();
            zapytanie_tworzenia.ExecuteNonQuery();
            polaczenie_tworzenia.Close();
            // WIDOKI
            zapytanie_tworzenia = polaczenie_tworzenia.CreateCommand();
            zapytanie_tworzenia.CommandText = skrypt2;
            polaczenie_tworzenia.Open();
            zapytanie_tworzenia.ExecuteNonQuery();
            polaczenie_tworzenia.Close();
            zapytanie_tworzenia = polaczenie_tworzenia.CreateCommand();
            zapytanie_tworzenia.CommandText = skrypt3;
            polaczenie_tworzenia.Open();
            zapytanie_tworzenia.ExecuteNonQuery();
            polaczenie_tworzenia.Close();
            b_stworz_baze.Text = "Baza utworzona";
            b_stworz_baze.Enabled = false;
            b_stworz_baze.BackColor = Color.Green;
        }
    }
}
