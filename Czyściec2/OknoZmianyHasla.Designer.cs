namespace Czyściec2
{
    partial class OknoZmianyHasla
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
            this.tb_hasloDotychczasowe = new System.Windows.Forms.TextBox();
            this.tb_hasloNowe1 = new System.Windows.Forms.TextBox();
            this.tb_hasloNowe2 = new System.Windows.Forms.TextBox();
            this.l_hasloDotychczasowe = new System.Windows.Forms.Label();
            this.l_hasloNowe1 = new System.Windows.Forms.Label();
            this.l_hasloNowe2 = new System.Windows.Forms.Label();
            this.l_nick = new System.Windows.Forms.Label();
            this.b_zatwierdz = new System.Windows.Forms.Button();
            this.b_anuluj = new System.Windows.Forms.Button();
            this.l_komunikat = new System.Windows.Forms.Label();
            this.l_nick_wlasciwy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_hasloDotychczasowe
            // 
            this.tb_hasloDotychczasowe.Location = new System.Drawing.Point(166, 25);
            this.tb_hasloDotychczasowe.Name = "tb_hasloDotychczasowe";
            this.tb_hasloDotychczasowe.PasswordChar = '*';
            this.tb_hasloDotychczasowe.Size = new System.Drawing.Size(140, 20);
            this.tb_hasloDotychczasowe.TabIndex = 0;
            // 
            // tb_hasloNowe1
            // 
            this.tb_hasloNowe1.Location = new System.Drawing.Point(166, 51);
            this.tb_hasloNowe1.Name = "tb_hasloNowe1";
            this.tb_hasloNowe1.PasswordChar = '*';
            this.tb_hasloNowe1.Size = new System.Drawing.Size(140, 20);
            this.tb_hasloNowe1.TabIndex = 1;
            // 
            // tb_hasloNowe2
            // 
            this.tb_hasloNowe2.Location = new System.Drawing.Point(166, 77);
            this.tb_hasloNowe2.Name = "tb_hasloNowe2";
            this.tb_hasloNowe2.PasswordChar = '*';
            this.tb_hasloNowe2.Size = new System.Drawing.Size(140, 20);
            this.tb_hasloNowe2.TabIndex = 2;
            // 
            // l_hasloDotychczasowe
            // 
            this.l_hasloDotychczasowe.AutoSize = true;
            this.l_hasloDotychczasowe.Location = new System.Drawing.Point(44, 28);
            this.l_hasloDotychczasowe.Name = "l_hasloDotychczasowe";
            this.l_hasloDotychczasowe.Size = new System.Drawing.Size(116, 13);
            this.l_hasloDotychczasowe.TabIndex = 3;
            this.l_hasloDotychczasowe.Text = "Hasło dotychczasowe:";
            // 
            // l_hasloNowe1
            // 
            this.l_hasloNowe1.AutoSize = true;
            this.l_hasloNowe1.Location = new System.Drawing.Point(92, 54);
            this.l_hasloNowe1.Name = "l_hasloNowe1";
            this.l_hasloNowe1.Size = new System.Drawing.Size(68, 13);
            this.l_hasloNowe1.TabIndex = 4;
            this.l_hasloNowe1.Text = "Nowe hasło:";
            // 
            // l_hasloNowe2
            // 
            this.l_hasloNowe2.AutoSize = true;
            this.l_hasloNowe2.Location = new System.Drawing.Point(53, 80);
            this.l_hasloNowe2.Name = "l_hasloNowe2";
            this.l_hasloNowe2.Size = new System.Drawing.Size(107, 13);
            this.l_hasloNowe2.TabIndex = 5;
            this.l_hasloNowe2.Text = "Powtórz nowe hasło:";
            // 
            // l_nick
            // 
            this.l_nick.AutoSize = true;
            this.l_nick.Location = new System.Drawing.Point(125, 9);
            this.l_nick.Name = "l_nick";
            this.l_nick.Size = new System.Drawing.Size(35, 13);
            this.l_nick.TabIndex = 6;
            this.l_nick.Text = "Nick: ";
            // 
            // b_zatwierdz
            // 
            this.b_zatwierdz.Location = new System.Drawing.Point(36, 123);
            this.b_zatwierdz.Name = "b_zatwierdz";
            this.b_zatwierdz.Size = new System.Drawing.Size(75, 23);
            this.b_zatwierdz.TabIndex = 7;
            this.b_zatwierdz.Text = "Zatwierdź";
            this.b_zatwierdz.UseVisualStyleBackColor = true;
            this.b_zatwierdz.Click += new System.EventHandler(this.b_zatwierdz_Click);
            // 
            // b_anuluj
            // 
            this.b_anuluj.Location = new System.Drawing.Point(231, 123);
            this.b_anuluj.Name = "b_anuluj";
            this.b_anuluj.Size = new System.Drawing.Size(75, 23);
            this.b_anuluj.TabIndex = 8;
            this.b_anuluj.Text = "Anuluj";
            this.b_anuluj.UseVisualStyleBackColor = true;
            this.b_anuluj.Click += new System.EventHandler(this.b_anuluj_Click);
            // 
            // l_komunikat
            // 
            this.l_komunikat.AutoSize = true;
            this.l_komunikat.ForeColor = System.Drawing.Color.Red;
            this.l_komunikat.Location = new System.Drawing.Point(36, 107);
            this.l_komunikat.Name = "l_komunikat";
            this.l_komunikat.Size = new System.Drawing.Size(24, 13);
            this.l_komunikat.TabIndex = 9;
            this.l_komunikat.Text = "test";
            this.l_komunikat.Visible = false;
            // 
            // l_nick_wlasciwy
            // 
            this.l_nick_wlasciwy.AutoSize = true;
            this.l_nick_wlasciwy.Location = new System.Drawing.Point(166, 9);
            this.l_nick_wlasciwy.Name = "l_nick_wlasciwy";
            this.l_nick_wlasciwy.Size = new System.Drawing.Size(27, 13);
            this.l_nick_wlasciwy.TabIndex = 10;
            this.l_nick_wlasciwy.Text = "nick";
            // 
            // OknoZmianyHasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 162);
            this.Controls.Add(this.l_nick_wlasciwy);
            this.Controls.Add(this.l_komunikat);
            this.Controls.Add(this.b_anuluj);
            this.Controls.Add(this.b_zatwierdz);
            this.Controls.Add(this.l_nick);
            this.Controls.Add(this.l_hasloNowe2);
            this.Controls.Add(this.l_hasloNowe1);
            this.Controls.Add(this.l_hasloDotychczasowe);
            this.Controls.Add(this.tb_hasloNowe2);
            this.Controls.Add(this.tb_hasloNowe1);
            this.Controls.Add(this.tb_hasloDotychczasowe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OknoZmianyHasla";
            this.Text = "Zmiana hasła użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_hasloDotychczasowe;
        private System.Windows.Forms.TextBox tb_hasloNowe1;
        private System.Windows.Forms.TextBox tb_hasloNowe2;
        private System.Windows.Forms.Label l_hasloDotychczasowe;
        private System.Windows.Forms.Label l_hasloNowe1;
        private System.Windows.Forms.Label l_hasloNowe2;
        private System.Windows.Forms.Label l_nick;
        private System.Windows.Forms.Button b_zatwierdz;
        private System.Windows.Forms.Button b_anuluj;
        private System.Windows.Forms.Label l_komunikat;
        private System.Windows.Forms.Label l_nick_wlasciwy;
    }
}