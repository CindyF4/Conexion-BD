using Parcial_2.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.DAL
{
    public class datos_estudiantesDAL
    {
        private Database db;
        public datos_estudiantesDAL()
        {
            db = new Database();
        }

        public DataTable getAllDatos_estudiantes()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Datos_estudiantes";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch
            {
                return dt;
            }
        }

        public bool createDatos_estudiantes(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL estudiantes_Informatica, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL ruta_Nombres)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Datos_estudiantes (id_datos, nombre, apellido, curso, codigo, año, correo) VALUES (@id, @nom, @ap, @cur, @cod, @año, @corr);";
                    cmd.Parameters.AddWithValue("@id", datos_Estudiantes.Id_datos);
                    cmd.Parameters.AddWithValue("@nom", datos_Estudiantes.Nombre);
                    cmd.Parameters.AddWithValue("@ap", datos_Estudiantes.Apellido);
                    cmd.Parameters.AddWithValue("@cur", datos_Estudiantes.Curso);
                    cmd.Parameters.AddWithValue("@cod", datos_Estudiantes.Codigo);
                    cmd.Parameters.AddWithValue("@año", datos_Estudiantes.Año);
                    cmd.Parameters.AddWithValue("@corr", datos_Estudiantes.Correo);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
            }
        }

        public bool updateDatos_estudiantes(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL estudiantes_Informatica, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL nombre_Rutas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Datos_estudiantes (id_datos, nombre, apellido, curso, codigo, año, correo) VALUES (@id, @nom, @ap, @cur, @cod, @año, @corr);";
                    cmd.Parameters.AddWithValue("@id", datos_Estudiantes.Id_datos);
                    cmd.Parameters.AddWithValue("@nom", datos_Estudiantes.Nombre);
                    cmd.Parameters.AddWithValue("@ap", datos_Estudiantes.Apellido);
                    cmd.Parameters.AddWithValue("@cur", datos_Estudiantes.Curso);
                    cmd.Parameters.AddWithValue("@cod", datos_Estudiantes.Codigo);
                    cmd.Parameters.AddWithValue("@año", datos_Estudiantes.Año);
                    cmd.Parameters.AddWithValue("@corr", datos_Estudiantes.Correo);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool deleteDatos_estudiantes(Datos_estudiantesBLL datos_Estudiantes)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Datos_estudiantes WHERE id_datos = @id;";
                    cmd.Parameters.AddWithValue("@id", datos_Estudiantes.Id_datos);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
