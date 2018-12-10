using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinQ_ejemplos.Models;

namespace LinQ_ejemplos.Controllers
{
    public class MateriasController : Controller
    {
            Estudiante c = new Estudiante();
        // GET: Materias
        public ActionResult Index()
        {

            var listado = c.Lista();
            return View(listado.ToList());
        }
        [HttpPost]
        public ActionResult Index(string txtbuscar, string opcion, string btn)
        {
            var listado = c.Lista();
           
            var query1 = (from A in listado  select A);



            switch (opcion)
            {
                case "nombre":
                    var query = (from J in listado where J.Nombre.Contains(txtbuscar) select J);
                    return View(query);
                case "materia":
                    var query4 = (from P in listado where P.Materia.Contains(txtbuscar) select P);
                    return View(query4);
                case "promedio":
                    var query7 = (from P in listado where P.Promedio.ToString().StartsWith(txtbuscar) select P);
                    return View(query1);
            }

            var lista = c.Lista();

            var query2 = (from A in listado select A);



            switch (btn)
            {
                case "nombres":
                    var query = (from J in listado where J.Nombre.Contains(txtbuscar) select J);
                    return View(query);
                case "materias":
                    var query4 = (from P in listado where P.Materia.Contains(txtbuscar) select P);
                    return View(query4);
                case "promedios":
                    var query7 = (from P in listado where P.Promedio.ToString().StartsWith(txtbuscar) select P);
                    return View(query7);
            }

            return View(query1.ToList());

        }
     
    }
}