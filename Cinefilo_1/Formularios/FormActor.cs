using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinefilo_1.Formularios
{
    public partial class FormActor : Form
    {

        public FormActor()
        {
            InitializeComponent();
        }

        private void buttonAcceptar_Click(object sender, EventArgs e)
        {       

            //controla si se muestea el mensaje conforme se ha añadido o no
            if (BDCinefilo.altaNuevoActor(this.textBoxDNI.Text,
                this.textBoxNombre.Text,
                this.comboBoxSexo.SelectedItem.ToString(),
                Int32.Parse(this.textBoxEdad.Text)))
            {
                MessageBox.Show("Registro añadido correctamente");
            }
        }
    }
}
