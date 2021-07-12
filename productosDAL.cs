using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ptoVenta
{
    public class productosDAL
    {
        public static int Agregar(Productos pProductos)
        {
            int retorno = 0;
            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into producto_testt(IdProducto, Nombre, Precio) values ('{0}', '{1}', '{2}')",
                    pProductos.IdProducto, pProductos.Nombre, pProductos.Precio), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
