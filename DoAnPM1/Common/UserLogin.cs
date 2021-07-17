using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnPM1.Common
{
    [Serializable]
    public class UserLogin
    {
        public string MaTKNNN { set; get; }
        public string UserName { set; get; }
        
        public DateTime? NgaySinh { set; get; }
        public string GioiTinh { set; get; }
        public string SDT { set; get; }
        public string Email { set; get; }
        public string DiachiTT { set; get; }
        public string QuocTich { get; set; }
        public string Passport { get; set; }
        public string MaTKND { get; set; }

        public string MaCT { get; set; }
        public string MaLT { get; set; }
        public string TenCSKD { get; set; }
        public string DiaChiKD { get; set; }

        public DateTime? ThoiGianDen { get; set; }
        public DateTime? ThoiGianDi { get; set; }
        public string DiaDiem { get; set; }

        public string MaTK { get; set; }

        public string MaTKNV { get; set; }
    }
}