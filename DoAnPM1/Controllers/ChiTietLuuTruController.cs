using DoAnPM1.Common;
using ModelEF.DaoEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using System.Web.Mvc;
using ModelEF.Model;

namespace DoAnPM1.Controllers
{
    public class ChiTietLuuTruController : BaseController
    {
        // GET: ChiTietLuuTru
        public ActionResult Index(int page = 1, int pageSize = 5)
        {
            var session = (UserLogin)Session[CommonConstants.USER_SESSION];
            ViewBag.MaCT = session.MaCT;
            ViewBag.Passport = session.Passport;

            var dao = new ChiTietLuuTruDao();

            var model = dao.ListAllPaging(page, pageSize);
            return View(model);
        }

        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ChiTietLuuTru entity)
        {

            if (ModelState.IsValid)
            {
                var dao = new ChiTietLuuTruDao();
                //if (dao.getById(user.MaCT) != null)
                //{
                //    SetAlert("Mã chi tiết đã có, vui lòng nhập mã chi tiết khác!", "warning");
                //    return RedirectToAction("Create", "User");
                //}
                if (   entity.MaLT == null 
                    || entity.ThoiGianDen == null 
                    || entity.ThoiGianDi == null 
                    || entity.DiaDiem == null
                    || entity.MaLT == "" 
                    || entity.DiaDiem == "")
                {
                    SetAlert("Vui lòng nhập đầy đủ thông tin!", "warning");
                    return RedirectToAction("Create", "ChiTietLuuTru");
                }
                
                long id = dao.Insert(entity);
                if (id > 0)
                {
                    SetAlert("Thêm mới chi tiết thành công!", "success");
                    return RedirectToAction("Index", "ChiTietLuuTru");
                }
                else
                {
                    SetAlert("Thêm mới chi tiết không thành công!", "error");
                }
            }
            
            return View("Index");
        }
        
    }
}