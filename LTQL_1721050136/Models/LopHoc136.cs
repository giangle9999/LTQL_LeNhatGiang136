using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050136.Models
{
    public partial class LopHoc136 : DbContext
    {
        public LopHoc136()
            : base("name=LopHoc136")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
