using LernsituationOOP.de.tnuerk.klassen;
using System;
using LernsituationOOP.de.tnuerk.utils;
using System.Windows.Forms;

namespace LernsituationOOP.de.tnuerk.gui.prüfung
{
    public partial class FrmAddMitarbeiter : Form
    {
        public FrmAddMitarbeiter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Der Mitarbeiter wird mit den entsprechenden Angaben zur Datenbank hinzugefügt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Mitarbeiter mitarbeiter = new Mitarbeiter(txtBoxVorName.Text, txtBoxNachName.Text, txtBoxAdresse.Text, dTimeGeb.Value, txtBoxEmail.Text, Utils.generateID(), Utils.EncryptDecryptPassword(txtBoxPW.Text));
            Utils.Mitarbeiter.Add(mitarbeiter);
            MessageBox.Show("Neuer Mitarbeiter " + mitarbeiter.Vorname + " " + mitarbeiter.Nachname + " wurde erfolgreich hinzugefügt", "Erfolgreich hinzugefügt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        /// <summary>Passwort anzeigen</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPWAnzeigen_MouseDown(object sender, MouseEventArgs e) => this.txtBoxPW.UseSystemPasswordChar = false;

        /// <summary>
        /// Dient zur vermeidung von fehlern durch fehlerhafte Eingaben.
        /// </summary>
        /// <returns>Gibt Zurück ob die Reservierierung abgeschlossen werden kann.</returns>
        private bool KannHinzufügen() => ValidationUtils.IsStringNotNullOrEmpty(this.txtBoxVorName.Text) && !ValidationUtils.IsStringANumber(this.txtBoxVorName.Text) && (ValidationUtils.IsStringNotNullOrEmpty(this.txtBoxNachName.Text) && !ValidationUtils.IsStringANumber(this.txtBoxNachName.Text)) && (ValidationUtils.IsStringNotNullOrEmpty(this.txtBoxAdresse.Text) && ValidationUtils.IsOlderThan18(this.dTimeGeb.Value)) && ValidationUtils.IsEmailValid(this.txtBoxEmail.Text);

        /// <summary>Passowrt verstechken</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPWAnzeigen_MouseUp(object sender, MouseEventArgs e) => this.txtBoxPW.UseSystemPasswordChar = true;

        private void txtBoxVorName_TextChanged(object sender, EventArgs e) => this.btnAdd.Enabled = this.KannHinzufügen();

        private void txtBoxNachName_TextChanged(object sender, EventArgs e) => this.btnAdd.Enabled = this.KannHinzufügen();

        private void txtBoxAdresse_TextChanged(object sender, EventArgs e) => this.btnAdd.Enabled = this.KannHinzufügen();

        private void dTimeGeb_ValueChanged(object sender, EventArgs e) => this.btnAdd.Enabled = this.KannHinzufügen();

        private void txtBoxEmail_TextChanged(object sender, EventArgs e) => this.btnAdd.Enabled = this.KannHinzufügen();

        private void txtBoxPW_TextChanged(object sender, EventArgs e) => this.btnAdd.Enabled = this.KannHinzufügen();

    }
}
