using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinefilo_1
{
    public partial class FormPeliculas : Form
    {

        public FormPeliculas()
        {
            InitializeComponent();
        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            this.bindingSourcePeliculas.DataSource = BDCinefilo.getPeliculas();
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            //le pasamos true al constructor (hemos sobrecargado un constructor a tal efecto)
            FormPelicula fp = new FormPelicula(true);
            fp.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //controla que los dos campos esten informados
            if (this.textBoxBusquedaTema.Text != "" || this.textBoxBusquedaTitulo.Text != "")
            {

                try
                {
                    this.bindingSourcePeliculas.DataSource =
                    BDCinefilo.filterPelis(this.textBoxBusquedaTitulo.Text, this.textBoxBusquedaTema.Text);
                }
                catch (SqlException sqlEx) //controlamos excepciones
                {

                    sqlEx = ((SqlException)sqlEx.InnerException.InnerException);
                    String msg = BDerror.controlError(sqlEx);
                    BDCinefilo.undo();
                    MessageBox.Show(msg);

                } 
                
            }
            else 
            {
                MessageBox.Show("Los dos campos deben estar informados", "Atención!");
            }
    
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                BDCinefilo.confirmarCambios();
                MessageBox.Show("Los cambios han sido guardados correctamente", "Información");
            }
            catch (SqlException sqlEx) //controlamos excepciones
            {

                sqlEx = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(sqlEx);
                BDCinefilo.undo();
                MessageBox.Show(msg);

            }  
        }

        /**
         * Borra peliculas, evento UserDeletingRow
         **/
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Obtenemos el valor id_pelicula de la row
            //APUNTE: En la datagrid la columna no aparece, está escondida (Visible = false)
            //pero realmente está ahí
            int id_pelicula = (int) e.Row.Cells[0].Value;

            DialogResult resul =
                MessageBox.Show("¿Realmente deseas borrar ésta película?", 
                "Atención!",
                MessageBoxButtons.YesNo);
            
            if (resul == DialogResult.Yes)
            {
                BDCinefilo.borrarPelicula(id_pelicula, e);
            }
            else
            {
                //cancela el evento UserDeletingRow
                e.Cancel = true;
            }
        }

      
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int id_pelicula = (int) this.dataGridView1.SelectedRows[0].Cells[0].Value;
            String titulo = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            String director = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            //llamamos a la sobrecarga del constructor que recibe la id_pelicula y el booleano conforme
            //el usuario procede desde el evento de la grid
            FormPelicula fp = new FormPelicula(id_pelicula, true, titulo, director);
            FormPelicula.modificar = true;
            fp.Show();

        }

        private void FormPeliculas_Activated(object sender, EventArgs e)
        {
             this.bindingSourcePeliculas.DataSource = BDCinefilo.getPeliculas();
        }


    }
}
