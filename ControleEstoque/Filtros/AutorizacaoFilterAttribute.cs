using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControleEstoque.Filtros
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext) // antes
        {
            object usuario = filterContext.HttpContext.Session["usuarioLogado"];
            if(usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Login", action = "Index"}
                    )
                );
            }
        }
    }
}