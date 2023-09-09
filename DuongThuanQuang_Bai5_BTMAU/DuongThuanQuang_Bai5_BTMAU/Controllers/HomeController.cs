using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuongThuanQuang_Bai5_BTMAU.Models;

namespace DuongThuanQuang_Bai5_BTMAU.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Create(string txt_id, string txt_name, int txt_pri, string file_avatar)
        {
            List<Sach> sach = new List<Sach>();
            
            
            return View();
        }
    }
}