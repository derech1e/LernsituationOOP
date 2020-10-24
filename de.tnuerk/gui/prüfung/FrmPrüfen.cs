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
            foreach (Reservierung reservierung in Utils.Reservierungen)
            {
                if (reservierung.Prüfungsstatus == Prüfungsstatus.IN_BEARBEITUNG)
                    this.listBoxEinträge.Items.Add((object)reservierung.Kunde.Nachname);
            }
        }

        /// <summary>
        /// Der Reservierungsstatus wird auf Angenommen gesetzt über die Methode UpdateStatus(...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (this.listBoxEinträge.SelectedIndex < 0 || !this.UpdateStatus(Utils.Reservierungen[this.listBoxEinträge.SelectedIndex], true))
                return;
            this.listBoxEinträge.Items.RemoveAt(this.listBoxEinträge.SelectedIndex);
        }

        /// <summary>
        /// Der Reservierungsstatus wird auf Abgelehnt gesetzt über die Methode UpdateStatus(...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnCheck_Click(object sender, EventArgs e)
        {
            if (this.listBoxEinträge.SelectedIndex < 0 || !this.UpdateStatus(Utils.Reservierungen[this.listBoxEinträge.SelectedIndex], false))
                return;
            this.listBoxEinträge.Items.RemoveAt(this.listBoxEinträge.SelectedIndex);
        }

        /// <summary>
        /// Es werden entsprechende Informationen zu dem ausgewähltem Index angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxEinträge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxEinträge.SelectedIndex < 0)
                return;
            Reservierung reservierung = Utils.Reservierungen[this.listBoxEinträge.SelectedIndex];
            this.txtBoxResInfos.Clear();
            this.txtBoxResInfos.Text = Utils.GetReservierungsInfos(reservierung);
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
            reservierung.Mitarbeiter = this._Mitarbeiter;
            Utils.Reservierungen.Add(reservierung);
            int num = (int)MessageBox.Show("Reservierung bearbeitet!", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return true;
        }
    }
}
