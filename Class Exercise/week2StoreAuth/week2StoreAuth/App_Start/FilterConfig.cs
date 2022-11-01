using System.Web;
using System.Web.Mvc;

namespace week2StoreAuth
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new System.Web.Mvc.AuthorizeAttribute()); // new global auth filter
            filters.Add(new HandleErrorAttribute());
        }
    }
}
