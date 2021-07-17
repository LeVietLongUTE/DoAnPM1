using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using ModelEF.Model;

namespace ModelEF.DaoEF
{
    public class ChiTietLuuTruDao
    {
        connect db = null;
        public ChiTietLuuTruDao()
        {
            db = new connect();
        }

        //public string Insert(ChiTietLuuTru entity)
        //{
        //    db.ChiTietLuuTrus.Add(entity);
        //    db.SaveChanges();
        //    return entity.MaCT;
        //}

        public long Insert(ChiTietLuuTru entity)
        {
            db.ChiTietLuuTrus.Add(entity);
            db.SaveChanges();
            return entity.MaCT;
        }

        public bool Update(ChiTietLuuTru entity)
        {
            try
            {
                var ChiTietLuuTru = db.ChiTietLuuTrus.Find(entity.MaCT);
                ChiTietLuuTru.MaLT = entity.MaLT;
                ChiTietLuuTru.ThoiGianDen = entity.ThoiGianDen;
                ChiTietLuuTru.ThoiGianDi = entity.ThoiGianDi;
                ChiTietLuuTru.DiaDiem = entity.DiaDiem;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ChiTietLuuTru ViewDetail(int MaCT)
        {
            return db.ChiTietLuuTrus.Find(MaCT);
        }

        //public NguoiNuocNgoai ViewDetail(string MaTKNNN)
        //{
        //    return db.NguoiNuocNgoais.Find(MaTKNNN);
        //}

        //public ChiTietLuuTru getById(string username)
        //{
        //    return db.ChiTietLuuTrus.SingleOrDefault(x => x.LuuTru.MaLT == username);
        //}

        public List<ChiTietLuuTru> ListAll()
        {
            return db.ChiTietLuuTrus.ToList();
        }

        //public bool Login(string username, string password)
        //{
        //    var result = db.NguoiNuocNgoais.Count(x => x.MaTKNNN == username && x.MatKhau == password);
        //    if (result > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public IEnumerable<ChiTietLuuTru> ListAllPaging(int page, int pageSize)
        {
            IQueryable<ChiTietLuuTru> model = db.ChiTietLuuTrus;
            
            return model.OrderByDescending(x => x.MaCT).ToPagedList(page, pageSize);
        }
    }
}
