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
    public partial class FormTiposPapel : Form
    {
        private Boolean recargar = false;

        public FormTiposPapel()
        {
            InitializeComponent();
        }

        private void FormTiposPapel_Load(object sender, EventArgs e)
        {
            this.bindingSourceTiposPapel.DataSource = BDCinefilo.getTipoDePapel();
        }

        //añade nuevo registro
        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FormAltaTipoPapel fatp = new FormAltaTipoPapel();
            recargar = true;
            fatp.Show();
        }

        //salit
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

        //busca registros (filtra)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.bindingSourceTiposPapel.DataSource = BDCinefilo.filterTipoPapel(this.textBoxBusquedaTipo.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            this.Close();
    
        }

        private void FormTiposPapel_Activated(object sender, EventArgs e)
        {
            //controla si venimos del FormAltaPapel
            if (recargar)
            {
                this.bindingSourceTiposPapel.DataSource = BDCinefilo.getTipoDePapel();
                recargar = false;
            }
            
        }


    }
}
