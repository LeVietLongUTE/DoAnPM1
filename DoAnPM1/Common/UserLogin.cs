using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnPM1.Common
{
    [Serializable]
    public class UserLogin
    {
        public string UserName { set; get; }
        public string MaTKNNN { set; get; }
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