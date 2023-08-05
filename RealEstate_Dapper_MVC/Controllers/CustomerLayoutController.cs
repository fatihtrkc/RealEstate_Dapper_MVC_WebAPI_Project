using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_MVC.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
