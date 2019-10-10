using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trabalho_Trimestral.Filtros;
using Trabalho_Trimestral.Models;

namespace Trabalho_Trimestral.Controllers
{

    [LoginFilter]
    public class BugController : Controller
    {
        private AppContext Banco;

        public BugController(AppContext appContext)
        {
            Banco = appContext;
        }

        public IActionResult Index()
        {
            ViewBag.Bugs = Banco.Bugs.Include(p => p.Desenvolvedor).Include(p => p.Requisito).OrderBy(c => c.DataCadastro);
            return View();
        }

        public IActionResult Novo()
        {

            return View("Form");
        }

        [HttpPost]
        public IActionResult Novo(Bug bug)
        {
            if (ModelState.IsValid)
            {
                bug.DesenvolvedorId = bug.Id;
                Banco.Bugs.Add(bug);
                Banco.SaveChanges();
            }
            else
            {
                return View("Form", bug);
            }


            return RedirectToAction("index");
        }

        public IActionResult Editar(int id)
        {

            Bug bug = Banco.Bugs.Find(id);



            if (bug == null)
            {
                return RedirectToAction("index");
            }

            return View("FormEdit", bug);
        }

        [HttpPost]
        public IActionResult Editar(Bug bug)
        {
            if (ModelState.IsValid)
            {
                Banco.Bugs.Update(bug);
                Banco.SaveChanges();
            }
            else
            {


                return View("FormEdit", bug);
            }




            return RedirectToAction("index");
        }

        public IActionResult Excluir(int id)
        {
            Bug bug = Banco.Bugs.Find(id);

            if (bug != null)
            {
                Banco.Bugs.Remove(bug);
                Banco.SaveChanges();
            }

            return RedirectToAction("index");
        }

        public IActionResult Resolver(int id)
        {
            Bug bug = Banco.Bugs.Find(id);
            bug.Resolucao = true;
            Banco.Bugs.Update(bug);
            Banco.SaveChanges();

            return RedirectToAction("index");

        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ViewBag.Requisitos = Banco.Requisitos.Select(c => new SelectListItem
            {
                Text = c.Descricao,
                Value = c.Id.ToString()
            });

            ViewBag.Desenvolvedores = Banco.Desenvolvedores.Select(c => new SelectListItem
            {
                Text = c.Nome,
                Value = c.Id.ToString()
            });
        }
    }
}