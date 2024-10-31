using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocationContact.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Giohang()
        {
            return View();
        }
        public ActionResult Dangnhap()
        {
            return View();
        }
        public ActionResult Dangki()
        {
            return View();
        }
        public ActionResult test()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TrangChu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LienHe()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TrangBlog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ChiTietSanPham()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TrangNike()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TrangLacoste()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TrangAdidas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}