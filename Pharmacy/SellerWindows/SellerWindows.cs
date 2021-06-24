using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.SellerWindows
{
    public partial class SellerWindows : Form
    {
        public void UpCatalog()
        {
            PharmacyBDContext pharmacyBDContext = new PharmacyBDContext();
            dataGridView1.DataSource = pharmacyBDContext.CatalogMedication.Select
                (catalog => new {
                
                    catalog.IdmedicationNavigation.NameMedication,
                    catalog.IdmedicationNavigation.Barcode,
                    catalog.IdmedicationNavigation.ProductionDate,
                    catalog.IdmedicationNavigation.ExperienceDate,
                    catalog.IdmedicationNavigation.WhithReceipt,
                    catalog.IdmedicationNavigation.Price,
                    catalog.QuantityCatalogMedication,
                    catalog.IdmedicationNavigation.IdsuppliersNavigation.NameSuppliers
                
                }).ToList();
        
        }
        public SellerWindows()
        {
            InitializeComponent();
            this.Text = "Окно продовца";
            UpCatalog();
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Баркод";
            dataGridView1.Columns[2].HeaderText = "Дата производства";
            dataGridView1.Columns[3].HeaderText = "Годен до";
            dataGridView1.Columns[4].HeaderText = "Рецепт";
            dataGridView1.Columns[5].HeaderText = "Цена";
            dataGridView1.Columns[6].HeaderText = "Количество";
            dataGridView1.Columns[7].HeaderText = "Постовщик";

            dataGridView1.AutoResizeColumns();
        }

  

        private void Tovars_Click(object sender, EventArgs e)
        {
            MedicalSuppliesWarehouse medicalSuppliesWarehouse = new MedicalSuppliesWarehouse();
            medicalSuppliesWarehouse.Show();
            this.Close();
        }
    }
}
