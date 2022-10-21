using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.BLL
{
    public class estudiantes_inglesBLL
    {
        private int id_estudiantes_ingles;
        private string nombre;
        private string apellido;
        private string ruta;
        private string id_especialidades_generales;


        public estudiantes_inglesBLL(int id)
        {
            this.Id_estudiantes_ingles = id;
        }

        public estudiantes_inglesBLL(int id_estudiantes_ingles, string nombre, string apellido, string ruta, string id_especialidades_generales)
        {
            this.Id_estudiantes_ingles = id_estudiantes_ingles;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Ruta = ruta;
            this.Id_especialidades_generales = id_especialidades_generales;
        }

        public int Id_estudiantes_ingles { get => id_estudiantes_ingles; set => id_estudiantes_ingles = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public string Id_especialidades_generales { get => id_especialidades_generales; set => id_especialidades_generales = value; }
    }
}
