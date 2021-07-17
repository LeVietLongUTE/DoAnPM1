using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DaoEF
{
    public class TKAdminDao
    {
        connect db = null;
        public TKAdminDao()
        {
            db = new connect();
        }

        public TKAdmin getById(string username)
        {
            return db.TKAdmins.SingleOrDefault(x => x.MaTK == username);
        }

        public bool Login(string username, string password)
        {
            var result = db.TKAdmins.Count(x => x.MaTK == username && x.MatKhau == password);
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
