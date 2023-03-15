using System.Web;
using System.Web.Mvc;

namespace TruongAnhTuan_2011064166
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
