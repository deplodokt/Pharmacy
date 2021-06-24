﻿using System;
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
    public partial class AddMedication : Form
    {
        public AddMedication()
        {
            InitializeComponent();
            this.Text = "Добавления товара";
        }

        private void BackWindows_Click(object sender, EventArgs e)
        {
            SuppliersWindows suppliersWindows = new SuppliersWindows();
            suppliersWindows.Show();
            this.Close();
        }

        private void AddMedicationTovar_Click(object sender, EventArgs e)
        {
            using (PharmacyBDContext db = new PharmacyBDContext())
            {

                try
                {
                    Medication medication = new Medication()
                    {
                        NameMedication = AddNameMedication.Text,
                        Barcode = AddBarcode.Text,
                        ProductionDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()),
                        ExperienceDate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString()),
                        Price = Convert.ToInt32(PriceMedication.Text),
                        WhithReceipt = checkBox1.Checked ? "Нужен" : "Не нужен",
                        Quantity = Convert.ToInt32(Quantity.Text),
                        Idsuppliers = SellerWindows.SellerLogin.SellerLoginCurrent.IdSeller

                    };
                    db.Add(medication);
                    db.SaveChanges();
                    MessageBox.Show("Товар добавлен");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка");
                }
            }
            AddNameMedication.Clear();
            AddBarcode.Clear();
            PriceMedication.Clear();
            checkBox1.Checked = false;
        }
    }
}