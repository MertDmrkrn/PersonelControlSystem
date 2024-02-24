using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace PersonelControlSystem.Controllers
{
    public class PersonelController : Controller
    {
        PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
        Context db = new Context();
        public IActionResult Index()
        {
            //var result = (from personel in db.Personels
            //              join user in db.Users
            //              on personel.UserID equals user.UserID //isim getirdik
            //              join location in db.Locations
            //              on personel.LocationID equals location.LocationID//lokasyonu getirdik
            //              join shift in db.Shifts
            //              on personel.ShiftID equals shift.ShiftID//vardiyayı getirdik
            //              join project in db.Projects
            //              on personel.ProjectID equals project.ProjectID//projeyi getirdik

            //              select new
            //              {
            //                  PersonelID = personel.PersonelID,
            //                  PersonelName = user.Name,
            //                  PersonelLocation = location.LocationName,
            //                  PersonelShift = shift.ShiftName,
            //                  PersonelProject = project.ProjectName
            //              }).ToList();
            var values = personelManager.GetPersonelListWithLocation();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPersonel() 
        {

            //Location DropDownList
            List<SelectListItem> degerler = (from i in db.Locations.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.LocationName,
                                                 Value = i.LocationID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;


            //Shift DropDownList
            List<SelectListItem> degerler2 = (from j in db.Shifts.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = j.ShiftName,
                                                  Value = j.ShiftID.ToString()
                                              }).ToList();
            ViewBag.dgr2 = degerler2;


            //Project DropDownList
            List<SelectListItem> degerler3 = (from j in db.Projects.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = j.ProjectName,
                                                  Value = j.ProjectID.ToString()
                                              }).ToList();
            ViewBag.dgr3 = degerler3;

            return View();
        }


        [HttpPost]
        public IActionResult AddPersonel(Personel personel)
        {
            personelManager.TAdd(personel);
            return RedirectToAction("Index");
        }
    }

}
