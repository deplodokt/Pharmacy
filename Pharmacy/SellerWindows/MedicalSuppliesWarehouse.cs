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
    public partial class MedicalSuppliesWarehouse : Form
    {
        public void UpTable()
        {
            PharmacyBDContext pharmacyBDContext = new PharmacyBDContext();
            dataGridView1.DataSource = pharmacyBDContext.Medication.
                Select(medication => new
                {
                    medication.NameMedication,
                    medication.Barcode,
                    medication.ProductionDate,
                    medication.ExperienceDate,
                    medication.WhithReceipt,
                    medication.Price,
                    medication.Quantity,
                    medication.IdsuppliersNavigation.NameSuppliers
                }
                ).ToList();
        }
        public MedicalSuppliesWarehouse()
        {
            InitializeComponent();
            this.Text = "Окно склада продукции";
            UpTable();
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Баркод";
            dataGridView1.Columns[2].HeaderText = "Дата производства";
            dataGridView1.Columns[3].HeaderText = "Годен до";
            dataGridView1.Columns[4].HeaderText = "Рецепт";
            dataGridView1.Columns[5].HeaderText = "Цена";
            dataGridView1.Columns[6].HeaderText = "Количество";
            dataGridView1.Columns[7].HeaderText = "Постовщик";

            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.HeaderText = "Добавить";
            addButton.Text = "Добавить";
            addButton.UseColumnTextForButtonValue = true;
            addButton.Width = 100;
            dataGridView1.Columns.Add(addButton);
            dataGridView1.AutoResizeColumns();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string num = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            using (PharmacyBDContext db = new PharmacyBDContext())
            {
                try
                {
                    bool catalogMedicationCheck = db.CatalogMedication.Any(p => p.IdmedicationNavigation.NameMedication == num);
                    CatalogMedication catalogMedicationTwo = db.CatalogMedication.FirstOrDefault(p => p.IdmedicationNavigation.NameMedication == num);
                    Medication medication = db.Medication.FirstOrDefault(p => p.NameMedication == num);
                    if (catalogMedicationCheck == false)
                    {
                        CatalogMedication catalogMedication = new CatalogMedication()
                        {
                            Idmedication = medication.Idmedication,
                            QuantityCatalogMedication = Convert.ToInt32(Quantity.Text)
                        };

                        db.Add(catalogMedication);
                        medication.Quantity -= Convert.ToInt32(Quantity.Text);
                        if (medication.Quantity == 0)
                        {
                            db.Remove(medication);
                        }
                        db.SaveChanges();
                        UpTable();

                    }
                    else if (catalogMedicationCheck == true)
                    {
                        CatalogMedication catalogMedication = new CatalogMedication();
                        catalogMedicationTwo.QuantityCatalogMedication += Convert.ToInt32(Quantity.Text);
                        medication.Quantity -= Convert.ToInt32(Quantity.Text);
                        db.SaveChanges();
                        UpTable();

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Введите количество");
                }
            }
            UpTable();
        }

        private void BackWindows_Click(object sender, EventArgs e)
        {
            SellerWindows sellerWindows = new SellerWindows();
            sellerWindows.Show();
            this.Close();
        }

        private void SearchTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                //{
                //    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                //}
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null && dataGridView1.Rows[i].Cells[j].Value.ToString() == SearchTable.Text)
                        {
                            dataGridView1.Rows[i].Cells[j].Selected = true;
                 //           dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }

                }
                
                //SearchTable.Clear();
            }
        }
    }
}
