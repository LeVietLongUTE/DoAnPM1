using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnPM1.Models
{
    public class NguoiDungModels
    {
        private Connect db = null;
        public NguoiDungModels()
        {
            db = new Connect();
        }
        public IEnumerable<LuuTru> ListAll()
        {
            return db.LuuTrus.ToList();
        }
        public IEnumerable<LuuTru> ListWhereAll(string searchString, int page, int pagesize)
        {
            IQueryable<LuuTru> mode = db.LuuTrus;
            if (!string.IsNullOrEmpty(searchString))
            {
                mode = mode.Where(x => x.MaTKNNN.Contains(searchString));
            }
            return mode.OrderBy(x => x.MaTKNNN).ToPagedList(page, pagesize);
        }
        public LuuTru FindById(string MaLT)
        {         
            return db.LuuTrus.Find(MaLT);
        }
        public bool Edit(LuuTru LuuTru)
        {
            try
            {
                LuuTru lt = FindById(LuuTru.MaLT.Trim());
                lt.MaLT = LuuTru.MaLT;
                lt.MaTKNNN = LuuTru.MaTKNNN;
                lt.NDKLT = LuuTru.NDKLT;
                lt.NDLT = LuuTru.NDLT;
                lt.SoPhong = LuuTru.SoPhong;
                lt.NDDK = LuuTru.NDDK;
                lt.NDTT = LuuTru.NDTT;
                lt.TrangThai = LuuTru.TrangThai;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public LuuTru FindIDLT(string MaLT)
        {
            return db.LuuTrus.Find(MaLT);
        }
    }
}