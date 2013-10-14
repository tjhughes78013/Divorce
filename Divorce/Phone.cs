using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce
{
    public enum PhoneType { Home, Cell, Work };

    public class Phone
    {
        public int PhoneId { get; set; }
        public String PhoneNumber { get; set; }
        public PhoneType  PhoneType { get; set; }
    }
}
