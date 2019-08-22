using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _04_Fiap.Web.AspNet.Controllers
{
    public class TimeController : Controller
    {
        private static IList<Time> _Lista = new List<Time>();
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_Lista);
        }
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
        [HttpPost]
        public IActionResult Cadastrar(Time time)
        {
            TempData["msg"] = "Time cadastrado com sucesso!!!";
            _Lista.Add(time);
            return RedirectToAction("Listar");
        }

    }
}