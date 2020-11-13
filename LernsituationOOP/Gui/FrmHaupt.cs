using System;
using System.Windows.Forms;
using LernsituationOOP.Gui.Prüfung;
using LernsituationOOP.Utils;
using LernsituationOOP.Vermietung;

namespace LernsituationOOP.Gui
{
    public partial class FrmHaupt : Form
    {
        public FrmHaupt()
        {
            InitializeComponent();
            Autovermieter autovermieter = Utils.Utils.GetAutovermieter();
            Text = autovermieter.Name + " in " + autovermieter.Standort + " | Tel.: " + autovermieter.Telefonnummer.ToString();
        }

        /// <summary>
        /// Reservierungen und Mitarbeiter, werden beim öffnen der Anwendung geladen
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void FrmHaupt_Load(object sender, EventArgs e)
        {
            if (!JsonUtils.LoadReservierungen()) Console.Error.WriteLine("Reservierungen konnten nicht geladen werden!");
            if (!JsonUtils.LoadMitarbeiter()) Console.Error.WriteLine("Mitarbeiter konnten nicht geladen werden!");
        }

        /// <summary>
        /// Reservierungen und Mitarbeiter, werden beim schließen der Anwendung gespeichert
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void FrmHaupt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!JsonUtils.SaveReservierungen()) Console.Error.WriteLine("Reservierungen konnten nicht gespeichert werden!");
            if (!JsonUtils.SaveMitarbeiter()) Console.Error.WriteLine("Mitarbeiter konnten nicht gespeichert werden!");
        }

        /// <summary>
        /// Öffnet den Reservieren Dialog
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void btnMieten_Click(object sender, EventArgs e) => new FrmReservieren().ShowDialog();

        /// <summary>
        /// Öffnet den Login Dialog
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void btnMitarbeiter_Click(object sender, EventArgs e) => new FrmLogin().ShowDialog();

        /// <summary>
        /// Öffnet den Dialog für Alle Reservierungen
        /// </summary>
        /// <param name="sender">Gibt das Objekt an, von dem das Event getriggert wird</param>
        /// <param name="e">Gibt die Event Argumente an</param>
        private void btnGeprüfteRes_Click(object sender, EventArgs e) => new FrmAlleRes().ShowDialog();
    }
}
