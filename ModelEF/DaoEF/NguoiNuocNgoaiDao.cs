using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DaoEF
{
    public class NguoiNuocNgoaiDao
    {
        connect db = null;
        public NguoiNuocNgoaiDao()
        {
            db = new connect();
        }

        public string Insert(NguoiNuocNgoai entity)
        {
            db.NguoiNuocNgoais.Add(entity);
            db.SaveChanges();
            return entity.MaTKNNN;
        }
        

        public bool Update(NguoiNuocNgoai entity)
        {
            try
            {
                var NguoiNuocNgoai = db.NguoiNuocNgoais.Find(entity.MaTKNNN);
                NguoiNuocNgoai.HoTen = entity.HoTen;
                NguoiNuocNgoai.NgaySinh = entity.NgaySinh;
                NguoiNuocNgoai.GioiTinh = entity.GioiTinh;
                NguoiNuocNgoai.Email = entity.Email;
                NguoiNuocNgoai.SDT = entity.SDT;
                NguoiNuocNgoai.QuocTich = entity.QuocTich;
                NguoiNuocNgoai.DiachiTT = entity.DiachiTT;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public NguoiNuocNgoai ViewDetail(string MaTKNNN)
        {
            return db.NguoiNuocNgoais.Find(MaTKNNN);
        }

        public NguoiNuocNgoai getById(string username)
        {
            return db.NguoiNuocNgoais.SingleOrDefault(x => x.MaTKNNN == username);
        }

        public bool Login(string username, string password)
        {
            var result = db.NguoiNuocNgoais.Count(x => x.MaTKNNN == username && x.MatKhau == password);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<NguoiNuocNgoai> ListAll()
        {
            return db.NguoiNuocNgoais.ToList();
        }

        public IEnumerable<NguoiNuocNgoai> ListAllPaging( int page, int pageSize)
        {
            IQueryable<NguoiNuocNgoai> model = db.NguoiNuocNgoais;
            
            return model.OrderByDescending(x => x.MaTKNNN).ToPagedList(page, pageSize);
        }
    }
}
