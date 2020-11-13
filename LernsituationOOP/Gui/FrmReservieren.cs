using LernsituationOOP.Personen;
using LernsituationOOP.Properties;
using LernsituationOOP.Utils;
using LernsituationOOP.Utils.Validation;
using LernsituationOOP.Vermietung;
using System;
using System.Windows.Forms;

namespace LernsituationOOP.Gui
{
    public partial class FrmReservieren : Form
    {
        public FrmReservieren() => InitializeComponent();

        /// <summary>
        /// Das Formular wird mit den entsprechenden Daten der Fahrzeuge gefüllt.
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void FrmReservieren_Load(object sender, EventArgs e)
        {

            comboBoxFahrzeuge.Items.AddRange(Enum.GetNames(typeof(FahrzeugModell)));
            comboBoxFahrzeuge.SelectedIndex = 0;
            dTimeBis.MinDate = dTimeVon.Value.Date.AddDays(1);
            dTimeGeburtstag.MaxDate = new DateTime(DateTime.Today.Year - 18, DateTime.Today.Month, DateTime.Today.Day);
        }

        /// <summary>
        /// Es werden die Konstruktoren der Verschieden Klassen mit den jeweiligen Daten gefüllt und anschließend in die Liste der Reservierungen hinzugefügt
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void BtnReservieren_Click(object sender, EventArgs e)
        {
            if (!KannReservieren())
                return;

            Utils.Utils.Reservierungen.Add(new Reservierung(
                new Fahrzeug((FahrzeugModell)Enum.Parse(typeof(FahrzeugModell), comboBoxFahrzeuge.SelectedItem.ToString()), FahrzeugStatus.IN_ORDNUNG),
                new Kunde(txtBoxVorName.Text, txtBoxNachName.Text, dTimeGeburtstag.Value, txtBoxAdresse.Text, txtBoxEmail.Text, long.Parse(txtBoxTel.Text), new Random().Next(20000, 100000)),
                dTimeVon.Value, dTimeBis.Value, Prüfungsstatus.IN_BEARBEITUNG, new DateTime(), null));

            MessageBox.Show(Resources.MsgBoxRes, Resources.MsgBoxTitle_ABGESCHLOSSEN, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        /// <summary>
        /// Dient zur vermeidung von fehlern durch fehlerhafte Eingaben.
        /// </summary>
        /// <returns>Gibt Zurück ob die Reservierierung abgeschlossen werden kann.</returns>
        private bool KannReservieren() => new StringValidation(txtBoxVorName.Text).IsNotNullOrEmpty().ContainsLetters().ValidateAND() &&
                new StringValidation(txtBoxNachName.Text).IsNotNullOrEmpty().ContainsLetters().ValidateAND() &&
                new StringValidation(txtBoxAdresse.Text).IsNotNullOrEmpty().ContainsLetters().ContainsNumber().ValidateAND() &&
                new DateValidation(dTimeGeburtstag.Value).IsGreater18().ValidateAND() &&
                new StringValidation(txtBoxEmail.Text).IsNotNullOrEmpty().IsEmail().ValidateAND() &&
                new StringValidation(txtBoxTel.Text).IsNotNullOrEmpty().ContainsNumber().ValidateAND() &&
                cbFuehrerschein.Checked;

        /// <summary>
        /// Überprüfung, ob Reservierung hinzugefügt werden kann
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void CbFuehrerschein_CheckedChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        /// <summary>
        /// Überprüfung, ob Reservierung hinzugefügt werden kann
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void TxtBoxVorName_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        /// <summary>
        /// Überprüfung, ob Reservierung hinzugefügt werden kann
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void TxtBoxNachName_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        /// <summary>
        /// Überprüfung, ob Reservierung hinzugefügt werden kann
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void TxtBoxAdresse_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        /// <summary>
        /// Überprüfung, ob Reservierung hinzugefügt werden kann
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void TxtBoxEmail_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        /// <summary>
        /// Überprüfung, ob Reservierung hinzugefügt werden kann
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void TxtBoxTel_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        /// <summary>
        /// Überprüfung, ob Reservierung hinzugefügt werden kann
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void DTimeGeburtstag_ValueChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        //UI Validierungen
        /// <summary>
        /// Dient zur UI Validierung
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void TxtBoxVorName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!new StringValidation(textBox.Text).IsNullOrEmpty().ContainsLetters().ValidateOR())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validateFirstName);
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
        private void txtBoxNachName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!new StringValidation(textBox.Text).IsNullOrEmpty().ContainsLetters().ValidateOR())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validateLastName);
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
            if (!new StringValidation(textBox.Text.Trim()).IsNullOrEmpty().ContainsNumber().ValidateOR())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validateAdress);
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
            if (!new StringValidation(textBox.Text).IsNullOrEmpty().IsEmail().ValidateOR())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validateEmail);
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
        private void txtBoxTel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!new StringValidation(textBox.Text).IsNullOrEmpty().ContainsNumber().ValidateOR())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validatePhoneNumber);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }
    }
}
