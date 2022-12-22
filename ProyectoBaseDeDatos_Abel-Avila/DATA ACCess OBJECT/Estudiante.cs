using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT
{
    public class Estudiante
    {
        public string Matricula { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public int Estatura { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public float Peso { get; set; }

    }
}
