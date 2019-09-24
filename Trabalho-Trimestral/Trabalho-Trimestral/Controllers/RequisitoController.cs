using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabalho_Trimestral.Models;

namespace Trabalho_Trimestral.Controllers
{
    public class RequisitoController : Controller
    {
        private AppContext Banco;

        public RequisitoController(AppContext appContext)
        {
            Banco = appContext;
        }

        public IActionResult Index()
        {
            ViewBag.Requisitos = Banco.Requisitos.OrderBy(c => c.DataCadastro);
            return View();
        }

        public IActionResult Novo()
        {
            return View("Form");
        }

        [HttpPost]
        public IActionResult Novo(Requisito requisito)
        {
            if (ModelState.IsValid)
            {
                Banco.Requisitos.Add(requisito);
                Banco.SaveChanges();
            }
            else
            {
                return View("Form", requisito);
            }


            return RedirectToAction("index");
        }

        public IActionResult Editar(int id)
        {
            Requisito requisito = Banco.Requisitos.Find(id);

            if (requisito == null)
            {
                return RedirectToAction("index");
            }

            return View("Form", requisito);
        }

        [HttpPost]
        public IActionResult Editar(Requisito requisito)
        {
            if (ModelState.IsValid)
            {
                Banco.Requisitos.Update(requisito);
                Banco.SaveChanges();
            }
            else
            {
                return View("Form", requisito);
            }


            return RedirectToAction("index");
        }

        public IActionResult Excluir(int id)
        {
            Requisito requisito = Banco.Requisitos.Find(id);

            if (requisito != null)
            {
                Banco.Requisitos.Remove(requisito);
                Banco.SaveChanges();
            }

            return RedirectToAction("index");
        }
    }
}