using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SebastianRuiz_HenryTorres_EntregaAula2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SebastianRuiz_HenryTorres_EntregaAula2.Controllers
{
    public class PersonaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Persona()
        {
            string nombre, apellidos, eps, regimen, afiliacion, historiaclinica, enfermedadrelevante, cedula, semanascotizadas, costotratamiento, cantidadenfermedades, edad;
            nombre = Request.Form["nombre"].ToString();
            apellidos = Request.Form["apellidos"].ToString();
            cedula = Request.Form["cedula"].ToString();
            eps = Request.Form["eps"].ToString();
            regimen = Request.Form["regimen"].ToString();
            afiliacion = Request.Form["afiliacion"].ToString();
            historiaclinica = Request.Form["historiaclinica"].ToString();
            enfermedadrelevante = Request.Form["enfermedadrelevante"].ToString();
            semanascotizadas = Request.Form["semanascotizadas"].ToString();
            costotratamiento = Request.Form["costotratamiento"].ToString();
            cantidadenfermedades = Request.Form["cantidadenfermedades"].ToString();
            edad = Request.Form["edad"].ToString();

            Persona persona = new Persona(nombre, apellidos, cedula, eps, regimen, afiliacion, historiaclinica, enfermedadrelevante, semanascotizadas, costotratamiento, cantidadenfermedades, edad);
            return View(persona);
        }
    }
}
