using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT
{
    public class EstudianteDAO
    {
        private string cadenadeconexion = @"Server = ROBERSON1; database=TIC2022; integrated security=true";//Poner el nombre del servidor
        public int guardar(Estudiante estudiante)
        {
            //Creo la conexion con el motor de base de datos
            SqlConnection connection = new SqlConnection(cadenadeconexion);

            //Creo el comando que guarda los registros en la BDD
            string sql = "insert into estudiantes(Matricula, Apellidos, Nombres, Estatura, FechaNacimiento, Peso) " +
                "values(@Matricula, @Apellidos, @Nombres, @Estatura, @FechaNacimiento, @Peso)";
            SqlCommand comando = new SqlCommand(sql, connection);

            //Abro conexion
            connection.Open();
           
            //Agrego los parametros 
            comando.Parameters.Add(new SqlParameter("@Matricula",estudiante.Matricula));
            comando.Parameters.Add(new SqlParameter("@Apellidos", estudiante.Apellidos));
            comando.Parameters.Add(new SqlParameter("@Nombres", estudiante.Nombres));
            comando.Parameters.Add(new SqlParameter("@Estatura", estudiante.Estatura));
            comando.Parameters.Add(new SqlParameter("@FechaNacimiento", estudiante.FechaNacimiento));
            comando.Parameters.Add(new SqlParameter("@Peso", estudiante.Peso));

            //Ejecuto el comando (guardar el registro en la BDD)
            int resultado = comando.ExecuteNonQuery();

            //Cerrar la conexion
            connection.Close();

            return resultado;
        }
        public DataTable getEstudiante(string matricula)
        {
            //Creo la conexion con el motor de base de datos
            SqlConnection connection = new SqlConnection(cadenadeconexion);

            //Creo el comando que busca el registro
            string sql = "select Matricula, Apellidos, Nombres, Estatura, FechaNacimiento, Peso, FechaDeCreacion " 
                + "from estudiantes where Matricula=@Matricula";

            //Declaro un objeto tipo data Table
            DataTable dt = new DataTable();

            //Declaro un adaptador de datos
            SqlDataAdapter ad = new SqlDataAdapter(sql, connection);

            //Agrego el parametro matricula
            ad.SelectCommand.Parameters.Add(new SqlParameter("@Matricula", matricula));

            //Lleno el datatable dt
            ad.Fill(dt);

            //retorno el datatable dt
            return dt;
        }
        public int eliminar(string matricula) 
        {
            //Creo la conexion con el motor de la base de datos
            SqlConnection connection = new SqlConnection(cadenadeconexion);

            //Creo el comando que elimina los registros en la BDD
            string sql = "delete from estudiantes where Matricula=@Matricula";
            SqlCommand comando= new SqlCommand(sql, connection);

            //Abro la conexion
            connection.Open();

            //Agrego los parametros
            comando.Parameters.Add(new SqlParameter("@Matricula",matricula));

            //Ejecuto el comando (elimina el registro en la BDD)
            int resultado=comando.ExecuteNonQuery();

            //Cerrar la conexion
            connection.Close();

            return resultado;
        }
        public int actualizar(Estudiante estudiante)
        {
            SqlConnection connection=new SqlConnection(cadenadeconexion);

            string sql = "update estudiantes set Apellidos=@Apellidos, Nombres=@Nombres, Estatura=@Estatura, " +
                "FechaNacimiento=@FechaNacimiento, Peso=@Peso " +
                "where Matricula=@Matricula";
            SqlCommand comando = new SqlCommand(sql,connection);

            connection.Open();
            
            comando.Parameters.Add(new SqlParameter("@Apellidos", estudiante.Apellidos));
            comando.Parameters.Add(new SqlParameter("@Nombres", estudiante.Nombres));
            comando.Parameters.Add(new SqlParameter("@Estatura", estudiante.Estatura));
            comando.Parameters.Add(new SqlParameter("@FechaNacimiento", estudiante.FechaNacimiento));
            comando.Parameters.Add(new SqlParameter("@Peso", estudiante.Peso));
            comando.Parameters.Add(new SqlParameter("@Matricula", estudiante.Matricula));

            int resultado = comando.ExecuteNonQuery();

            connection.Close();

            return resultado;
        }
    }
}
