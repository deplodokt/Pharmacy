﻿using System;
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
                Medication medication = db.Medication.FirstOrDefault(p => p.NameMedication == num);
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
            }
            UpTable();
        }

        private void BackWindows_Click(object sender, EventArgs e)
        {
            SellerWindows sellerWindows = new SellerWindows();
            sellerWindows.Show();
            this.Close();
        }
    }
}