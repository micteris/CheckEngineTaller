using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckEngineTaller.formularios
{
    public partial class principal : Form
    {
        public principal(string nombre)
        {
            InitializeComponent();
            lblidentificador.Text = nombre;
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
