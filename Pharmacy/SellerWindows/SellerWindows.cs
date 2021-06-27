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
            dataGridView1.Columns[0].HeaderText = "Название"; //1
            dataGridView1.Columns[1].HeaderText = "Баркод"; //2
            dataGridView1.Columns[2].HeaderText = "Дата производства";
            dataGridView1.Columns[3].HeaderText = "Годен до";
            dataGridView1.Columns[4].HeaderText = "Рецепт";
            dataGridView1.Columns[5].HeaderText = "Цена"; //6
            dataGridView1.Columns[6].HeaderText = "Количество"; // 7
            dataGridView1.Columns[7].HeaderText = "Постовщик";
            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.HeaderText = "Добавить";
            addButton.Text = "Добавить";
            addButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(addButton);
            dataGridView1.AutoResizeColumns();
        }

  

        private void Tovars_Click(object sender, EventArgs e)
        {
            MedicalSuppliesWarehouse medicalSuppliesWarehouse = new MedicalSuppliesWarehouse();
            medicalSuppliesWarehouse.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            basket.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string titel = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string barcode = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string kol = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string price = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            MessageBox.Show(titel + " " + barcode + " " + kol + " " + price);
            BasketOrder.AddBasketOrder(titel, barcode, Convert.ToDouble(price), Convert.ToInt32(kol));
            
            using (PharmacyBDContext db = new PharmacyBDContext())
            {
                CatalogMedication mgDelete = db.CatalogMedication.Where(x => x.IdmedicationNavigation.NameMedication == titel).FirstOrDefault();

                mgDelete.QuantityCatalogMedication = mgDelete.QuantityCatalogMedication - 1;
                if (mgDelete.QuantityCatalogMedication == 0)
                {
                    db.Remove(mgDelete);
                }
                db.SaveChanges();
            }
           // RspoMagazines.KolMagazinesReport.KolMagazines.QualityMagazines++;
            UpCatalog();
        }

      
    }
}
