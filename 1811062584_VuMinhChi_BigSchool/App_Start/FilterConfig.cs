using System.Web;
using System.Web.Mvc;

namespace _1811062584_VuMinhChi_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
