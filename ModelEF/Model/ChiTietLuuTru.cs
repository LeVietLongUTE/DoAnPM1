namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietLuuTru")]
    public partial class ChiTietLuuTru
    {
        [Key]
        [StringLength(8)]
        public string MaCT { get; set; }

        [Required]
        [StringLength(8)]
        public string MaLT { get; set; }

        public DateTime ThoiGianDen { get; set; }

        public DateTime ThoiGianDi { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaDiem { get; set; }

        public virtual LuuTru LuuTru { get; set; }
    }
}
