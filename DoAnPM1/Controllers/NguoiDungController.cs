using DoAnPM1.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnPM1.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DKTaiKhoanNNN()
        {
            return View();
        }

     
        [HttpGet]
        public ActionResult DanhSachNNN(int page = 1, int pagesize = 5)
        {
            var nguoidung = new NguoiDungModels();
            var model = nguoidung.ListAll();
            return View(model.ToPagedList(page, pagesize));
        }
        [HttpPost]
        public ActionResult DanhSachNNN(string searchString, int page = 1, int pagesize = 5)
        {
            var nguoidung = new NguoiDungModels();
            var model = nguoidung.ListWhereAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model.ToPagedList(page, pagesize));
        }





        public ActionResult CapNhatTTDD()
        {
            return View();
        }
    }
}