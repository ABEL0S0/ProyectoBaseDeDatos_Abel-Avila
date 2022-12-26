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
    public class LibrosDAO
    {
        private string cadenadeconexion = @"Server = ROBERSON1; database=TIC2022; integrated security=true";//Poner el nombre del servidor
        public int guardar(Libro libro)
        {
            //Creo la conexion con el motor de base de datos
            SqlConnection connection = new SqlConnection(cadenadeconexion);

            //Creo el comando que guarda los registros en la BDD
            string sql = "insert into Libros(CodigoLibro, NombreLibro, Autor, PrecioCompra, FechaCompra, Unidades) " +
                "values(@CodigoLibro, @NombreLibro, @Autor, @PrecioCompra, @FechaCompra, @Unidades)";
            SqlCommand comando = new SqlCommand(sql, connection);

            //Abro conexion
            connection.Open();

            //Agrego los parametros 
            comando.Parameters.Add(new SqlParameter("@CodigoLibro", libro.CodigoLibro));
            comando.Parameters.Add(new SqlParameter("@NombreLibro", libro.NombreLibro));
            comando.Parameters.Add(new SqlParameter("@Autor", libro.Autor));
            comando.Parameters.Add(new SqlParameter("@PrecioCompra", libro.PrecioCompra));
            comando.Parameters.Add(new SqlParameter("@FechaCompra", libro.FechaCompra));
            comando.Parameters.Add(new SqlParameter("@Unidades", libro.Unidades));

            //Ejecuto el comando (guardar el registro en la BDD)
            int resultado = comando.ExecuteNonQuery();

            //Cerrar la conexion
            connection.Close();

            return resultado;
        }
        public DataTable getLibro(string libro)
        {
            //Creo la conexion con el motor de base de datos
            SqlConnection connection = new SqlConnection(cadenadeconexion);

            //Creo el comando que busca el registro
            string sql = "select CodigoLibro, NombreLibro, Autor, PrecioCompra, FechaCompra, Unidades, FechaCreacion "
                + "from Libros where CodigoLibro=@CodigoLibro";

            //Declaro un objeto tipo data Table
            DataTable dt = new DataTable();

            //Declaro un adaptador de datos
            SqlDataAdapter ad = new SqlDataAdapter(sql, connection);

            //Agrego el parametro matricula
            ad.SelectCommand.Parameters.Add(new SqlParameter("@CodigoLibro", libro));

            //Lleno el datatable dt
            ad.Fill(dt);

            //retorno el datatable dt
            return dt;
        }
        public int eliminar(string libro)
        {
            //Creo la conexion con el motor de la base de datos
            SqlConnection connection = new SqlConnection(cadenadeconexion);

            //Creo el comando que elimina los registros en la BDD
            string sql = "delete from Libros where CodigoLibro=@CodigoLibro";
            SqlCommand comando = new SqlCommand(sql, connection);

            //Abro la conexion
            connection.Open();

            //Agrego los parametros
            comando.Parameters.Add(new SqlParameter("@CodigoLibro", libro));

            //Ejecuto el comando (elimina el registro en la BDD)
            int resultado = comando.ExecuteNonQuery();

            //Cerrar la conexion
            connection.Close();

            return resultado;
        }
        public int actualizar(Libro libro)
        {
            SqlConnection connection = new SqlConnection(cadenadeconexion);

            string sql = "update Libros set NombreLibro=@NombreLibro, Autor=@Autor, PrecioCompra=@PrecioCompra, " +
                "FechaCompra=@FechaCompra, Unidades=@Unidades " +
                "where CodigoLibro=@CodigoLibro";
            SqlCommand comando = new SqlCommand(sql, connection);

            connection.Open();

            comando.Parameters.Add(new SqlParameter("@NombreLibro", libro.NombreLibro));
            comando.Parameters.Add(new SqlParameter("@Autor", libro.Autor));
            comando.Parameters.Add(new SqlParameter("@PrecioCompra", libro.PrecioCompra));
            comando.Parameters.Add(new SqlParameter("@FechaCompra", libro.FechaCompra));
            comando.Parameters.Add(new SqlParameter("@Unidades", libro.Unidades));
            comando.Parameters.Add(new SqlParameter("@CodigoLibro", libro.CodigoLibro));

            int resultado = comando.ExecuteNonQuery();

            connection.Close();

            return resultado;
        }
    }
}