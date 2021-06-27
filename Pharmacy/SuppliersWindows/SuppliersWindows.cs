using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.SuppliersWindows
{
    public partial class SuppliersWindows : Form
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

        public SuppliersWindows()
        {
            InitializeComponent();
            this.Text = "Окно постовщяка";
            UpTable();
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
        private void AddMedicationTovar_Click(object sender, EventArgs e)
        {
            AddMedication medication = new AddMedication();
            medication.Show();
            this.Close();
        }
    }
}
