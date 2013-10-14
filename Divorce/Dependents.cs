using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce
{
    public class Dependents
    {
        [Key]
        public int DependentsId { get; set; }
        public int MarriageId { get; set; }
        public virtual List<Person> Children { get; set; }
        public Boolean HealthInsurance { get; set; }
        public Decimal  HI_Cost { get; set; }
        public int HI_Responsible_SpouseId { get; set; } 
        public Boolean ChildCare { get; set; }
        public Decimal CC_Cost { get; set; }
        public int CC_Responsible_SpouseId { get; set; }
    }
}
