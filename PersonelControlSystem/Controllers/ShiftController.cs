using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PersonelControlSystem.Controllers
{
    public class ShiftController : Controller
    {
        ShiftManager shiftManager = new ShiftManager(new EfShiftDal());

        public IActionResult Index()
        {
            var values = shiftManager.TGetList();
            return View(values);
        }
    }
}
