using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelEF.Model;
using DoAnPM1.Areas.Admin.Controllers;

namespace DoAnPM1.Controllers
{
    public class LuuTrusController : BaseController
    {
        private connect db = new connect();

        // GET: LuuTrus
        public async Task<ActionResult> Index()
        {
            var luuTrus = db.LuuTrus.Include(l => l.NguoiDung).Include(l => l.NguoiNuocNgoai);
            return View(await luuTrus.ToListAsync());
        }

        // GET: LuuTrus/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LuuTru luuTru = await db.LuuTrus.FindAsync(id);
            if (luuTru == null)
            {
                return HttpNotFound();
            }
            return View(luuTru);
        }

        // GET: LuuTrusabcsd/Create
        public ActionResult Create()
        {
            ViewBag.MaTKND = new SelectList(db.NguoiDungs, "MaTKND", "MaTKND");
            ViewBag.MaTKNNN = new SelectList(db.NguoiNuocNgoais, "MaTKNNN", "MaTKNNN");
            return View();
        }

        // POST: LuuTrusabcsd/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MaLT,MaTKNNN,MaTKND,NDKLT,NDLT,SoPhong,NDDK,NDTT,TrangThai")] LuuTru luuTru)
        {
            if (ModelState.IsValid)
            {
                db.LuuTrus.Add(luuTru);
                await db.SaveChangesAsync();
                SetAlert("Cập nhật thành công", "success");
                return RedirectToAction("Index");
            }

            ViewBag.MaTKND = new SelectList(db.NguoiDungs, "MaTKND", "MaTKND", luuTru.MaTKND);
            ViewBag.MaTKNNN = new SelectList(db.NguoiNuocNgoais, "MaTKNNN", "MaTKNNN", luuTru.MaTKNNN);
            return View(luuTru);
        }

        // GET: LuuTrus/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LuuTru luuTru = await db.LuuTrus.FindAsync(id);
            if (luuTru == null)
            {
                return HttpNotFound();
            }
           
            return View(luuTru);
        }

        // POST: LuuTrus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MaLT,MaTKNNN,MaTKND,NDKLT,NDLT,SoPhong,NDDK,NDTT,TrangThai")] LuuTru luuTru)
        {
            if (ModelState.IsValid)
            {
                db.Entry(luuTru).State = EntityState.Modified;
                await db.SaveChangesAsync();
                SetAlert("Cập nhật thành công", "success");
                return RedirectToAction("Index");
            }
            ViewBag.MaTKND = new SelectList(db.NguoiDungs, "MaTKND", "MaTKND", luuTru.MaTKND);
            ViewBag.MaTKNNN = new SelectList(db.NguoiNuocNgoais, "MaTKNNN", "MaTKNNN", luuTru.MaTKNNN);
            return View(luuTru);
        }

        // GET: LuuTrus/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LuuTru luuTru = await db.LuuTrus.FindAsync(id);
            if (luuTru == null)
            {
                return HttpNotFound();
            }
            return View(luuTru);
        }

        // POST: LuuTrus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            LuuTru luuTru = await db.LuuTrus.FindAsync(id);
            db.LuuTrus.Remove(luuTru);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
