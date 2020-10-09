using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
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

        private void FrmAlleRes_Load(object sender, EventArgs e)
        {
            foreach (Reservierung reservierung in JsonUtils.getReservierungen())
            {
                if(reservierung.Prüfungsstatus == Prüfungsstatus.ANGENOMMEN)
                {
                    listBoxAngenommen.Items.Add(reservierung.Kunde.Nachname);
                } else if(reservierung.Prüfungsstatus == Prüfungsstatus.ABGELEHNT)
                {
                    listBoxAbgelehnt.Items.Add(reservierung.Kunde.Nachname);
                }
            }
        }

        private void listBoxAngenommen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservierung reservierung = JsonUtils.getReservierungen()[listBoxAngenommen.SelectedIndex];
            txtBoxInfos.Clear();
            txtBoxInfos.Text += "Vorname: " + reservierung.Kunde.Vorname + "\n"
                + "Nachname: " + reservierung.Kunde.Nachname + "\n"
                + "Adresse: " + reservierung.Kunde.Adresse + "\n"
                + "Geburtstag: " + reservierung.Kunde.Geburtsdatum.ToString("dd. MMMM yyyy") + "\n\n"
                + "E-Mail: " + reservierung.Kunde.Email + "\n"
                + "Telefonnummer: " + reservierung.Kunde.Telefonnummer + "\n"
                + "Führerschein: " + (reservierung.Kunde.Führerschein ? "Ja" : "Nein") + "\n\n"
                + "Fahrzeug: " + reservierung.Fahrzeug.Modell + "\n"
                + "Zustand des Fahzeugs: " + reservierung.Fahrzeug.Zustand + "\n\n"
                + "Reservierung: " + reservierung.Reservierung_Start.Date.ToString("dd. MMMM yyyy") + " bis " + reservierung.Reservierung_Ende.Date.ToString("dd. MMMM yyyy") + "\n\n"
                + "Prüfungsstatus: " + reservierung.Prüfungsstatus + "\n"
                +"Geprüft am: " + reservierung.Prüfungsdatum.Value.Date.ToString("dd. MMMM yyyy") + "\n"
                + "Geprüft von Mitarbeiter: " + reservierung.Mitarbeiter.Nummer;
        }

        private void listBoxAbgelehnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservierung reservierung = JsonUtils.getReservierungen()[listBoxAbgelehnt.SelectedIndex];
            txtBoxInfos.Clear();
            txtBoxInfos.Text += "Vorname: " + reservierung.Kunde.Vorname + "\n"
                + "Nachname: " + reservierung.Kunde.Nachname + "\n"
                + "Adresse: " + reservierung.Kunde.Adresse + "\n"
                + "Geburtstag: " + reservierung.Kunde.Geburtsdatum.ToString("dd. MMMM yyyy") + "\n\n"
                + "E-Mail: " + reservierung.Kunde.Email + "\n"
                + "Telefonnummer: " + reservierung.Kunde.Telefonnummer + "\n"
                + "Führerschein: " + (reservierung.Kunde.Führerschein ? "Ja" : "Nein") + "\n\n"
                + "Fahrzeug: " + reservierung.Fahrzeug.Modell + "\n"
                + "Zustand des Fahzeugs: " + reservierung.Fahrzeug.Zustand + "\n\n"
                + "Reservierung: " + reservierung.Reservierung_Start.Date.ToString("dd. MMMM yyyy") + " bis " + reservierung.Reservierung_Ende.Date.ToString("dd. MMMM yyyy") + "\n\n"
                + "Prüfungsstatus: " + reservierung.Prüfungsstatus + "\n"
                + "Geprüft am: " + reservierung.Prüfungsdatum.Value.Date.ToString("dd. MMMM yyyy") + "\n"
                + "Geprüft von Mitarbeiter: " + reservierung.Mitarbeiter.Nummer;
        }
    }
}
