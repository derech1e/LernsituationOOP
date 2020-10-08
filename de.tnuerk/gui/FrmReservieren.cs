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
                return;
            
            Fahrzeug fahrzeug = new Fahrzeug((FahrzeugModell)Enum.Parse(typeof(FahrzeugModell), comboBoxFahrzeuge.SelectedItem.ToString()), FahrzeugStatus.IN_ORDNUNG);
            Kunde person = new Kunde(txtBoxName.Text, DateTime.Parse(txtBoxGeburtsdatum.Text), txtBoxAdresse.Text, txtBoxEmail.Text, int.Parse(txtBoxTel.Text), new Random().Next(20000,100000), cbFuehrerschein.Checked);

            Reservierung reservierung = new Reservierung(fahrzeug, person, dTimeVon.Value, dTimeBis.Value);

            if (JsonUtils.reservierungHinzufügen(reservierung))
            {
                MessageBox.Show("Fahrzeug Reserviert!");
                Close();
            }
            else
            {
                MessageBox.Show(new Exception("Fehler!").Message);
            }
        }

        private bool kannReservieren()
        {
            if (string.IsNullOrEmpty(txtBoxName.Text))
            {
                MessageBox.Show("Bitte geben Sie einen Namen an!");
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxAdresse.Text))
            {
                MessageBox.Show("Bitte geben Sie eine Adresse an!");
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxGeburtsdatum.Text))
            {
                MessageBox.Show("Bitte geben Sie ihr Geburtsdatum an!");
                return false;
            }
            else
            {
                if (!DateTime.TryParse(txtBoxGeburtsdatum.Text, out _))
                {
                    MessageBox.Show("Bitte geben Sie ihr Geburtsdatum in einem Gültigen Format an!");
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtBoxEmail.Text))
            {
                MessageBox.Show("Bitte geben Sie eine E-Mail an!");
                return false;
            }
            else
            {
                try
                {
                    new MailAddress(txtBoxEmail.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Bitte geben Sie eine gültige E-Mail an!");
                    return false;
                }
            }
            if (!Regex.IsMatch(txtBoxTel.Text, @"^\d+$"))
            {
                MessageBox.Show("Bitte geben Sie eine Telefonnummer an!");
                return false;
            }
            if(dTimeVon.Value.Date == dTimeBis.Value.Date)
            {
                MessageBox.Show("Ein Auto muss mindestens 1 Tag gemietet werden!");
                return false;
            }
            return true;
        }

        private void cbFuehrerschein_CheckedChanged(object sender, EventArgs e)
        {
            btnReservieren.Enabled = cbFuehrerschein.Checked;
        }
    }
}
