using Cinefilo_1.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinefilo_1
{
    public partial class FormInici : Form
    {
        public FormInici()
        {
            InitializeComponent();
        }

        private void tiposDePapelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTiposPapel ftp = new FormTiposPapel();
            ftp.Show();
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemas ft = new FormTemas();
            ft.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPeliculas fp = new FormPeliculas();
            fp.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormActores fa = new FormActores();
            fa.Show();
        }

        private void asignaciónDePapelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignarPapeles fap = new FormAsignarPapeles();
            fap.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Realmente deseas salir?", "Atención", MessageBoxButtons.YesNoCancel);

            if (resul == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
