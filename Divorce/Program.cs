using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DivorceContext();
            var currDivorce = new Divorce { CreatedDate = DateTime.Now };
            db.Divorces.Add(currDivorce);
            db.SaveChanges();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
