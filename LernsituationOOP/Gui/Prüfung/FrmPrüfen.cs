using LernsituationOOP.Personen;
using LernsituationOOP.Properties;
using LernsituationOOP.Utils;
using LernsituationOOP.Vermietung;
using System;
using System.Windows.Forms;

namespace LernsituationOOP.Gui.Prüfung
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
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void FrmPrüfen_Load(object sender, EventArgs e)
        {
            if (Utils.Utils.Reservierungen.Count == 0)
            {
                MessageBox.Show(Resources.MsgBoxNoRes, Resources.MsgBoxTitle_ACHTUNG, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Dispose();
                return;
            }

            foreach (Reservierung reservierung in Utils.Utils.Reservierungen)
            {
                if (reservierung.Prüfungsstatus == Prüfungsstatus.IN_BEARBEITUNG)
                    listBoxEinträge.Items.Add(reservierung.Kunde.KundenNummer);
            }
        }

        /// <summary>
        /// Der Reservierungsstatus wird auf Angenommen gesetzt über die Methode UpdateStatus(...)
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (listBoxEinträge.SelectedIndex < 0 ||
                !UpdateStatus(Utils.Utils.Reservierungen[listBoxEinträge.SelectedIndex], true))
                return;
            listBoxEinträge.Items.RemoveAt(listBoxEinträge.SelectedIndex);
        }

        /// <summary>
        /// Der Reservierungsstatus wird auf Abgelehnt gesetzt über die Methode UpdateStatus(...)
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void btnUnCheck_Click(object sender, EventArgs e)
        {
            if (listBoxEinträge.SelectedIndex < 0 ||
                !UpdateStatus(Utils.Utils.Reservierungen[listBoxEinträge.SelectedIndex], false))
                return;
            listBoxEinträge.Items.RemoveAt(listBoxEinträge.SelectedIndex);
        }

        /// <summary>
        /// Es werden entsprechende Informationen zu dem ausgewähltem Index angezeigt
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void listBoxEinträge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEinträge.SelectedIndex < 0)
                return;
            Reservierung reservierung = Utils.Utils.Reservierungen.Find(item =>
                item.Kunde.KundenNummer == int.Parse(listBoxEinträge.GetItemText(listBoxEinträge.SelectedItem)));
            txtBoxResInfos.Clear();
            txtBoxResInfos.Text = Utils.Utils.GetReservierungsInfos(reservierung);
        }

        /// <summary>
        /// Der Status der Reservierung kann mit dieser Methode aktualisiert werden
        /// </summary>
        /// <param name="reservierung">Übergiebt die zu ändernde Reservierung</param>
        /// <param name="angenommen">Setzt den Status der Reservierung auf Angenommen oder Abgelehnt</param>
        /// <returns>Gibt den Erfolg der Ausführung zurück</returns>
        private bool UpdateStatus(Reservierung reservierung, bool angenommen)
        {
            Utils.Utils.Reservierungen.Remove(reservierung);
            reservierung.Prüfungsstatus = angenommen ? Prüfungsstatus.ANGENOMMEN : Prüfungsstatus.ABGELEHNT;
            reservierung.Prüfungsdatum = DateTime.Today;
            reservierung.Mitarbeiter = new Mitarbeiter(_Mitarbeiter.Vorname, _Mitarbeiter.Nachname, _Mitarbeiter.ID);
            Utils.Utils.Reservierungen.Add(reservierung);
            MessageBox.Show(Resources.MsgBoxResPrüfen, Resources.MsgBoxTitle_ABGESCHLOSSEN, MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            if (Utils.Utils.ReservierungMitStatusX(Prüfungsstatus.IN_BEARBEITUNG).Count == 0)
            {
                MessageBox.Show(Resources.MsgBoxNoRes, Resources.MsgBoxTitle_ACHTUNG, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Dispose();
            }

            return true;
        }
    }
}