using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DaoEF
{
    public class NguoiNuocNgoaiDao
    {
        DoAnPM1Context db = null;
        public NguoiNuocNgoaiDao()
        {
            db = new DoAnPM1Context();
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

        public NguoiNuocNgoai ViewDetail(string MaTKNNN)
        {
            return db.NguoiNuocNgoais.Find(MaTKNNN);
        }
    }
}
