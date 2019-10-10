using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Trimestral.Filtros
{
    public class LoginFilterAttribute : Attribute, IActionFilter
    {
        public bool SomenteAdmin { get; set; }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            int? idUsuario = context.HttpContext.Session.GetInt32("Id");

            if (idUsuario == null)
            {
                context.Result = new RedirectToRouteResult(new { controller = "conta", action = "login" });
            }
            else if (context.HttpContext.Session.GetInt32("Administrador") != 1 && SomenteAdmin)
            {
                context.Result = new RedirectToRouteResult(new
                {
                    controller = "conta",
                    action = "negado"
                });
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
