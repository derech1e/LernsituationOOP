using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
using LernsituationOOP.de.tnuerk.utils;
using System;
using System.Windows.Forms;

namespace LernsituationOOP
{
    public partial class FrmReservieren : Form
    {
        public FrmReservieren() => InitializeComponent();

        /// <summary>
        /// Es werden die Konstruktoren der Verschieden Klassen mit den jeweiligen Daten gefüllt und anschließend in die Liste der Reservierungen hinzugefügt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservieren_Click(object sender, EventArgs e)
        {
            if (!KannReservieren())
                return;

            Utils.Reservierungen.Add(new Reservierung(
                new Fahrzeug((FahrzeugModell)Enum.Parse(typeof(FahrzeugModell), comboBoxFahrzeuge.SelectedItem.ToString()), FahrzeugStatus.IN_ORDNUNG),
                new Kunde(txtBoxVorName.Text, txtBoxNachName.Text, dTimeGeburtstag.Value, txtBoxAdresse.Text, txtBoxEmail.Text, long.Parse(txtBoxTel.Text), new Random().Next(20000, 100000)),
                dTimeVon.Value, dTimeBis.Value, Prüfungsstatus.IN_BEARBEITUNG, new DateTime(), null));

            MessageBox.Show("Fahrzeug Reserviert!", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        /// <summary>
        /// Dient zur vermeidung von fehlern durch fehlerhafte Eingaben.
        /// </summary>
        /// <returns>Gibt Zurück ob die Reservierierung abgeschlossen werden kann.</returns>
        private bool KannReservieren() => ValidationUtils.IsStringNotNullOrEmpty(txtBoxVorName.Text) && !ValidationUtils.IsStringANumber(txtBoxVorName.Text) &&
            ValidationUtils.IsStringNotNullOrEmpty(txtBoxNachName.Text) && !ValidationUtils.IsStringANumber(txtBoxNachName.Text) &&
            ValidationUtils.IsStringNotNullOrEmpty(txtBoxAdresse.Text) && ValidationUtils.IsOlderThan18(dTimeGeburtstag.Value) && 
            ValidationUtils.IsEmailValid(txtBoxEmail.Text) && ValidationUtils.IsStringANumber(txtBoxTel.Text) && cbFuehrerschein.Checked;

        private void cbFuehrerschein_CheckedChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        private void txtBoxVorName_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        private void txtBoxNachName_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        private void txtBoxAdresse_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        private void txtBoxEmail_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        private void txtBoxTel_TextChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        private void dTimeGeburtstag_ValueChanged(object sender, EventArgs e) => btnReservieren.Enabled = KannReservieren();

        /// <summary>
        /// Das Formular wird mit den entsprechenden Daten der Fahrzeuge gefüllt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReservieren_Load(object sender, EventArgs e)
        {
            foreach (FahrzeugModell modell in Enum.GetValues(typeof(FahrzeugModell)))
            {
                comboBoxFahrzeuge.Items.Add(modell);
            }
            comboBoxFahrzeuge.SelectedIndex = 0;
            dTimeBis.MinDate = dTimeVon.Value.Date.AddDays(1);
            dTimeGeburtstag.MaxDate = new DateTime(DateTime.Today.Year - 18, DateTime.Today.Month, DateTime.Today.Day);
        }

        //private void txtBoxVorName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if(!ValidationUtils.IsStringNotNull(txtBoxVorName.Text) || ValidationUtils.IsStringANumber(txtBoxVorName.Text))
        //    {
        //        e.Cancel = true;
        //        txtBoxVorName.Focus();
        //        errorProvider.SetError(txtBoxVorName, "Bitte gebe einen sinvollen Vornamen ein");
        //    } else
        //    {
        //        e.Cancel = false;
        //        errorProvider.SetError(txtBoxVorName, null);
        //    }
        //}
    }
}
