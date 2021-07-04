namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TKAdmin")]
    public partial class TKAdmin
    {
        [Key]
        [StringLength(4)]
        public string MaTK { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }
    }
}
