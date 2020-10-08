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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Close();
            this.Hide();
            new FrmPrüfen(int.Parse(txtBoxId.Text)).ShowDialog();
        }
    }
}
