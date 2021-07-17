using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DaoEF
{
    public class TKNhanVienDao
    {
        connect db = null;
        public TKNhanVienDao()
        {
            db = new connect();
        }

        public TKNhanVien getById(string username)
        {
            return db.TKNhanViens.SingleOrDefault(x => x.MaTKNV == username);
        }

        public bool Login(string username, string password)
        {
            var result = db.TKNhanViens.Count(x => x.MaTKNV == username && x.MatKhau == password);
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
