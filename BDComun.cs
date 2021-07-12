using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptoVenta
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data source=; Initial Catalog=; User Id=sa; Password=FG12345");
            Conn.Open();

            return Conn;
        }
    }
}
