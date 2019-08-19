using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _03_FiapWebAspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_FiapWebAspNet.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }
        private static IList<Usuario> _lista = new List<Usuario>();
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
        public IActionResult Cadastrar(Usuario usuario)
        {
            ViewBag.usuario = usuario;
            ViewData["nome"] = usuario.nome;
            TempData["msg"] = "Usuário cadastrado com sucesso!";
            //Cadastrar no "banco" de dados
            _lista.Add(usuario);
            //Envia o objeto usuário para a tela
            return View(usuario);
        }
    }
}