using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.BLL
{
     public class nombre_rutasBLL
    {
        private int id_ruta;
        private string ruta;
        private string Ruta_name;
        private string id_estudiantes_ingles;
        private string id_estudiantes_informatica;


        public nombre_rutasBLL(int id)
        {
            this.Id_ruta = id;
        }

        public nombre_rutasBLL(int id_ruta, string ruta, string ruta_name, string id_estudiantes_ingles, string id_estudiantes_informatica)
        {
            this.Id_ruta = id_ruta;
            this.Ruta = ruta;
            Ruta_name1 = ruta_name;
            this.Id_estudiantes_ingles = id_estudiantes_ingles;
            this.Id_estudiantes_informatica = id_estudiantes_informatica;
        }

        public int Id_ruta { get => id_ruta; set => id_ruta = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public string Ruta_name1 { get => Ruta_name; set => Ruta_name = value; }
        public string Id_estudiantes_ingles { get => id_estudiantes_ingles; set => id_estudiantes_ingles = value; }
        public string Id_estudiantes_informatica { get => id_estudiantes_informatica; set => id_estudiantes_informatica = value; }
    }
}
