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
    public partial class FrmPrüfen : Form
    {
        public FrmPrüfen()
        {
            InitializeComponent();
        }

        private void FrmPrüfen_Load(object sender, EventArgs e)
        {
            foreach(Reservierung reservierung in JsonUtils.getReservierungen())
            {
                listBoxEinträge.Items.Add(reservierung.Kunde.Name);
            }
        }
    }
}
