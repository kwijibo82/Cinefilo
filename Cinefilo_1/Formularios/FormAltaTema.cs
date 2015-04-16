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
    public partial class FormAltaTema : Form
    {
        public FormAltaTema()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BDCinefilo.altaTema(textBoxAltaTema.Text);
                textBoxAltaTema.Text = "";
                MessageBox.Show("El tema se ha añadido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx) //contrlamos excepciones
            {

                sqlEx = ((SqlException)sqlEx.InnerException.InnerException);
                String msg = BDerror.controlError(sqlEx);
                BDCinefilo.undo();
                MessageBox.Show(msg);

            }  
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAltaTema_Load(object sender, EventArgs e)
        {

        }
    }
}
