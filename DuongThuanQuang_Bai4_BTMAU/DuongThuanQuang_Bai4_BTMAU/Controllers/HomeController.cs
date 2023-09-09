using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DuongThuanQuang_Bai4_BTMAU.Models;
namespace DuongThuanQuang_Bai4_BTMAU.Controllers
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
        public ActionResult Index2()
        {
            NhanVien nv = new NhanVien();
            return View(nv);
        }
    }
}