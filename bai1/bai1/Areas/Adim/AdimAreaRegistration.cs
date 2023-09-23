using System.Web.Mvc;

namespace bai1.Areas.Adim
{
    public class AdimAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Adim";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Adim_default",
                "Adim/{controller}/{action}/{id}",
                new {Controllers="Dashboard", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}