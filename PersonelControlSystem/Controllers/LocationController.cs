using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PersonelControlSystem.Controllers
{
    public class LocationController : Controller
    {
        LocationManager locationManager = new LocationManager(new EfLocationDal());

        public IActionResult Index()
        {
            var values = locationManager.TGetList();
            return View(values);
        }
    }
}
