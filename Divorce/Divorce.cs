using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce
{
    public class Divorce
    {
        [Key]
        public int DivorceId { get; set; }
        public virtual Marriage  Marriage {get; set; }
        public DateTime  CreatedDate { get; set; }
    }

    public class DivorceContext : DbContext
    {
        public DbSet<Divorce> Divorces { get; set; }
        public DbSet<Marriage> Marriages { get; set; }
        public DbSet<Spouse> Spouses { get; set; } 
        public DbSet<Dependents> DependentList { get; set; }
    }



}
