using System.Web;
using System.Web.Mvc;

namespace Test_VS2015_CiCd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
