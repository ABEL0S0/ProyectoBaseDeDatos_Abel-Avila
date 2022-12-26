using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT
{
    public class Libro
    {
        public string CodigoLibro { get; set; }
        public string NombreLibro { get; set; }
        public string Autor { get; set; }
        public float PrecioCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public int Unidades { get; set; }
    }
}
