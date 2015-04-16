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
    public partial class FormTemas : Form
    {
        public FormTemas()
        {
            InitializeComponent();
        }

        private void FormTemas_Load(object sender, EventArgs e)
        {
            this.temasBindingSource.DataSource = BDCinefilo.getTema();
        }

        //añade nuevo tema
        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
 
             FormAltaTema fatp = new FormAltaTema();
             fatp.Show();
        }

        //busca temas (filtra)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.temasBindingSource.DataSource = BDCinefilo.filterTema(this.textBoxBusquedaFormTemas.Text);
        }

        //salir
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
      
            this.Close();
    
        }

        //guarda registros
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                BDCinefilo.confirmarCambios();
            }
            catch (SqlException sqlEx) //contrlamos excepciones
            {

                sqlEx = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(sqlEx);
                BDCinefilo.undo();
                MessageBox.Show(msg);

            }  
        }


    }
}
