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
                //var dao1 = new ChiTietLuuTruDao();
                var dao1 = new NguoiDungDao();
                var dao2 = new TKAdminDao();
                var dao3 = new TKNhanVienDao();

                var result = false;
                var result1 = false;
                var result2 = false;
                var result3 = false;
                if (model.Username == "" || model.Password == "" || model.Username == null || model.Password == null)
                {
                    ModelState.AddModelError("", "Cần Nhập đủ thông tin đăng nhập!");
                }
                else
                {
                    result = dao.Login(model.Username, Encryptor.MD5Hash(model.Password));
                    result1 = dao1.Login(model.Username, Encryptor.MD5Hash(model.Password));
                    result2 = dao2.Login(model.Username, Encryptor.MD5Hash(model.Password));
                    result3 = dao3.Login(model.Username, Encryptor.MD5Hash(model.Password));
                    if (result)
                    {
                        
                        var user = dao.getById(model.Username);
                        //var user1 = dao1.getById(model.MaCT);

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

                        //userSession.MaLT = user1.LuuTru.MaLT;
                        //userSession.TenCSKD = user1.LuuTru.NguoiDung.TenCSKD;
                        //userSession.DiaChiKD = user1.LuuTru.NguoiDung.DiaChiKD;

                        //userSession.ThoiGianDi = user1.ThoiGianDi;
                        //userSession.ThoiGianDen = user1.ThoiGianDen;
                        //userSession.DiaDiem = user1.DiaDiem;

                        Session.Add(CommonConstants.USER_SESSION, userSession);
                        return RedirectToAction("Index", "NguoiNuocNgoai");
                    }
                    else if(result1)
                    {
                        var user = dao1.getById(model.Username);
                        var userSession = new UserLogin();

                        userSession.UserName = user.MaTKND;
                        userSession.MaTKND = user.MaTKND;
                        Session.Add(CommonConstants.USER_SESSION, userSession);
                        return RedirectToAction("Index", "Home");
                    }
                    else if (result2)
                    {
                        var user = dao2.getById(model.Username);
                        var userSession = new UserLogin();

                        userSession.UserName = user.MaTK;
                        userSession.MaTK = user.MaTK;
                        Session.Add(CommonConstants.USER_SESSION, userSession);
                        return RedirectToAction("Index", "ChiTietLuuTru");
                    }
                    else if (result3)
                    {
                        var user = dao3.getById(model.Username);
                        var userSession = new UserLogin();

                        userSession.UserName = user.MaTKNV;
                        userSession.MaTK = user.MaTKNV;
                        Session.Add(CommonConstants.USER_SESSION, userSession);
                        return RedirectToAction("Create", "ChiTietLuuTru");
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