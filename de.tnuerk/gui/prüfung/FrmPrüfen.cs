using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
using LernsituationOOP.de.tnuerk.utils;
using System;
using System.Windows.Forms;

namespace LernsituationOOP.de.tnuerk.gui
{
    public partial class FrmPrüfen : Form
    {
        private Mitarbeiter _Mitarbeiter;
        public FrmPrüfen(Mitarbeiter mitarbeiter)
        {
            InitializeComponent();
            _Mitarbeiter = mitarbeiter;
        }

        /// <summary>
        /// Die Reservierungsinformationen(Nachname des Kunden) werden nach dem entsprechendem Index angezeigt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrüfen_Load(object sender, EventArgs e)
        {
            if(Utils.Reservierungen.Count == 0)
            {
                MessageBox.Show("Es sind keine Reservierungen vorhanden!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                return;
            }

            foreach (Reservierung reservierung in Utils.Reservierungen)
            {
                if (reservierung.Prüfungsstatus == Prüfungsstatus.IN_BEARBEITUNG)
                    listBoxEinträge.Items.Add(reservierung.Kunde.Nachname + " - " + reservierung.Kunde.KundenNummer);
            }
        }

        /// <summary>
        /// Der Reservierungsstatus wird auf Angenommen gesetzt über die Methode UpdateStatus(...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (listBoxEinträge.SelectedIndex < 0 || !UpdateStatus(Utils.Reservierungen[listBoxEinträge.SelectedIndex], true))
                return;
            listBoxEinträge.Items.RemoveAt(listBoxEinträge.SelectedIndex);
        }

        /// <summary>
        /// Der Reservierungsstatus wird auf Abgelehnt gesetzt über die Methode UpdateStatus(...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnCheck_Click(object sender, EventArgs e)
        {
            if (listBoxEinträge.SelectedIndex < 0 || !UpdateStatus(Utils.Reservierungen[listBoxEinträge.SelectedIndex], false))
                return;
            listBoxEinträge.Items.RemoveAt(listBoxEinträge.SelectedIndex);
        }

        /// <summary>
        /// Es werden entsprechende Informationen zu dem ausgewähltem Index angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxEinträge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEinträge.SelectedIndex < 0)
                return;
            Reservierung reservierung = Utils.Reservierungen.Find(item => item.Kunde.KundenNummer == int.Parse(listBoxEinträge.GetItemText(listBoxEinträge.SelectedItem).Split('-')[1].ToString()));
            txtBoxResInfos.Clear();
            txtBoxResInfos.Text = Utils.GetReservierungsInfos(reservierung);
        }

        /// <summary>
        /// Der Status der Reservierung kann mit dieser Methode aktualisiert werden
        /// </summary>
        /// <param name="reservierung">Übergiebt die zu ändernde Reservierung</param>
        /// <param name="angenommen">Setzt den Status der Reservierung auf Angenommen oder Abgelehnt</param>
        /// <returns>Gibt den Erfolg der Ausführung zurück</returns>
        private bool UpdateStatus(Reservierung reservierung, bool angenommen)
        {
            Utils.Reservierungen.Remove(reservierung);
            reservierung.Prüfungsstatus = angenommen ? Prüfungsstatus.ANGENOMMEN : Prüfungsstatus.ABGELEHNT;
            reservierung.Prüfungsdatum = new DateTime?(DateTime.Today);
            reservierung.Mitarbeiter = _Mitarbeiter;
            Utils.Reservierungen.Add(reservierung);
            MessageBox.Show("Reservierung bearbeitet!", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if(Utils.ReservierungMitStatusX(Prüfungsstatus.IN_BEARBEITUNG).Count == 0)
            {
                MessageBox.Show("Es sind keine weiteren Reservierungen vorhanden!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            return true;
        }
    }
}
