using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce
{
    public class PropertyItem
    {
        [Key]
        public int PropertyId { get; set; }
        public string Description { get; set; }
        public Decimal  Value { get; set; }
    }
}
