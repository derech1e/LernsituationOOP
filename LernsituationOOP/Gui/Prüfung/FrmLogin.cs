using LernsituationOOP.Personen;
using LernsituationOOP.Properties;
using LernsituationOOP.Utils.Validation;
using System;
using System.Windows.Forms;

namespace LernsituationOOP.Gui.Prüfung
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>Die Ameldung des Mitarbeiters wird versucht</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Mitarbeiter mitarbeiter = IsMitarbeiterAvailable(txtBoxEmail.Text, txtBoxPW.Text);
            if (mitarbeiter != null)
            {
                Dispose();
                new FrmPrüfen(mitarbeiter).ShowDialog();
            }
            else
            {
                MessageBox.Show(Resources.MsgBoxNoLogin, Resources.MsgBoxNoLoginTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtBoxPW.Clear();
            }
        }

        /// <summary>
        /// Öffnet den Dialog zur Registierung eines neuen Mitarbeiters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            new FrmAddMitarbeiter().ShowDialog();
        }

        /// <summary>
        /// Überprüft ob der Mitarbeiter mit den entsprechenden Anmeldedaten in der Datenbank gefunden werden kann.
        /// </summary>
        /// <param name="email">Die E-Mail des Mitarbeiters wird übergeben</param>
        /// <param name="password">Das Passwort des Mitarbeiters wird übergeben</param>
        /// <returns>Gibt den entsprechenden Mitarbeiter zurück, insofern einer gefunden werden konnte.</returns>
        private Mitarbeiter IsMitarbeiterAvailable(string email, string password)
        {
            string str = Utils.Utils.EncryptDecryptPassword(password);
            foreach (Mitarbeiter mitarbeiter in Utils.Utils.Mitarbeiter)
            {
                if (mitarbeiter.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && mitarbeiter.Passwort.Equals(str))
                    return mitarbeiter;
            }
            return null;
        }

        /// <summary>
        /// Bei Enter Eingabe wird der Login Button aufgerufen
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void txtBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        /// <summary>
        /// Bei Enter Eingabe wird der Login Button aufgerufen
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void txtBoxPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        /// <summary>
        /// Dient zur UI Validierung
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void txtBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaskedTextBox textBox = (MaskedTextBox)sender;
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
        private void txtBoxPW_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!new StringValidation(textBox.Text).IsLongerThan(8).ValidateOR())
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, Resources.validatePW);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }

        }
    }
}
