using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LTQL_1721050136.Models
{
    public class SinhVien
    {
        [Key]
        [Display(Name = "Mã Sinh Viên")]
        public int MaSinhVien { get; set; }
        [StringLength(50)]
        [Display(Name = "Họ Tên")]
        public string HoTen { get; set; }
        [Display(Name = "Mã Lớp")]
        public int MaLop { get; set; }
        [ForeignKey("MaLop")]
        public virtual LopHoc136 LopHoc136 { get; set; }
    }
}