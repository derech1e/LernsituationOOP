﻿using LernsituationOOP.Utils;
using LernsituationOOP.Vermietung;
using System;
using System.Windows.Forms;

namespace LernsituationOOP.Gui
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
            
            if (Utils.Utils.ReservierungMitStatusX(Prüfungsstatus.ABGELEHNT, Prüfungsstatus.ANGENOMMEN).Count == 0)
            {
                MessageBox.Show("Es sind keine geprüften Reservierungen vorhanden!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                return;
            }

            foreach (Reservierung reservierung in Utils.Utils.Reservierungen)
            {
                if (reservierung.Prüfungsstatus == Prüfungsstatus.ANGENOMMEN)
                    listBoxAngenommen.Items.Add(reservierung.Kunde.Nachname + " - " + reservierung.Kunde.KundenNummer);
                else if (reservierung.Prüfungsstatus == Prüfungsstatus.ABGELEHNT)
                    listBoxAbgelehnt.Items.Add(reservierung.Kunde.Nachname + " - " + reservierung.Kunde.KundenNummer);
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
            Reservierung reservierung = Utils.Utils.Reservierungen.Find(item => item.Kunde.KundenNummer == int.Parse(listBoxAngenommen.GetItemText(listBoxAngenommen.SelectedItem).Split('-')[1].ToString()));
            txtBoxInfos.Clear();
            txtBoxInfos.Text = Utils.Utils.GetReservierungsInfos(reservierung);
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
            Reservierung reservierung = Utils.Utils.Reservierungen.Find(item => item.Kunde.KundenNummer == int.Parse(listBoxAbgelehnt.GetItemText(listBoxAbgelehnt.SelectedItem).Split('-')[1].ToString()));
            txtBoxInfos.Clear();
            txtBoxInfos.Text = Utils.Utils.GetReservierungsInfos(reservierung);
            listBoxAngenommen.ClearSelected();
        }
    }
}
