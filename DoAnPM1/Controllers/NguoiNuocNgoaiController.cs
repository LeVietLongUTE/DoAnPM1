using ModelEF.DaoEF;
using DoAnPM1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using ModelEF.Model;

namespace DoAnPM1.Controllers
{
    public class NguoiNuocNgoaiController : BaseController
    {
        // GET: NguoiNuocNgoai
        public ActionResult Index(string HoTen, string MaTKNNN, DateTime? NgaySinh,
            string GioiTinh, string SDT, string Email, string DiachiTT, string QuocTich, string Passport, string MaTKND, int page = 1, int pageSize = 5)
        {
            var session = (UserLogin)Session[CommonConstants.USER_SESSION];
            ViewBag.MaTKNNN = session.MaTKNNN;
            ViewBag.HoTen = session.UserName;
            ViewBag.NgaySinh = session.NgaySinh;
            ViewBag.GioiTinh = session.GioiTinh;
            ViewBag.SDT = session.SDT;
            ViewBag.Email = session.Email;
            ViewBag.DiachiTT = session.DiachiTT;
            ViewBag.QuocTich = session.QuocTich;
            ViewBag.Passport = session.Passport;
            ViewBag.MaTKND = session.MaTKND;


            var dao = new NguoiNuocNgoaiDao();

            var model = dao.ListAllPaging(page, pageSize);
            return View(model);
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Login");
        }

        //public ActionResult Edit(string MaTKNNN)
        //{
        //    var user = new NguoiNuocNgoaiDao().ViewDetail(MaTKNNN);
        //    SetViewBag();
        //    return View(user);
        //}

        //public ActionResult Edit(string MaTKNNN)
        //{
        //    var user = new NguoiNuocNgoaiDao().ViewDetail(MaTKNNN);
        //    return View(user);
        //}

        public ActionResult Edit(string MaTKNNN, string HoTen)
        {
            var session = (UserLogin)Session[CommonConstants.USER_SESSION];
            ViewBag.HoTen = session.UserName;

            var entity = new NguoiNuocNgoaiDao().ViewDetail(MaTKNNN);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(NguoiNuocNgoai entity)
        {

            if (ModelState.IsValid)
            {
                var dao = new NguoiNuocNgoaiDao();

                if (   entity.HoTen == ""
                    || entity.NgaySinh == null
                    || entity.GioiTinh == null
                    || entity.Email == ""
                    || entity.SDT == ""
                    || entity.QuocTich == ""
                    || entity.DiachiTT == ""
                    )
                {
                    SetAlert("Vui lòng nhập đầy đủ thông tin!", "warning");
                    return RedirectToAction("Edit", "NguoiNuocNgoai");
                }
                var result = dao.Update(entity);
                if (result)
                {
                    SetAlert("Cập nhật thành công!", "success");
                    return RedirectToAction("Index", "NguoiNuocNgoai");
                }
                else
                {
                    SetAlert("Cập nhật không thành công!", "error");
                    ModelState.AddModelError("", "Cập nhật không thành công");
                }
            }
            return View("Index");
        }
    }
}