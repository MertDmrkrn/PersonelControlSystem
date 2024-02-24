using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PersonelControlSystem.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        public IActionResult Index()
        {
            var values = projectManager.TGetList();
            return View(values);
        }
    }
}
