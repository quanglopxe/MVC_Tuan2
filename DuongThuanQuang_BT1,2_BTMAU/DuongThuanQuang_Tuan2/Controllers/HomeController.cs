using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuongThuanQuang_Tuan2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            //ViewBag.Fruit = new List<string>()
            //{
            //    "Cam","Xoài","Cóc","Ổi"
            //};
            ViewData["Fruit"] = new List<string>()
            {
                  "Cam","Xoài","Cóc","Ổi"
            };
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
        public ActionResult MHList()
        {
            List<string> danhsach = new List<string>();
            danhsach.Add("Trương Mạnh Hùng");
            danhsach.Add("Nguyễn Hải Yến");
            danhsach.Add("Trương Thị Khánh Uyên");
            danhsach.Add("Trương Nguyễn Quỳnh Anh");

            ViewBag.DuLieu = danhsach;

            return View();
        }
    }
}