using LernsituationOOP.de.tnuerk.gui;
using LernsituationOOP.de.tnuerk.klassen;
using LernsituationOOP.de.tnuerk.klassen.utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace LernsituationOOP
{
    public partial class FrmHaupt : Form
    {
        public FrmHaupt()
        {
            InitializeComponent();
        }


        private void btnMieten_Click(object sender, EventArgs e)
        {
            new FrmReservieren().ShowDialog();
        }

        private void FrmHaupt_Load(object sender, EventArgs e)
        {
            JsonUtils.reserveringenLaden();
        }

        private void FrmHaupt_FormClosing(object sender, FormClosingEventArgs e)
        {
            JsonUtils.reservierungenSpeichern();
        }

        private void btnMitarbeiter_Click(object sender, EventArgs e)
        {
            new FrmLogin().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmAlleRes().ShowDialog();
        }
    }
}
