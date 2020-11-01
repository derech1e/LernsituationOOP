using LernsituationOOP.de.tnuerk.gui.prüfung;
using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.utils;
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
                MessageBox.Show("Der Login ist nicht vorhanden oder die Angeben sind inkorrekt! \n\nBitte legen Sie einen neuen Mitarbeiter an!", "Mitarbeiter nicht gefunden!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            string str = Utils.EncryptDecryptPassword(password);
            foreach (Mitarbeiter mitarbeiter in Utils.Mitarbeiter)
            {
                if (mitarbeiter.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && mitarbeiter.Passwort.Equals(str))
                    return mitarbeiter;
            }
            return null;
        }

        private void txtBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void txtBoxPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
