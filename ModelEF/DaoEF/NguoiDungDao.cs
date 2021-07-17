using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DaoEF
{
    public class NguoiDungDao
    {
        connect db = null;
        public NguoiDungDao()
        {
            db = new connect();
        }

        public NguoiDung getById(string username)
        {
            return db.NguoiDungs.SingleOrDefault(x => x.MaTKND == username);
        }

        public bool Login(string username, string password)
        {
            var result = db.NguoiDungs.Count(x => x.MaTKND == username && x.MatKhau == password);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
