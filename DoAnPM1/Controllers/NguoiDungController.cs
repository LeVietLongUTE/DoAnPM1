using DoAnPM1.Areas.Admin.Controllers;
using DoAnPM1.Models;
using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DoAnPM1.Controllers
{

    public class NguoiDungController : BaseController
    {
        Connect db = new Connect();
        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DKTaiKhoanNNN()
        {
            return View();
        }


       
    }
}
     


    
