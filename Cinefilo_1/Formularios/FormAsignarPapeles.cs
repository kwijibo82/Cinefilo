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
    public partial class FormAsignarPapeles : Form
    {
        public FormAsignarPapeles()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Realmente deseas salir?", "Atención", MessageBoxButtons.YesNoCancel);

            if (resul == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBuscarPapeles_Click(object sender, EventArgs e)
        {

            this.Size = new Size(894, 605);
            this.listBoxPapeles.DataSource = BDCinefilo.getPapeles();

            //obtenemos nombre del actor seleccionado
            if (listBoxActores.SelectedItem != null)
            {
                try
                {
                    String nombre = listBoxActores.SelectedItem.ToString();
                    String dni = BDCinefilo.getDniActorPorNombre(nombre);
                    int tipo_papel = BDCinefilo.getIdTipoPapelActorPorDni(dni);
                    String descripcion = BDCinefilo.getDescripcionPapelActorSeleccionado(tipo_papel);

                    //marcamos el papel del actor como elemento seleccinado
                    this.listBoxPapeles.SelectedItem = descripcion;
                }
                catch (System.InvalidOperationException ioex)
                {
                    MessageBox.Show("El actor seleccionado no tiene ningún papel asociado en la base de datos", "Atencion");
                    BDCinefilo.undo();
                }  
            }
        }

        private void buttonCancelarAsignacion_Click(object sender, EventArgs e)
        {
            this.Size = new Size(894, 476);
        }

        private void FormAsignarPapeles_Load(object sender, EventArgs e)
        {
            this.aCTORESBindingSource.DataSource = BDCinefilo.getActoresNombre();
            this.bindingSourcePeliculas.DataSource = BDCinefilo.getPeliculasTitulo();
        }

        private void buttonBuscarActor_Click(object sender, EventArgs e)
        {
            this.aCTORESBindingSource.DataSource = BDCinefilo.getBusquedaActores(this.comboBoxSexo.SelectedItem.ToString(),
                this.textBoxNombreActor.Text);
        }

        private void buttonBuscarPelicula_Click(object sender, EventArgs e)
        {
            this.bindingSourcePeliculas.DataSource =
                BDCinefilo.getPeliculasBusqueda(this.textBoxTitulo.Text, this.textBoxDirector.Text);
        }

        private void buttonAsignarPapeles_Click(object sender, EventArgs e)
        {
            String nombrePapel = this.listBoxPapeles.SelectedItem.ToString();
            String nombrePelicula = this.listBoxPeliculas.SelectedItem.ToString();
            String nombreActor = this.listBoxActores.SelectedItem.ToString();

            //añadimos papel al actor 
            if (BDCinefilo.setPapelToActor(nombrePapel, nombrePelicula, nombreActor))
            {
                MessageBox.Show("Papel asignado correctamente", "Atención!");

                //restauramos formulario a medidas anteriores
                this.Size = new Size(894, 476);
            }
            else
            {
                MessageBox.Show("El papel no ha podido ser asignado", "Atención!");
            }

        }
    }
}
  