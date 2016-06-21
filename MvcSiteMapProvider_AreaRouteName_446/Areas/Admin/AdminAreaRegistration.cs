using System.Web.Mvc;

namespace MvcSiteMapProvider_AreaRouteName_446.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            // NOTE: This route cannot be accessed through a URL, but using route attribute
            // the URL can be generated, exactly the same way that RouteLink works.
            context.MapRoute(
                "Admin_test",
                "Admin/Boo/{action}/{id}",
                new { controller = "Settings", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}