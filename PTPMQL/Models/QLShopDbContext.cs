using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL.Models
{
    public partial class QLShopDbContext : DbContext
    {
        public QLShopDbContext()
            : base("name=QLShopDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<PTPMQL.Models.HangHoa> HangHoas { get; set; }
    }
}
