using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnPM1.Models
{
    public class LoginModel
    {
        public string Username { get; set; }

        public string MaTKNNN { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public DateTime? NgaySinh { set; get; }

        public string GioiTinh { set; get; }

        public string SDT { set; get; }

        public string Email { set; get; }

        public string DiachiTT { set; get; }

        public string QuocTich { get; set; }

        public string Passport { get; set; }

        public string MaTKND { get; set; }
    }
}