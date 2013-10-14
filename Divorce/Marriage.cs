using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce
{
    public class Marriage
    {
        [Key]
        public int MarriageId { get; set; }
        public DateTime  MarriageDate { get; set; }
        public DateTime SeparationDate { get; set; }
        public string  City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public virtual List<Spouse> Spouses { get; set; }
        public virtual Dependents Dependents { get; set; }
        public virtual List<Debt> Debts { get; set; }
        public int DivorceId { get; set; }
    }
}
