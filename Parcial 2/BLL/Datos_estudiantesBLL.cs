using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.BLL
{
    public class Datos_estudiantesBLL
    {
        private int id_datos;
        private string nombre;
        private string apellido;
        private string curso;
        private string codigo;
        private string año;
        private string correo;


        public Datos_estudiantesBLL(int id)
        {
            this.Id_datos = id;
        }

        public Datos_estudiantesBLL(int id_datos, string nombre, string apellido, string curso, string codigo, string año, string correo)
        {
            this.Id_datos = id_datos;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Curso = curso;
            this.Codigo = codigo;
            this.Año = año;
            this.Correo = correo;
        }

        public int Id_datos { get => id_datos; set => id_datos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Año { get => año; set => año = value; }
        public string Correo { get => correo; set => correo = value; }
    }



    }



