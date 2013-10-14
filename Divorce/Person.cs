using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce
{
    public enum PersonType { Husband, Wife, Child }
    public enum MarriageEndType { Divorce, Annulment, Death }


    public class Person
    {
        public int PersonId { get; set; }
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
        public string Suffix { get; set; }
        public DateTime DOB { get; set; }
        public string SSN { get; set; }
        public PersonType PersonType { get; set; }
    }

    public class Spouse 
    {
        [Key]
        public int SpouseId { get; set; }
        public int MarriageId { get; set; }
        public Boolean  Petitioner { get; set; }
        public virtual Person  Person { get; set; }
        public DateTime  ResidenceDate { get; set; }
        public int TotalMarriages { get; set; }
        public DateTime LastMariageEndedDate { get; set; }
        public MarriageEndType LastMariageEnded { get; set; }
        public virtual List<Address> Addresses { get; set; }
        public virtual List<Phone> PhoneNumbers { get; set; }
        public virtual List<Employer> Employers { get; set; }
        public virtual List<Debt> Debts { get; set; }
        public virtual List<string> EmailAddresses { get; set; }
        public virtual List<PropertyItem> PropertyItems { get; set; } 
        public virtual List<Vehicle> Vehicles { get; set; }
        public string MaidenName { get; set; }
        public Boolean SpousalMaintenance { get; set; }
        public Decimal SpousalMaintenanceAmount  { get; set; }
        public virtual Marriage  Marriage { get; set; }
        public string BirthPlace { get; set; }
        public string Race { get; set; }
    }

}
