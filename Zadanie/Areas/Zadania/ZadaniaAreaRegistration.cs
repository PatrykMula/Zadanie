using System.Web.Mvc;

namespace Zadanie.Areas.Zadania
{
    public class ZadaniaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Zadania";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Zadania_default",
                "Zadania/{controller}/{action}/{id}",
                new { controler="Zadanie", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Zadanie.Areas.Zadania.Controllers" }
            );
        }
    }
}