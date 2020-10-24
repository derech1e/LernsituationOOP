using LernsituationOOP.de.tnuerk.gui;
using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
using System;
using System.Windows.Forms;
using LernsituationOOP.de.tnuerk.utils;

namespace LernsituationOOP
{
    public partial class FrmHaupt : Form
    {
        public FrmHaupt()
        {
            InitializeComponent();
            Autovermieter autovermieter = Utils.GetAutovermieter();
            Text = autovermieter.Name + " in " + autovermieter.Standort + " | Tel.: " + autovermieter.Rufnummer.ToString();
        }

        private void FrmHaupt_Load(object sender, EventArgs e)
        {
            if (!JsonUtils.LoadReservierungen()) Console.Error.WriteLine("Failed to load Reservierungen!");
            if (!JsonUtils.LoadMitarbeiter()) Console.Error.WriteLine("Failed to load Mitarbeiter!");
        }

        private void FrmHaupt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!JsonUtils.SaveReservierungen()) Console.Error.WriteLine("Failed to save Reservierungen!");
            if (!JsonUtils.SaveMitarbeiter()) Console.Error.WriteLine("Failed to save Mitarbeiter!");
        }

        private void btnMieten_Click(object sender, EventArgs e) => new FrmReservieren().ShowDialog();

        private void btnMitarbeiter_Click(object sender, EventArgs e) => new FrmLogin().ShowDialog();

        private void btnGeprüfteRes_Click(object sender, EventArgs e) => new FrmAlleRes().ShowDialog();

        public static void OpenPrüfen(Mitarbeiter mitarbeiter) => new FrmPrüfen(mitarbeiter).ShowDialog();
    }
}
