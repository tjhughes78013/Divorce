using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce
{
    public class Debt
    {
        public int DebtId { get; set; }
        public string Creditor { get; set; }
        public Decimal Amount { get; set; }
    }
}
