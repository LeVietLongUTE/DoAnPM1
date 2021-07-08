using System;
using ModelEF.DaoEF;
using DoAnPM1.Common;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnPM1.Controllers
{
    public class NguoiNuocNgoaiController : Controller
    {
        // GET: NguoiNuocNgoai
        public ActionResult Index(string HoTen, string MaTKNNN, DateTime? NgaySinh,
            string GioiTinh, string SDT, string Email, string DiachiTT, string QuocTich, string Passport, string MaTKND)
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
            return View();
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Login");
        }

        public ActionResult Edit()
        {
            return RedirectToAction("Edit", "NguoiNuocNgoai");
        }
    }
}