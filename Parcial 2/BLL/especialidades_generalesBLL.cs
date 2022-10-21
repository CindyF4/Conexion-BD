using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.BLL
{
    public class especialidades_generalesBLL
    {
        private int id;
        private string nombre;
        private string apellido;
        private string curso;
        private string ruta;
        private string id_datos_estudiantes;

        public especialidades_generalesBLL(int id)
        {
            this.Id = id;
        }

        public especialidades_generalesBLL(int id, string nombre, string apellido, string curso, string ruta, string id_datos_estudiantes)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Curso = curso;
            this.Ruta = ruta;
            this.Id_datos_estudiantes = id_datos_estudiantes;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public string Id_datos_estudiantes { get => id_datos_estudiantes; set => id_datos_estudiantes = value; }
    }
}
