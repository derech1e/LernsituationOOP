using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LernsituationOOP
{
    public partial class FrmReservieren : Form
    {
        public FrmReservieren()
        {
            InitializeComponent();
            foreach (FahrzeugModell modell in Enum.GetValues(typeof(FahrzeugModell)))
            {
                comboBoxFahrzeuge.Items.Add(modell);
            }
            comboBoxFahrzeuge.SelectedIndex = 0;
        }

        private void btnReservieren_Click(object sender, EventArgs e)
        {
            if (!kannReservieren())
            {
                MessageBox.Show("Bitte überprüfen sie ihre Angaben!", "Fehler!");
                return;
            }
            Fahrzeug fahrzeug = new Fahrzeug((FahrzeugModell)Enum.Parse(typeof(FahrzeugModell), comboBoxFahrzeuge.SelectedItem.ToString()), FahrzeugStatus.IN_ORDNUNG, 0, 200);
            Kunde person = new Kunde(txtBoxName.Text, DateTime.Parse(txtBoxGeburtsdatum.Text), txtBoxAdresse.Text, txtBoxEmail.Text, int.Parse(txtBoxTel.Text), 0, cbFuehrerschein.Checked);

            Reservierung reservierung = new Reservierung(fahrzeug, person, dTimeVon.Value, dTimeBis.Value);

            if (JsonUtils.reservierungHinzufügen(reservierung))
            {
                MessageBox.Show("Reserviert!");
                Close();
            }
            else
            {
                MessageBox.Show(new Exception("Fehler!").Message);
            }
        }

        private bool kannReservieren()
        {
            return !string.IsNullOrEmpty(txtBoxName.Text) && !string.IsNullOrEmpty(txtBoxAdresse.Text) && (string.IsNullOrEmpty(txtBoxEmail.Text) ? false : new MailAddress(txtBoxEmail.Text) != null) &&
                Regex.IsMatch(txtBoxTel.Text, @"^\d+$") && (string.IsNullOrEmpty(txtBoxGeburtsdatum.Text) ? false : DateTime.TryParse(txtBoxGeburtsdatum.Text, out _));
        }
    }
}
