using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());  // Will catch every unhandled exception of an action and will render that view: Views/shared/error.cshtml
            filters.Add(new AuthorizeAttribute());    // Gives to every action of every controller [Authorize] attribute
            filters.Add(new RequireHttpsAttribute()); // Sequre http
        }
    }
}
