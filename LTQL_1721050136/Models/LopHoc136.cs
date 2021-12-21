using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL_1721050136.Models
{
    [Table("LopHoc136")]
    public class LopHoc136
    {
        [Key]
        [Display(Name ="Mã Lớp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLop { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên Lớp")]
        public string TenLop { get; set; }
        public ICollection<SinhVien> SinhViens { get; set; }

    }
}