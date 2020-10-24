using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
using LernsituationOOP.de.tnuerk.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LernsituationOOP.de.tnuerk.gui
{
    public partial class FrmAlleRes : Form
    {
        public FrmAlleRes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Es werden die Reservierungen in die entsprechenden Listboxen geladen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAlleRes_Load(object sender, EventArgs e)
        {
            if (Utils.Reservierungen != null)
                foreach (Reservierung reservierung in Utils.Reservierungen)
                {
                    if (reservierung.Prüfungsstatus == Prüfungsstatus.ANGENOMMEN)
                        listBoxAngenommen.Items.Add(reservierung.Kunde.Nachname);
                    else if (reservierung.Prüfungsstatus == Prüfungsstatus.ABGELEHNT)
                        listBoxAbgelehnt.Items.Add(reservierung.Kunde.Nachname);
                }
        }

        /// <summary>
        /// Die Reservierungsinformationen werden dem entsprechendem Index angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAngenommen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAngenommen.SelectedIndex < 0)
                return;
            Reservierung reservierung = Utils.Reservierungen[listBoxAngenommen.SelectedIndex];
            txtBoxInfos.Clear();
            txtBoxInfos.Text = Utils.GetReservierungsInfos(reservierung);
            listBoxAbgelehnt.ClearSelected();
        }

        /// <summary>
        /// Die Reservierungsinformationen werden dem entsprechendem Index angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAbgelehnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAbgelehnt.SelectedIndex < 0)
                return;
            Reservierung reservierung = Utils.Reservierungen[listBoxAbgelehnt.SelectedIndex];
            txtBoxInfos.Clear();
            txtBoxInfos.Text = Utils.GetReservierungsInfos(reservierung);
            listBoxAngenommen.ClearSelected();
        }
    }
}
