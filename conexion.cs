using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;

namespace ptoVenta
{
    class Conexion
    {

        public static SqlConnection conexion() 
        {
            string[] lines = System.IO.File.ReadAllLines(@"configsql.ini");
            foreach (string line in lines)
            {
                Form1.eservidor = Form1.eservidor + line;
            }
            Form1.cn = new SqlConnection(Form1.eservidor);
            return Form1.cn;
        }
    }
}
