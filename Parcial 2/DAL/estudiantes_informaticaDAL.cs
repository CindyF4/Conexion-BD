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
    class estudiantes_informaticaDAL
    {

        private Database db;
        public estudiantes_informaticaDAL()
        {
            db = new Database();
        }

        public DataTable getAllEstudiantes_informatica()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estudiantes_informatica";
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

        public bool createestudiantes_informatica(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL estudiantes_Informatica, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL ruta_Nombres)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Estudiantes_informatica (id_estudiantes_informatica, nombre, apellido, ruta, id_especialidades_generales) VALUES (@idei, @nom, @ap, @rut, @ideg);";
                    cmd.Parameters.AddWithValue("@idei", estudiantes_Informatica.Id_estudiantes_informatica);
                    cmd.Parameters.AddWithValue("@nom", estudiantes_Informatica.Nombre);
                    cmd.Parameters.AddWithValue("@ap", estudiantes_Informatica.Apellido);
                    cmd.Parameters.AddWithValue("@rut", estudiantes_Informatica.Ruta);
                    cmd.Parameters.AddWithValue("@ideg", estudiantes_Informatica.Id_especialidades_generales);
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

        public bool updateEstudiantes_informatica(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL estudiantes_Informatica, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL nombre_Rutas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO estudiantes_informatica (id_estudiantes_informatica, nombre, apellido, ruta, id_especialidades_generales) VALUES (@idei, @nom, @ap, @rut, @ideg);";
                    cmd.Parameters.AddWithValue("@idei", estudiantes_Informatica.Id_estudiantes_informatica);
                    cmd.Parameters.AddWithValue("@nom", estudiantes_Informatica.Nombre);
                    cmd.Parameters.AddWithValue("@ap", estudiantes_Informatica.Apellido);
                    cmd.Parameters.AddWithValue("@rut", estudiantes_Informatica.Ruta);
                    cmd.Parameters.AddWithValue("@ideg", estudiantes_Informatica.Id_especialidades_generales);
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

        public bool deleteEstudiantes_informatica(estudiantes_informaticaBLL estudiantes_Informatica)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Estudiantes_informatica WHERE id_estudiantes_informatica = @idei;";
                    cmd.Parameters.AddWithValue("@idei", estudiantes_Informatica.Id_estudiantes_informatica);
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

