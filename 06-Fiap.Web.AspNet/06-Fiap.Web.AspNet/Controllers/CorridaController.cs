using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Contexts;
using _06_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class CorridaController : Controller
    {
        private CorridaContext _context;
        public CorridaController(CorridaContext context)
        {
            _context = context;
        }
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
        public IActionResult Cadastrar(Corrida corrida)
        {
            _context.Add(corrida);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Corridas.ToList());
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            var corrida = _context.Corridas.Find(id);
            return View(corrida);
        }
        [HttpPost]
        public IActionResult Atualizar(Corrida corrida)
        {
            _context.Attach(corrida).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado com sucesso!";
            return RedirectToAction("Listar");
        }
    }
}