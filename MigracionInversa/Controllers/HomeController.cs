using DAL.Modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MigracionInversa.Models;

using System.Diagnostics;

namespace MigracionInversa.Controllers
{
    public class HomeController : Controller
    {
        private readonly entityBasicoContext context;

        public HomeController(entityBasicoContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            //var empleados = this.context.Empleados.Include(m => m.NombreEmpleado).Select(m => new EmpleadoViewModel
            //{
            //    id = m.Id,
            //    name = m.NombreEmpleado,
            //    accessLevel = (int) m.NivelAccId,
            //    surnames = m.Apellidos
            //});
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}