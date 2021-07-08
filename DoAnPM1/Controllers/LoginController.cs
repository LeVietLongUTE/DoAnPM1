using DoAnPM1.Models;
using System;
using ModelEF.DaoEF;
using DoAnPM1.Common;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnPM1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)

        {
            if (ModelState.IsValid)
            {
                var dao = new NguoiNuocNgoaiDao();
                var result = false;
                if (model.Username == "" || model.Password == "" || model.Username == null || model.Password == null)
                {
                    ModelState.AddModelError("", "Cần Nhập đủ thông tin đăng nhập!");
                }
                else
                {
                    result = dao.Login(model.Username, Encryptor.MD5Hash(model.Password));
                    if (result)
                    {


                        var user = dao.getById(model.Username);
                        var userSession = new UserLogin();

                        userSession.UserName = user.HoTen;
                        userSession.MaTKNNN = user.MaTKNNN;
                        userSession.NgaySinh = user.NgaySinh;
                        userSession.GioiTinh = user.GioiTinh;
                        userSession.SDT = user.SDT;
                        userSession.Email = user.Email;
                        userSession.DiachiTT = user.DiachiTT;
                        userSession.QuocTich = user.QuocTich;
                        userSession.Passport = user.Passport;
                        userSession.MaTKND = user.MaTKND;
                        Session.Add(CommonConstants.USER_SESSION, userSession);
                        return RedirectToAction("Index", "NguoiNuocNgoai");
                    }
                    else
                    {
                        if (model.Username == "" || model.Password == "" || model.Username == null || model.Password == null)
                        {
                            ModelState.AddModelError("", "Cần Nhập đủ thông tin đăng nhập!");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Đăng nhập không hợp lệ");

                        }

                    }
                }
            }
            return View("Index");
        }
    }
}