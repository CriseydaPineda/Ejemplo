using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinQ_ejemplos.Models
{
    public class Estudiante
    {
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public decimal Promedio { get; set; }
        public DateTime Fecha { get; set; }

        public List<Estudiante> Lista()
        {
            var estudiante1 = new Estudiante()
            {
                Carnet = 001,
                Nombre = "Juan",
                Materia = "Informatica",
                Promedio = 8,
                Fecha = DateTime.Now

            };
            var estudiante2 = new Estudiante()
            {
                Carnet = 002,
                Nombre = "J. Daniel",
                Materia = "Matematica",
                Promedio = 7,
                Fecha = DateTime.Now

            };
            var estudiante3 = new Estudiante()
            {
                Carnet = 003,
                Nombre = "Sandra Juarez",
                Materia = "Psicologia",
                Promedio = 7,
                Fecha = DateTime.Now

            };
            var estudiante4 = new Estudiante()
            {
                Carnet = 004,
                Nombre = "Alexis",
                Materia = "Psicologia",
                Promedio = 8,
                Fecha = DateTime.Now

            };
            return new List<Estudiante>() {estudiante1, estudiante2, estudiante3, estudiante4 };
    }
    }
     
}