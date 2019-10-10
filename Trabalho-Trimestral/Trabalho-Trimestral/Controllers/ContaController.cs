using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trabalho_Trimestral.Models;

namespace Trabalho_Trimestral.Controllers
{
    public class ContaController : Controller
    {
        private AppContext _Ctx;

        public ContaController(AppContext bancoContext)
        {
            _Ctx = bancoContext;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Desenvolvedor desenvolvedor)
        {
            Desenvolvedor desenvolvedorLogado = _Ctx.Desenvolvedores.Where(u => u.Email == desenvolvedor.Email && u.Senha == desenvolvedor.Senha).FirstOrDefault();

            if (desenvolvedorLogado != null)
            {
                HttpContext.Session.SetInt32("Id", desenvolvedorLogado.Id);
                HttpContext.Session.SetString("Nome", desenvolvedorLogado.Nome);
                HttpContext.Session.SetString("Email", desenvolvedorLogado.Email);
                HttpContext.Session.SetInt32("Administrador", desenvolvedorLogado.Admin ? 1 : 0);

                return RedirectToAction("index", "home");
            }
            else
            {
                ViewBag.Mensagem = "Usuário não encontrado";
            }


            return View(desenvolvedor);
        }

        public string Negado()
        {
            return "Acesso negado!";
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("login");
        }
    }
}