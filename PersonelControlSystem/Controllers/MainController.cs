using Microsoft.AspNetCore.Mvc;

namespace PersonelControlSystem.Controllers
{
    public class MainController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
    }
}
