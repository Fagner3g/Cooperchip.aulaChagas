using Cooperchip.aulaChagas.Web.Filtros;
using System.Web;
using System.Web.Mvc;

namespace Cooperchip.aulaChagas.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            filters.Add(new LogActionFilter()); //Filtro de log na saída para todo projeto.
        }
    }
}
