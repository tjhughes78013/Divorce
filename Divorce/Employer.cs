using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce
{
    public class Employer
    {
        public int EmployerId { get; set; }
        public string EmployerName { get; set; }
        public virtual Address  EmployerAddress { get; set; }
        public virtual Phone EmployerPhone { get; set; }
        public Decimal MonthlyIncome { get; set; }
        public virtual Spouse  Spouse { get; set; }
    }
}
