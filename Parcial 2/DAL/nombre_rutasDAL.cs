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
    class nombre_rutasDAL
    {

        private Database db;
        public nombre_rutasDAL()
        {
            db = new Database();
        }

        public DataTable getAllNombre_rutas()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Nombre_rutas";
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

        public bool createNombre_rutas(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL nombre_rutas, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL ruta_Nombres)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Nombre_rutas (id_ruta, ruta, ruta_name, id_estudiantes_informatica, id_estudiantes_ingles) VALUES (@idru, @rut,@nrut, @idei, @idein);";
                    cmd.Parameters.AddWithValue("@idru", nombre_rutas.Id_ruta);
                    cmd.Parameters.AddWithValue("@rut", nombre_rutas.Ruta);
                    cmd.Parameters.AddWithValue("@nrut", nombre_rutas.Ruta_name);
                    cmd.Parameters.AddWithValue("@idei", nombre_rutas.Id_estudiantes_informatica);
                    cmd.Parameters.AddWithValue("@idein", nombre_rutas.Id_estudiantes_ingles);
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

        public bool updateRuta_nombres(Datos_estudiantesBLL datos_Estudiantes, especialidades_generalesBLL especialidades_generales, estudiantes_informaticaBLL estudiantes_Informatica, estudiantes_inglesBLL estudiantes_Ingles, nombre_rutasBLL nombre_Rutas)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Ruta_nombres(id_estudiantes_informatica, nombre, apellido, ruta, id_especialidades_generales) VALUES (@idei, @nom, @ap, @rut, @ideg);";
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
                    cmd.CommandText = "DELETE FROM Estudiantes_informatica WHERE Nombre_rutas = @idei;";
                    cmd.Parameters.AddWithValue("@idei", nombre_rutas.Nombre_rutas);
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
