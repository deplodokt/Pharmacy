using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Pharmacy
{
    public partial class Suppliers
    {
        public Suppliers()
        {
            Medication = new HashSet<Medication>();
        }

        public int Idsuppliers { get; set; }
        public string NameSuppliers { get; set; }
        public string LoginSuppliers { get; set; }
        public string PasswordSuppliers { get; set; }

        public virtual ICollection<Medication> Medication { get; set; }
    }
}
