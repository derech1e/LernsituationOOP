using System;
using System.Windows.Forms;
using LernsituationOOP.Personen;
using LernsituationOOP.Utils;
using LernsituationOOP.Utils.Validation;

namespace LernsituationOOP.Gui.Prüfung
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
            Utils.Utils.Mitarbeiter.Add(mitarbeiter);
            MessageBox.Show("Neuer Mitarbeiter " + mitarbeiter.Vorname + " " + mitarbeiter.Nachname + " wurde erfolgreich hinzugefügt", "Erfolgreich hinzugefügt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        /// <summary>Passwort anzeigen</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPWAnzeigen_MouseDown(object sender, MouseEventArgs e) => txtBoxPW.UseSystemPasswordChar = false;

        /// <summary>
        /// Dient zur vermeidung von fehlern durch fehlerhafte Eingaben.
        /// </summary>
        /// <returns>Gibt Zurück ob die Reservierierung abgeschlossen werden kann.</returns>
        private bool KannHinzufügen() => ValidationUtils.IsStringNotNullOrEmpty(txtBoxVorName.Text) &&
            !ValidationUtils.IsStringANumber(txtBoxVorName.Text) &&
            (ValidationUtils.IsStringNotNullOrEmpty(txtBoxNachName.Text) &&
            !ValidationUtils.IsStringANumber(txtBoxNachName.Text)) &&
            (ValidationUtils.IsStringNotNullOrEmpty(txtBoxAdresse.Text) &&
            ValidationUtils.IsOlderThan18(dTimeGeb.Value)) &&
            ValidationUtils.IsEmailValid(txtBoxEmail.Text, false);

        /// <summary>Passowrt verstechken</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPWAnzeigen_MouseUp(object sender, MouseEventArgs e) => txtBoxPW.UseSystemPasswordChar = true;

        private void txtBoxVorName_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        private void txtBoxNachName_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        private void txtBoxAdresse_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        private void dTimeGeb_ValueChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        private void txtBoxEmail_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        private void txtBoxPW_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

    }
}
