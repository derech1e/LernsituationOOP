using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
using System;
using System.Windows.Forms;

namespace LernsituationOOP.de.tnuerk.gui
{
    public partial class FrmPrüfen : Form
    {
        private int ID = 0;
        public FrmPrüfen(int mitarbetierID)
        {
            ID = mitarbetierID;
            InitializeComponent();
        }

        private void FrmPrüfen_Load(object sender, EventArgs e)
        {
            foreach(Reservierung reservierung in JsonUtils.getReservierungen())
            {
                listBoxEinträge.Items.Add(reservierung.Kunde.Nachname);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Reservierung reservierung = JsonUtils.getReservierungen()[listBoxEinträge.SelectedIndex];
            if (JsonUtils.reservierungLöschen(reservierung))
            {
                reservierung.Prüfungsstatus = Prüfungsstatus.ANGENOMMEN;
                reservierung.Mitarbeiter = new Mitarbeiter(ID);
                reservierung.Prüfungsdatum = DateTime.Today;
                if(JsonUtils.reservierungHinzufügen(reservierung))
                {
                    MessageBox.Show("Reservierung bestätigt!");
                } else
                {
                    MessageBox.Show("Reservierungs bestätigung Fehlgeschlagen (Hinzufügen)!");
                }
            } else
            {
                MessageBox.Show("Reservierungs bestätigung Fehlgeschlagen (Löschen)!");
            }
        }

        private void listBoxEinträge_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservierung reservierung = JsonUtils.getReservierungen()[listBoxEinträge.SelectedIndex];
            txtBoxResInfos.Clear();
            txtBoxResInfos.Text += "Vorname: " + reservierung.Kunde.Vorname + "\n"
                + "Nachname: " + reservierung.Kunde.Nachname + "\n"
                + "Adresse: " + reservierung.Kunde.Adresse + "\n"
                + "Geburtstag: " + reservierung.Kunde.Geburtsdatum.ToString("dd. MMMM yyyy") + "\n\n"
                + "E-Mail: " + reservierung.Kunde.Email + "\n"
                + "Telefonnummer: " + reservierung.Kunde.Telefonnummer + "\n"
                + "Führerschein: " + (reservierung.Kunde.Führerschein ? "Ja" : "Nein") + "\n\n"
                + "Fahrzeug: " + reservierung.Fahrzeug.Modell + "\n"
                + "Zustand des Fahzeugs: " + reservierung.Fahrzeug.Zustand + "\n\n"
                + "Reservierung: " + reservierung.Reservierung_Start.Date.ToString("dd. MMMM yyyy") + " bis " + reservierung.Reservierung_Ende.Date.ToString("dd. MMMM yyyy") + "\n";
        }

        private void btnUnCheck_Click(object sender, EventArgs e)
        {
            Reservierung reservierung = JsonUtils.getReservierungen()[listBoxEinträge.SelectedIndex];
            reservierung.Prüfungsstatus = Prüfungsstatus.ABGELEHNT;
        }
    }
}
