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
        private connectData db = null;
        public NguoiDungModels()
        {
            db = new connectData();
        }
        public IEnumerable<LuuTru> ListAll()
        {
            return db.LuuTru.ToList();
        }
        public IEnumerable<LuuTru> ListWhereAll(string searchString, int page, int pagesize)
        {
            IQueryable<LuuTru> mode = db.LuuTru;
            if (!string.IsNullOrEmpty(searchString))
            {
                mode = mode.Where(x => x.MaTKNNN.Contains(searchString));
            }
            return mode.OrderBy(x => x.MaTKNNN).ToPagedList(page, pagesize);
        }
    }
}