using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetingApp.Controllers
{
   
    public class MeetingController : Controller
    {
    
        // [HttpGet] Thanks.cshtml yaptım burdan artık direk erişim değilde katıldığında direk o sayfaya gitsin o sayfada return View("Thanks",model); ile direk gidecek
        // public IActionResult Index()
        // {
        //     return View();
        // }

        //[HttpGet] =>getrequest yazmasakta çalısır
        [HttpGet]
        public IActionResult Apply(){//toplantıya katılım formu
            return View();
        }

        [HttpPost] //formdan aldığım bilgileri tekrardan alıp kullanmak için

        //public IActionResult Apply(string Name, string Phone, string Email, bool WillAttend) bunun yerine şimdi taghelper ile metot oluşturup direk listeyi çekicem:UserInfo ==>ModelBinding
        public IActionResult Apply(UserInfo model){
            //bu bilgileri burda database ya da liste ile ekleyebilirim şimfdilik bunları model içinde repositroy.cs içine aldım

            Repository.CreatUser(model);

            //katılan kişi sayısını almak için burdan katılanların sayısını alıcam
            ViewBag.UserCount = Repository.Users.Where(info=>info.WillAttend == true).Count();
            return View("Thanks",model);
        }

        [HttpGet]
        public IActionResult List(){
            return View();
        }
    }
}