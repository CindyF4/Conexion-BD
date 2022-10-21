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
    class estudiantes_inglesDAL
    {

        private Database db;
        public estudiantes_inglesDAL()
        {
            db = new Database();
        }

        public DataTable getAllEstudiantes_ingles()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estudiantes_ingles";
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

        public bool createestudiantes_ingles(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL estudiantes_Informatica, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL ruta_Nombres)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Estudiantes_ingles (id_estudiantes_ingles, nombre, apellido, ruta, id_especialidades_generales) VALUES (@idei, @nom, @ap, @rut, @ideg);";
                    cmd.Parameters.AddWithValue("@idei", estudiantes_Ingles.Id_estudiantes_ingles);
                    cmd.Parameters.AddWithValue("@nom", estudiantes_Ingles.Nombre);
                    cmd.Parameters.AddWithValue("@ap", estudiantes_Ingles.Apellido);
                    cmd.Parameters.AddWithValue("@rut", estudiantes_Ingles.Ruta);
                    cmd.Parameters.AddWithValue("@ideg", estudiantes_Ingles.Id_especialidades_generales);
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

        public bool updateEstudiantes_ingles(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL estudiantes_Informatica, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL nombre_Rutas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO estudiantes_ingles (id_estudiantes_ingles, nombre, apellido, ruta, id_especialidades_generales) VALUES (@idei, @nom, @ap, @rut, @ideg);";
                    cmd.Parameters.AddWithValue("@idei", estudiantes_Ingles.Id_estudiantes_ingles);
                    cmd.Parameters.AddWithValue("@nom", estudiantes_Ingles.Nombre);
                    cmd.Parameters.AddWithValue("@ap", estudiantes_Ingles.Apellido);
                    cmd.Parameters.AddWithValue("@rut", estudiantes_Ingles.Ruta);
                    cmd.Parameters.AddWithValue("@ideg", estudiantes_Ingles.Id_especialidades_generales);
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

        public bool deleteEstudiantes_ingles(estudiantes_inglesBLL estudiantes_Ingles)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Estudiantes_ingles WHERE id_estudiantes_ingles = @idei;";
                    cmd.Parameters.AddWithValue("@idei", estudiantes_Ingles.Id_estudiantes_ingles);
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
}
