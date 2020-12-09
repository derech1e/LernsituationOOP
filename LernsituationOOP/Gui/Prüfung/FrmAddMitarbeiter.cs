using System;
using System.Windows.Forms;
using LernsituationOOP.Personen;
using LernsituationOOP.Properties;
using LernsituationOOP.Utils.Validation;

namespace LernsituationOOP.Gui.Prüfung
{
    public partial class FrmAddMitarbeiter : Form
    {
        public FrmAddMitarbeiter()
        {
            InitializeComponent();
            dTimeGeb.MaxDate = DateTime.Today.AddYears(-18).Date;
        }

        /// <summary>
        /// Der Mitarbeiter wird mit den entsprechenden Angaben zur Datenbank hinzugefügt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Mitarbeiter mitarbeiter = new Mitarbeiter(txtBoxVorName.Text, txtBoxNachName.Text, txtBoxAdresse.Text, dTimeGeb.Value, txtBoxEmail.Text, Utils.Utils.GenerateID(), Utils.Utils.EncryptDecryptPassword(txtBoxPW.Text));
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
        private bool KannHinzufügen() => new StringValidation(txtBoxVorName.Text).IsNotNullOrEmpty().ContainsLetter().ContainsNoNumber().ValidateAND() &&
                new StringValidation(txtBoxNachName.Text).IsNotNullOrEmpty().ContainsLetter().ContainsNoNumber().ValidateAND() &&
                new StringValidation(txtBoxAdresse.Text).IsNotNullOrEmpty().ContainsLetter().ContainsNumber().ValidateAND() &&
                new DateValidation(dTimeGeb.Value).IsGreater18().ValidateAND() &&
                new StringValidation(txtBoxEmail.Text).IsNotNullOrEmpty().IsEmail().ValidateAND() &&
                new StringValidation(txtBoxPW.Text).IsNotNullOrEmpty().IsLongerThan(8).ValidateAND();


        /// <summary>Passowrt verstecken</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPWAnzeigen_MouseUp(object sender, MouseEventArgs e) => txtBoxPW.UseSystemPasswordChar = true;

        /// <summary>
        /// Überprüfung, ob Mitarbeiter hinzugefügt werden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxVorName_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        /// <summary>
        /// Überprüfung, ob Mitarbeiter hinzugefügt werden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxNachName_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        /// <summary>
        /// Überprüfung, ob Mitarbeiter hinzugefügt werden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxAdresse_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        /// <summary>
        /// Überprüfung, ob Mitarbeiter hinzugefügt werden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dTimeGeb_ValueChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        /// <summary>
        /// Überprüfung, ob Mitarbeiter hinzugefügt werden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxEmail_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        /// <summary>
        /// Überprüfung, ob Mitarbeiter hinzugefügt werden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxPW_TextChanged(object sender, EventArgs e) => btnAdd.Enabled = KannHinzufügen();

        //UI Validierungen

        /// <summary>
        /// Dient zur UI Validierung
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void txtBoxVorName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender; //Sender wird zur Textbox umgeformt
            if (!new StringValidation(textBox.Text).IsNotNullOrEmpty().ContainsLetter().ContainsNoNumber().ValidateAND()) //Überprüfung ob die Eingabe Validiert werden kann
            {
                e.Cancel = true; //Wenn nein, das Event Canceln und UI Ausgabe mit Text
                errorProvider.SetError(textBox, Resources.validateFirstName); //String wird aus der "Resources.resx" Datei ausgelesen
            }
            else
            {
                e.Cancel = false; //Wenn Ja, dann UI Ausgabe entfernen
                errorProvider.SetError(textBox, null);
            }
        }

        /// <summary>
        /// Dient zur UI Validierung
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void txtBoxNachName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!new StringValidation(textBox.Text).IsNotNullOrEmpty().ContainsLetter().ContainsNoNumber().ValidateAND())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validateLastName); //String wird aus der "Resources.resx" Datei ausgelesen
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }

        /// <summary>
        /// Dient zur UI Validierung
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void txtBoxAdresse_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!new StringValidation(textBox.Text).IsNotNullOrEmpty().ContainsLetter().ContainsNumber().ValidateAND())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validateAdress); //String wird aus der "Resources.resx" Datei ausgelesen
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }

        /// <summary>
        /// Dient zur UI Validierung
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void txtBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!new StringValidation(textBox.Text).IsNotNullOrEmpty().IsEmail().ValidateAND())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validateEmail); //String wird aus der "Resources.resx" Datei ausgelesen
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }

        /// <summary>
        /// Dient zur UI Validierung
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void txtBoxPW_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaskedTextBox textBox = (MaskedTextBox)sender;
            if (!new StringValidation(textBox.Text).IsLongerThan(8).ValidateAND())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validatePW); //String wird aus der "Resources.resx" Datei ausgelesen
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }

        /// <summary>
        /// Dient zur UI Validierung
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void dTimeGeb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;

            if (!new DateValidation(dateTimePicker.Value).IsGreater18().ValidateAND())
            {
                e.Cancel = true;
                errorProvider.SetError(dateTimePicker, Resources.validateAge); //String wird aus der "Resources.resx" Datei ausgelesen
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dateTimePicker, null);
            }

        }
    }
}
