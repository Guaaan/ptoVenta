using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ptoVenta
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data source=Server-Vicuna\Vicuna; Initial Catalog=SAES_ADMINISTRATIVOFD; Iser Id=sa; Password=FG12345");
            Conn.Open();

            return Conn;
        }
    }
}
