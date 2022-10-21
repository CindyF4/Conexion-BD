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
    class especialidades_generalesDAL
    {
        private Database db;
        public especialidades_generalesDAL()
        {
            db = new Database();
        }

        public DataTable getAllEspecialidades_generales()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Especialidades_generales";
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

        public bool createEspecialidades_generales(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL estudiantes_Informatica, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL ruta_Nombres)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Especialidades_generales (id, nombre, apellido, curso, ruta, id_datos_estudiantes) VALUES (@id, @nom, @ap, @cur, @rut, @idde);";
                    cmd.Parameters.AddWithValue("@id", especialidades_generales.Id);
                    cmd.Parameters.AddWithValue("@nom", especialidades_generales.Nombre);
                    cmd.Parameters.AddWithValue("@ap", especialidades_generales.Apellido);
                    cmd.Parameters.AddWithValue("@cur", especialidades_generales.Curso);
                    cmd.Parameters.AddWithValue("@rut", especialidades_generales.Ruta);
                    cmd.Parameters.AddWithValue("@idde", especialidades_generales.Id_datos_estudiantes);
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

        public bool updateEspecialidades_generales(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL estudiantes_Informatica, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL nombre_Rutas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Especialidades_generales (id, nombre, apellido, curso, ruta, id_datos_estudiantes) VALUES (@id, @nom, @ap, @cur, @rut, @idde);";
                    cmd.Parameters.AddWithValue("@id", especialidades_generales.Id);
                    cmd.Parameters.AddWithValue("@nom", especialidades_generales.Nombre);
                    cmd.Parameters.AddWithValue("@ap", especialidades_generales.Apellido);
                    cmd.Parameters.AddWithValue("@cur", especialidades_generales.Curso);
                    cmd.Parameters.AddWithValue("@cod", especialidades_generales.Ruta);
                    cmd.Parameters.AddWithValue("@año", especialidades_generales.Id_datos_estudiantes);
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

        public bool deleteEspecialidades_generales(Datos_estudiantesBLL especialidades_generales)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Especialidades_generales WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", especialidades_generales.Id);
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

