using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace PersonelControlSystem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {

            //Weather 

            string api = "38b21d43c3b94b2b525eb00280efdf96";

            //Kocaeli Hava Durumu
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Kocaeli&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.a = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //Bursa Hava Durumu
            string connection2 = "https://api.openweathermap.org/data/2.5/weather?q=Bursa&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document2 = XDocument.Load(connection2);
            ViewBag.b = document2.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //İstanbul Hava Durumu
            string connection3 = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document3 = XDocument.Load(connection3);
            ViewBag.c = document3.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //İzmir Hava Durumu
            string connection4 = "https://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document4= XDocument.Load(connection4);
            ViewBag.d = document4.Descendants("temperature").ElementAt(0).Attribute("value").Value;


            return View();
        }
    }
}
