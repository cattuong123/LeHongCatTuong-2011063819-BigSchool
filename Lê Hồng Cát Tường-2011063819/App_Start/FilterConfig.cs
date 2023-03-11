using System.Web;
using System.Web.Mvc;

namespace Lê_Hồng_Cát_Tường_2011063819
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
