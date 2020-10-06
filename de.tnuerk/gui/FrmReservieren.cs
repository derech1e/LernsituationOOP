using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LernsituationOOP
{
    public partial class FrmReservieren : Form
    {
        public FrmReservieren()
        {
            InitializeComponent();
            foreach(FahrzeugModell modell in Enum.GetValues(typeof(FahrzeugModell))) {
                comboBoxFahrzeuge.Items.Add(modell);
            }
        }

        private void btnReservieren_Click(object sender, EventArgs e)
        {
            Fahrzeug fahrzeug = new Fahrzeug((FahrzeugModell)Enum.Parse(typeof(FahrzeugModell), comboBoxFahrzeuge.SelectedItem.ToString()), FahrzeugStatus.IN_ORDNUNG, 0, 200);
            Kunde person = new Kunde(txtBoxName.Text, DateTime.Parse(txtBoxGeburtsdatum.Text), txtBoxAdresse.Text, txtBoxEmail.Text, int.Parse(txtBoxTel.Text), 0, true);

            Reservierung reservierung = new Reservierung(fahrzeug, person, dTimeVon.Value, dTimeBis.Value);
            if(JsonUtils.reservierungHinzufügen(reservierung))
            {
                Close();
            } else
            {
                MessageBox.Show(new Exception("Fehler!").Message);
            }
        }
    }
}
