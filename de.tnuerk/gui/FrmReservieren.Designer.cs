namespace LernsituationOOP
{
    partial class FrmReservieren
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
            this.btnReservieren = new System.Windows.Forms.Button();
            this.txtBoxVorName = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.lblReservierenVon = new System.Windows.Forms.Label();
            this.lblReservierenBis = new System.Windows.Forms.Label();
            this.dTimeVon = new System.Windows.Forms.DateTimePicker();
            this.dTimeBis = new System.Windows.Forms.DateTimePicker();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.cbFuehrerschein = new System.Windows.Forms.CheckBox();
            this.gBoxPersoenlich = new System.Windows.Forms.GroupBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.dTimeGeburtstag = new System.Windows.Forms.DateTimePicker();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGeb = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.gBoxReservierung = new System.Windows.Forms.GroupBox();
            this.comboBoxFahrzeuge = new System.Windows.Forms.ComboBox();
            this.lblFahrzeug = new System.Windows.Forms.Label();
            this.txtBoxNachName = new System.Windows.Forms.TextBox();
            this.gBoxPersoenlich.SuspendLayout();
            this.gBoxReservierung.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReservieren
            // 
            this.btnReservieren.Enabled = false;
            this.btnReservieren.Location = new System.Drawing.Point(12, 421);
            this.btnReservieren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservieren.Name = "btnReservieren";
            this.btnReservieren.Size = new System.Drawing.Size(209, 35);
            this.btnReservieren.TabIndex = 0;
            this.btnReservieren.Text = "Reservieren";
            this.btnReservieren.UseVisualStyleBackColor = true;
            this.btnReservieren.Click += new System.EventHandler(this.btnReservieren_Click);
            // 
            // txtBoxVorName
            // 
            this.txtBoxVorName.Location = new System.Drawing.Point(106, 25);
            this.txtBoxVorName.Name = "txtBoxVorName";
            this.txtBoxVorName.Size = new System.Drawing.Size(147, 26);
            this.txtBoxVorName.TabIndex = 1;
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(106, 57);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(312, 26);
            this.txtBoxAdresse.TabIndex = 2;
            // 
            // lblReservierenVon
            // 
            this.lblReservierenVon.AutoSize = true;
            this.lblReservierenVon.Location = new System.Drawing.Point(6, 95);
            this.lblReservierenVon.Name = "lblReservierenVon";
            this.lblReservierenVon.Size = new System.Drawing.Size(127, 20);
            this.lblReservierenVon.TabIndex = 6;
            this.lblReservierenVon.Text = "Reservieren von:";
            // 
            // lblReservierenBis
            // 
            this.lblReservierenBis.AutoSize = true;
            this.lblReservierenBis.Location = new System.Drawing.Point(6, 129);
            this.lblReservierenBis.Name = "lblReservierenBis";
            this.lblReservierenBis.Size = new System.Drawing.Size(122, 20);
            this.lblReservierenBis.TabIndex = 7;
            this.lblReservierenBis.Text = "Reservieren bis:";
            // 
            // dTimeVon
            // 
            this.dTimeVon.Location = new System.Drawing.Point(139, 95);
            this.dTimeVon.Name = "dTimeVon";
            this.dTimeVon.Size = new System.Drawing.Size(279, 26);
            this.dTimeVon.TabIndex = 8;
            // 
            // dTimeBis
            // 
            this.dTimeBis.Location = new System.Drawing.Point(139, 124);
            this.dTimeBis.Name = "dTimeBis";
            this.dTimeBis.Size = new System.Drawing.Size(279, 26);
            this.dTimeBis.TabIndex = 9;
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbrechen.Location = new System.Drawing.Point(229, 421);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(230, 35);
            this.btnAbbrechen.TabIndex = 10;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // cbFuehrerschein
            // 
            this.cbFuehrerschein.AutoSize = true;
            this.cbFuehrerschein.Location = new System.Drawing.Point(6, 196);
            this.cbFuehrerschein.Name = "cbFuehrerschein";
            this.cbFuehrerschein.Size = new System.Drawing.Size(230, 24);
            this.cbFuehrerschein.TabIndex = 11;
            this.cbFuehrerschein.Text = "Ich habe einen Führerschein";
            this.cbFuehrerschein.UseVisualStyleBackColor = true;
            this.cbFuehrerschein.CheckedChanged += new System.EventHandler(this.cbFuehrerschein_CheckedChanged);
            // 
            // gBoxPersoenlich
            // 
            this.gBoxPersoenlich.Controls.Add(this.txtBoxNachName);
            this.gBoxPersoenlich.Controls.Add(this.txtBoxTel);
            this.gBoxPersoenlich.Controls.Add(this.dTimeGeburtstag);
            this.gBoxPersoenlich.Controls.Add(this.lblTel);
            this.gBoxPersoenlich.Controls.Add(this.lblEmail);
            this.gBoxPersoenlich.Controls.Add(this.lblGeb);
            this.gBoxPersoenlich.Controls.Add(this.lblAdresse);
            this.gBoxPersoenlich.Controls.Add(this.lblName);
            this.gBoxPersoenlich.Controls.Add(this.txtBoxVorName);
            this.gBoxPersoenlich.Controls.Add(this.cbFuehrerschein);
            this.gBoxPersoenlich.Controls.Add(this.txtBoxAdresse);
            this.gBoxPersoenlich.Controls.Add(this.txtBoxEmail);
            this.gBoxPersoenlich.Location = new System.Drawing.Point(12, 14);
            this.gBoxPersoenlich.Name = "gBoxPersoenlich";
            this.gBoxPersoenlich.Size = new System.Drawing.Size(442, 229);
            this.gBoxPersoenlich.TabIndex = 13;
            this.gBoxPersoenlich.TabStop = false;
            this.gBoxPersoenlich.Text = "Persönliche Angaben";
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(106, 156);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(312, 26);
            this.txtBoxTel.TabIndex = 18;
            // 
            // dTimeGeburtstag
            // 
            this.dTimeGeburtstag.Location = new System.Drawing.Point(106, 89);
            this.dTimeGeburtstag.Name = "dTimeGeburtstag";
            this.dTimeGeburtstag.Size = new System.Drawing.Size(312, 26);
            this.dTimeGeburtstag.TabIndex = 4;
            this.dTimeGeburtstag.ValueChanged += new System.EventHandler(this.dTimeGeburtstag_ValueChanged);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(34, 156);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(66, 20);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "Telefon:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblGeb
            // 
            this.lblGeb.AutoSize = true;
            this.lblGeb.Location = new System.Drawing.Point(6, 92);
            this.lblGeb.Name = "lblGeb";
            this.lblGeb.Size = new System.Drawing.Size(94, 20);
            this.lblGeb.TabIndex = 14;
            this.lblGeb.Text = "Geburtstag:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(28, 60);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(72, 20);
            this.lblAdresse.TabIndex = 13;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(106, 121);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(312, 26);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // gBoxReservierung
            // 
            this.gBoxReservierung.Controls.Add(this.comboBoxFahrzeuge);
            this.gBoxReservierung.Controls.Add(this.lblFahrzeug);
            this.gBoxReservierung.Controls.Add(this.lblReservierenVon);
            this.gBoxReservierung.Controls.Add(this.lblReservierenBis);
            this.gBoxReservierung.Controls.Add(this.dTimeVon);
            this.gBoxReservierung.Controls.Add(this.dTimeBis);
            this.gBoxReservierung.Location = new System.Drawing.Point(12, 249);
            this.gBoxReservierung.Name = "gBoxReservierung";
            this.gBoxReservierung.Size = new System.Drawing.Size(442, 164);
            this.gBoxReservierung.TabIndex = 14;
            this.gBoxReservierung.TabStop = false;
            this.gBoxReservierung.Text = "Reservierung";
            // 
            // comboBoxFahrzeuge
            // 
            this.comboBoxFahrzeuge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFahrzeuge.FormattingEnabled = true;
            this.comboBoxFahrzeuge.Location = new System.Drawing.Point(10, 45);
            this.comboBoxFahrzeuge.Name = "comboBoxFahrzeuge";
            this.comboBoxFahrzeuge.Size = new System.Drawing.Size(223, 28);
            this.comboBoxFahrzeuge.TabIndex = 14;
            // 
            // lblFahrzeug
            // 
            this.lblFahrzeug.AutoSize = true;
            this.lblFahrzeug.Location = new System.Drawing.Point(6, 22);
            this.lblFahrzeug.Name = "lblFahrzeug";
            this.lblFahrzeug.Size = new System.Drawing.Size(102, 20);
            this.lblFahrzeug.TabIndex = 13;
            this.lblFahrzeug.Text = "Fahrzeugtyp:";
            // 
            // txtBoxNachName
            // 
            this.txtBoxNachName.Location = new System.Drawing.Point(259, 25);
            this.txtBoxNachName.Name = "txtBoxNachName";
            this.txtBoxNachName.Size = new System.Drawing.Size(159, 26);
            this.txtBoxNachName.TabIndex = 19;
            // 
            // FrmReservieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbbrechen;
            this.ClientSize = new System.Drawing.Size(472, 465);
            this.Controls.Add(this.gBoxReservierung);
            this.Controls.Add(this.gBoxPersoenlich);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnReservieren);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReservieren";
            this.ShowInTaskbar = false;
            this.Text = "FrmReservieren";
            this.TopMost = true;
            this.gBoxPersoenlich.ResumeLayout(false);
            this.gBoxPersoenlich.PerformLayout();
            this.gBoxReservierung.ResumeLayout(false);
            this.gBoxReservierung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservieren;
        private System.Windows.Forms.TextBox txtBoxVorName;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.Label lblReservierenVon;
        private System.Windows.Forms.Label lblReservierenBis;
        private System.Windows.Forms.DateTimePicker dTimeVon;
        private System.Windows.Forms.DateTimePicker dTimeBis;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.CheckBox cbFuehrerschein;
        private System.Windows.Forms.GroupBox gBoxPersoenlich;
        private System.Windows.Forms.GroupBox gBoxReservierung;
        private System.Windows.Forms.Label lblFahrzeug;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGeb;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox comboBoxFahrzeuge;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxNachName;
        private System.Windows.Forms.DateTimePicker dTimeGeburtstag;
    }
}