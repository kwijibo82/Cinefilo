using Cinefilo_1.BD;
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
    public partial class FormPelicula : Form
    {
        private int id_pelicula;
        private bool vengoDeLaGrid = false;
        public static bool modificar = false;
        private bool nuevaAlta = false;
        private String titulo;
        private String director;

        public FormPelicula()
        {
            InitializeComponent();
        }

        //Constructor para pasar los valores de la id_pelicula
        public FormPelicula(int id_pelicula, bool vengoDeLaGrid, String titulo, String director)
        {
            InitializeComponent();
            this.id_pelicula = id_pelicula;
            this.vengoDeLaGrid = vengoDeLaGrid;
            this.titulo = titulo;
            this.director = director;
            
        }

        //Constructor para dar de alta una nueva película
        public FormPelicula(bool nuevaAlta)
        {
            InitializeComponent();
            this.nuevaAlta = nuevaAlta;
        }


        private void listBoxTemas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormPelicula_Load(object sender, EventArgs e)
        {
            this.tEMASBindingSource1.DataSource = BDCinefilo.getTema();

            //controla que venimos del evento doubleClick de la grid
            if (vengoDeLaGrid)
            {
                PELICULAS peli = new PELICULAS();
                peli = BDCinefilo.getPeliculasById(this.id_pelicula);

                this.textBoxTitulo.Text = peli.titulo.ToString();
                this.textBoxDirector.Text = peli.director.ToString();
            }
      
        }

        private void buttonAcceptar_Click(object sender, EventArgs e)
        {
            //controla que venimos para crear un alta nueva o a modificar ya una existente
            if (!modificar)
            {
                List<TEMAS> listTemas = new List<TEMAS>();

                foreach (TEMAS item in this.listBoxTemas.SelectedItems)
	            {
                    listTemas.Add(item);
	            }

                bool resulDuplicidades = BDCinefilo.comprobarDuplicidadesPeliculas(
                    this.textBoxTitulo.Text,
                    this.textBoxDirector.Text, 
                    listTemas);

                //controlamos si hay duplicidades
                if (!resulDuplicidades)
                {
                    bool resul = BDCinefilo.altaNuevaPelicula(
                            this.textBoxTitulo.Text,
                            this.textBoxDirector.Text,
                            listTemas);

                    //controla que mensaje se debe mostrar al usuario
                    if (resul)
                    {
                        MessageBox.Show("Pelicula añadida correctamente", "Información");
                    }
                    else
                    {
                        MessageBox.Show("La película no se ha añadido", "Atención!");
                    }
                }
                else
                {
                    MessageBox.Show("El registro no se ha podido añadir, se encontraron duplicidades", "Atención!");
                }  
              
            }
            else
            {
                //creamos un objeto PELICULAS para modificar
                PELICULAS p = BDCinefilo.getPeliculaPorCriterios(this.titulo, this.director);
                List<TEMAS> listTemas = new List<TEMAS>();

                p.director = this.textBoxDirector.Text;
                p.titulo = this.textBoxTitulo.Text;

                foreach (TEMAS item in listTemas)
                {
                    p.TEMAS.Add(item);
                }

                BDCinefilo.confirmarCambios();

                MessageBox.Show("Pelicula modificada correctamente", "Información");
     
            }

        }

        private void tEMASBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
