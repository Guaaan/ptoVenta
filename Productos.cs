using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptoVenta
{
    public class Productos
    {
        public Int64 IdProducto { get; set; }
        public String Nombre { get; set; }
        public String Precio { get; set; }

        public Productos() { }

        public Productos (Int64 pIdProducto, String pNombre, String pPrecio)
        {
            this.IdProducto = pIdProducto;
            this.Nombre = pNombre;
            this.Precio = pPrecio;
        }
    }
}
