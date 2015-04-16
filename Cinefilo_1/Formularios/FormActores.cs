using Cinefilo_1.Formularios;
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
    public partial class FormActores : Form
    {
        int row = 0, column = 0;
       
        public FormActores()
        {
            InitializeComponent();
        }

        private void FormActores_Load(object sender, EventArgs e)
        {
            this.aCTORESBindingSource.DataSource = BDCinefilo.getActores();
        }

        private void dataGridViewActores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //controla que hacemos click en la columna del sexo 
            if (e.ColumnIndex == 3)
            {
                //guardamos el índice de la fila actual 
                row = this.dataGridViewActores.CurrentRow.Index;
                column = this.dataGridViewActores.CurrentCell.ColumnIndex;

                DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();

                comboBoxCell.Items.Add("Hombre");
                comboBoxCell.Items.Add("Mujer");

                //recuperamos valor y lo "setamos" como valor seleccionado predeterminado
                comboBoxCell.Value = this.dataGridViewActores.CurrentRow.Cells[3].Value;

                //le pasamos a la celda el objeto comboBoxCell
                this.dataGridViewActores.CurrentRow.Cells[3] = comboBoxCell;

            }
            //TODO: Controlar que cambie la combo de la columna 3 (columna sexo) a text si se hace click en 
            //la misma columna

            else if ((e.ColumnIndex == 3 ||
                e.ColumnIndex == 2 ||
                e.ColumnIndex == 1 || 
                e.ColumnIndex == 0 )
                && e.RowIndex != row)
            {
                DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();

                String str = this.dataGridViewActores.Rows[row].Cells[3].Value.ToString();

                textCell.Value = str;

                this.dataGridViewActores.Rows[row].Cells[3] = textCell;
            }
        }

        private void busquedaButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aCTORESBindingSource.DataSource =
                BDCinefilo.filterActores(this.textBoxNombre.Text,
                this.comboBoxSexo.SelectedItem.ToString());
            }
            catch (SqlException sqlEx) //controlamos excepciones
            {

                sqlEx = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(sqlEx);
                BDCinefilo.undo();
                MessageBox.Show(msg);

            }  
            catch (NullReferenceException nrex)
            {
                MessageBox.Show("Los campos deben estar debidamente informados", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
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

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FormActor fa = new FormActor();
            fa.Show();
        }

        private void dataGridViewActores_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Realmente deseas borrar este actor?", "Atención!", MessageBoxButtons.YesNoCancel);

            if (resul == DialogResult.Yes)
            {
                String dni = e.Row.Cells[0].Value.ToString();
                BDCinefilo.borrarActor(dni, e);
            }
            else
            {
                //cancela el evento
                e.Cancel = true;
            }
        }


    }
}
