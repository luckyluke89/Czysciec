namespace Czyściec2
{
    partial class OknoLogowania
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
            this.l_nick = new System.Windows.Forms.Label();
            this.l_haslo = new System.Windows.Forms.Label();
            this.tb_nick = new System.Windows.Forms.TextBox();
            this.tb_haslo = new System.Windows.Forms.TextBox();
            this.b_zaloguj = new System.Windows.Forms.Button();
            this.b_wyjscie = new System.Windows.Forms.Button();
            this.l_komunikat_logowania = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_nick
            // 
            this.l_nick.AutoSize = true;
            this.l_nick.Location = new System.Drawing.Point(42, 15);
            this.l_nick.Name = "l_nick";
            this.l_nick.Size = new System.Drawing.Size(32, 13);
            this.l_nick.TabIndex = 0;
            this.l_nick.Text = "Nick:";
            // 
            // l_haslo
            // 
            this.l_haslo.AutoSize = true;
            this.l_haslo.Location = new System.Drawing.Point(35, 48);
            this.l_haslo.Name = "l_haslo";
            this.l_haslo.Size = new System.Drawing.Size(39, 13);
            this.l_haslo.TabIndex = 1;
            this.l_haslo.Text = "Hasło:";
            // 
            // tb_nick
            // 
            this.tb_nick.Location = new System.Drawing.Point(73, 12);
            this.tb_nick.Name = "tb_nick";
            this.tb_nick.Size = new System.Drawing.Size(149, 20);
            this.tb_nick.TabIndex = 2;
            // 
            // tb_haslo
            // 
            this.tb_haslo.Location = new System.Drawing.Point(73, 45);
            this.tb_haslo.Name = "tb_haslo";
            this.tb_haslo.PasswordChar = '*';
            this.tb_haslo.Size = new System.Drawing.Size(149, 20);
            this.tb_haslo.TabIndex = 3;
            // 
            // b_zaloguj
            // 
            this.b_zaloguj.Location = new System.Drawing.Point(35, 95);
            this.b_zaloguj.Name = "b_zaloguj";
            this.b_zaloguj.Size = new System.Drawing.Size(75, 23);
            this.b_zaloguj.TabIndex = 4;
            this.b_zaloguj.Text = "Zaloguj";
            this.b_zaloguj.UseVisualStyleBackColor = true;
            this.b_zaloguj.Click += new System.EventHandler(this.b_zaloguj_Click);
            // 
            // b_wyjscie
            // 
            this.b_wyjscie.Location = new System.Drawing.Point(147, 95);
            this.b_wyjscie.Name = "b_wyjscie";
            this.b_wyjscie.Size = new System.Drawing.Size(75, 23);
            this.b_wyjscie.TabIndex = 5;
            this.b_wyjscie.Text = "Wyjście";
            this.b_wyjscie.UseVisualStyleBackColor = true;
            this.b_wyjscie.Click += new System.EventHandler(this.b_wyjscie_Click);
            // 
            // l_komunikat_logowania
            // 
            this.l_komunikat_logowania.AutoSize = true;
            this.l_komunikat_logowania.ForeColor = System.Drawing.Color.Red;
            this.l_komunikat_logowania.Location = new System.Drawing.Point(70, 68);
            this.l_komunikat_logowania.Name = "l_komunikat_logowania";
            this.l_komunikat_logowania.Size = new System.Drawing.Size(150, 13);
            this.l_komunikat_logowania.TabIndex = 6;
            this.l_komunikat_logowania.Text = "Nieprawidłowy nick lub hasło.";
            this.l_komunikat_logowania.Visible = false;
            // 
            // OknoLogowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 130);
            this.Controls.Add(this.l_komunikat_logowania);
            this.Controls.Add(this.b_wyjscie);
            this.Controls.Add(this.b_zaloguj);
            this.Controls.Add(this.tb_haslo);
            this.Controls.Add(this.tb_nick);
            this.Controls.Add(this.l_haslo);
            this.Controls.Add(this.l_nick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OknoLogowania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nick;
        private System.Windows.Forms.Label l_haslo;
        private System.Windows.Forms.TextBox tb_nick;
        private System.Windows.Forms.TextBox tb_haslo;
        private System.Windows.Forms.Button b_zaloguj;
        private System.Windows.Forms.Button b_wyjscie;
        private System.Windows.Forms.Label l_komunikat_logowania;
    }
}