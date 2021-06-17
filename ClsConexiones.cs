using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones necesarias para la conexion
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace ptoVenta
{
    //clase de conexiones para trabjarlo más organizado
    class ClsConexiones
    {
        //ejemplo de conexion con una bd que creé para subir imagenes y probar
        public static MySqlConnection cn = new MySqlConnection("server=root@127.0.0.1:3306; database=db_imagen; Uid=root; pwd=Juan1309");
        public static DataTable EjecutarQuery(string Q, Image img)
        {
            MemoryStream MS = new MemoryStream();
            try
            {
                img.Save(MS, img.RawFormat);
            }
            catch
            {

            }

            byte[] Imagenes = MS.GetBuffer();

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(Q, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@Imagen", Imagenes);

            try
            {
                cn.Open();
                da.Fill(dt);
                cn.Close();
            }
            catch (Exception)
            {
                //no supe cómo manejar bien este error pero mientras investigo esto es lo que se me ocurre
                throw;
            }
            finally
            { 
                cn.Close(); 
            }

            return dt;
        }

    }
}
