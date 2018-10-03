using SIGI.DAO.Usuarios;
using SIGI.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SIGI.Filtros
{
    public class FiltroAdmAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var usuario = filterContext.HttpContext.Session["usuarioLogado"];

            if (usuario != null)
            {
                var usuarioBanco = new UsuarioDAO().Buscar((Usuario)usuario);
                if (usuarioBanco == null)
                {
                   
                        filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new { controller = "Usuario", action = "NaoAdm" }
                            )
                        );
                    
                }
                else if (usuarioBanco.Status != EStatus.Administrador)
                {
                    filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Usuario", action = "NaoAdm" }
                        )
                    );
                }
            }

        }
    }
}