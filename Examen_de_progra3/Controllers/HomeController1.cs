using Microsoft.AspNetCore.Mvc;

namespace Examen_de_progra3.Controllers
{
    public class HomeController1 : Controller
    {
        private static List<Profesor> profesores = new List<Profesor>
    {
        new Profesor { Cedula = 1, Nombre = "Juan", Apellido = "Perez", AreaConocimiento = "Matemáticas" },
        new Profesor { Cedula = 2, Nombre = "María", Apellido = "González", AreaConocimiento = "Física" }
    };

        private static List<Estudiante> estudiantes = new List<Estudiante>
    {
        new Estudiante { Cedula = 101, Nombre = "Pedro", Edad = 20, Carrera = "Ingeniería", CantidadCursos = 5 },
        new Estudiante { Cedula = 102, Nombre = "Ana", Edad = 22, Carrera = "Medicina", CantidadCursos = 4 }
    };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profesores()
        {
            if (profesores == null)
            {
                profesores = new List<Profesor>();
            }

            return View(profesores);
        }


        public IActionResult Estudiantes()
        {
            return View(estudiantes);
        }

        
        public IActionResult Index1()
        {
            return View();
        }
    }
}
