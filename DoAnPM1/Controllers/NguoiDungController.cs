using ModelEF.Model;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using DoAnPM1.Areas.Admin.Controllers;

namespace DoAnPM1.Controllers
{
    public class NguoiDungController : BaseController
    {
        private connect db = new connect();


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.MaTKND = new SelectList(db.NguoiDungs, "MaTKND", "MaTKND");
            return View();
        }

        // POST: NguoiNuocNgoais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MaTKNNN,MatKhau,HoTen,NgaySinh,GioiTinh,SDT,Email,DiachiTT,QuocTich,Passport,MaTKND")] NguoiNuocNgoai nguoiNuocNgoai)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var check = db.NguoiNuocNgoais.SingleOrDefault(x => x.MaTKNNN ==nguoiNuocNgoai.MaTKNNN);
                    if (check==null)
                    {
                        db.NguoiNuocNgoais.Add(nguoiNuocNgoai);
                        await db.SaveChangesAsync();
                        SetAlert("Cập nhật thành công", "success");
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        SetAlert("Cập nhật không thành công!! ", "error");
                        ViewBag.error =("Mã tài khoản đã tồn tại");
                    }
                   
                }

                ViewBag.MaTKND = new SelectList(db.NguoiDungs, "MaTKND", "MaTKND", nguoiNuocNgoai.MaTKND);
                return View(nguoiNuocNgoai);
            }
            catch 
            {

                return Content("Error");
            }
           
        }


    }
}
