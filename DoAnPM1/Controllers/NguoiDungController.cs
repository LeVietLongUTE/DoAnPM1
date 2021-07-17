using ModelEF.Model;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;

namespace DoAnPM1.Controllers
{
    public class NguoiDungController : Controller
    {
        private connect db = new connect();
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
            if (ModelState.IsValid)
            {
                
                db.NguoiNuocNgoais.Add(nguoiNuocNgoai);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.MaTKND = new SelectList(db.NguoiDungs, "MaTKND", "MaTKND", nguoiNuocNgoai.MaTKND);
            return View(nguoiNuocNgoai);
        }


    }
}
