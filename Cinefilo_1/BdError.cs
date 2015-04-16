using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinefilo_1
{
    class BDerror
    {
        public static String controlError(SqlException e)
        {
            String msg;
            switch (e.Number)
            {
                
                case 2601:
                case 2627:
                    msg = "El registro que se intenta introducir ya se encuentra en la base de datos";
                    break;
                case 208:
                    msg = "Nombre de tabla incorrecta";
                    break;
                case 53:
                    msg = "Error de conexión con el servido";
                    break;
                case 547:
                    msg = "El registro que se intenta eliminar hace referencia a otro registro de otra base de datos. Imposible eliminar.";
                    break;
                case 4060:
                    msg = "Error de base de datos";
                    break;
                case 18456:
                    msg = "Entrada de usuario o contraseña incorrectos";
                    break;
                default:
                    msg = e.Number + "   " + e.Message.ToString();
                    break;
            }
            return msg;
        }

    }
}
