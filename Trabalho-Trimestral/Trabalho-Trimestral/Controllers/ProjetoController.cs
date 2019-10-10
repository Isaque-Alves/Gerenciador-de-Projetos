using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabalho_Trimestral.Filtros;

namespace Trabalho_Trimestral.Controllers
{
    [LoginFilter]
    public class ProjetoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}