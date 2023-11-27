using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller {
        public IActionResult Index(){
            //localhost
            //localhost/home
            //localhost/home/index

            
            //dinamik veri yollama
            int clock = DateTime.Now.Hour;
            // var helloo = clock > 12 ? "İyi Günler":"Günaydın";
            // return View(model: helloo);

            //viewBag-viewData
            // ViewBag.helloo = clock > 12 ? "İyi Günler":"Günaydın";
            //bu yolla sayfada direk erişebilir

            // ViewBag.UserName = "Mert";

            ViewData["hello"] = clock > 12 ? "İyi Günler":"Günaydın";

            // ViewData["UserName"]= "Mert";

            var meetinginfo = new Meetinginfo(){
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = 100
            };

            return View(meetinginfo);
        }
    }
}