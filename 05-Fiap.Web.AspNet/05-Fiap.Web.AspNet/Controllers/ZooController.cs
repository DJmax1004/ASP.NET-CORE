using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class ZooController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        private IActionResult Listar()
        {
            return View(_Lista);
        }

        private static IList<Zoo> _Lista = new List<Zoo>();

        [HttpPost]
        public IActionResult Cadastrar(Zoo zoo)
        {
            TempData["msg"] = "Zoologico cadastrado com sucesso!";
            _Lista.Add(zoo);
            return RedirectToAction("Listar");
        }
    }
}