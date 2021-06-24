using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Pharmacy
{
    public partial class Medication
    {
        public Medication()
        {
            CatalogMedication = new HashSet<CatalogMedication>();
        }

        public int Idmedication { get; set; }
        public string NameMedication { get; set; }
        public string Barcode { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExperienceDate { get; set; }
        public double Price { get; set; }
        public string WhithReceipt { get; set; }
        public int Quantity { get; set; }
        public int? Idsuppliers { get; set; }

        public virtual Suppliers IdsuppliersNavigation { get; set; }
        public virtual ICollection<CatalogMedication> CatalogMedication { get; set; }
    }
}
