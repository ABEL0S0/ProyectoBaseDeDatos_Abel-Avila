using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT
{
    public class EstudianteDAO
    {
        private string cadenadeconexion = @"Server=";//Poner el nombre del servidor
        public int guardar(Estudiante estudiante)
        {
            //Creo la conexion con el motor de base de datos
            SqlConnection conexion = new SqlConnection(cadenadeconexion);

            //Creo el comando que guarda los registros en la BDD
            string sql = "insert into estudiantes(Matricula, Apellidos, Nombres, Estatura, FechaNacimiento, Peso)" +
                "values(@Matricula, @Apellidos, @Nombres, @Estatura, @FechaNacimiento, @Peso)";
            SqlCommand comando = new SqlCommand();

            //Abro conexion
            conexion.Open();

            //Agrego los parametros 
            comando.Parameters.Add(new SqlParameter("@Matricula",estudiante.Matricula));
            comando.Parameters.Add(new SqlParameter("@Apellidos", estudiante.Apellidos));
            comando.Parameters.Add(new SqlParameter("@Nombres", estudiante.Nombres));
            comando.Parameters.Add(new SqlParameter("@Estatura", estudiante.Estatura));
            comando.Parameters.Add(new SqlParameter("@FechaNacimiento", estudiante.FechaNacimiento));
            comando.Parameters.Add(new SqlParameter("@Peso", estudiante.Peso));

            //Ejecuto el comando (guardar el registro en la BDD)
            int resultado=comando.ExecuteNonQuery();

            //Cerrar la conexion
            conexion.Close();

            return resultado;
        }
    }
}
