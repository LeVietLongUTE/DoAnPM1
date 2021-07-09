using DoAnPM1.Areas.Admin.Controllers;
using DoAnPM1.Models;
using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnPM1.Controllers
{
    public class NguoiDungController : BaseController
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





        public ActionResult CapNhatTTDD(string malt)
        {
            var dao = new NguoiDungModels();
            var result = dao.FindById(malt);


            if (result != null)
            {
               
                return View(result);
            }
            return View();
        }
        [HttpPost]
        public ActionResult CapNhatTTDD(LuuTru model)
        {
            if (ModelState.IsValid)
            {
                var dao = new NguoiDungModels();



                var result = dao.Edit(model);

                if (result)
                {
                    SetAlert("Cập nhật thông tin thành công", "success");
                    return RedirectToAction("DanhSachNNN", "NguoiDung");
                }
                else
                {
                    SetAlert("Cập nhật thông tin thất bại", "error");
                    //ModelState.AddModelError("", "Tạo người dùng không thành công");
                }

            }
            return View("DanhSachNNN");
        }
    }
}