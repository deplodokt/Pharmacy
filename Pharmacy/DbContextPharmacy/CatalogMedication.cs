using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Pharmacy
{
    public partial class CatalogMedication
    {
        public int IdcatalogMedication { get; set; }
        public int? Idmedication { get; set; }
        public int QuantityCatalogMedication { get; set; }

        public virtual Medication IdmedicationNavigation { get; set; }
    }
}
