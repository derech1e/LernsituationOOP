using LernsituationOOP.de.tnuerk.klassen;
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

namespace LernsituationOOP
{
    public partial class FrmHaupt : Form
    {
        public List<Reservierung> reservierungen = new List<Reservierung>();

        public FrmHaupt()
        {
            InitializeComponent();
        }

        private void btnMieten_Click(object sender, EventArgs e)
        {
            new FrmReservieren().ShowDialog();
        }
    }
}
