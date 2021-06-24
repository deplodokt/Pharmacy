using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.AdministrationWindows
{
    public partial class AdministrationWindow : Form
    {
        public void UpTableSeller()
        {
            PharmacyBDContext pharmacyBDContext = new PharmacyBDContext();
            dataGridView2.DataSource = pharmacyBDContext.Seller.Select
                (seller => new
                {
                    seller.FirstName,
                    seller.LastName,
                    seller.LoginSeller
                }).ToList();

        }
        public void UpTableSupplier()
        {
            PharmacyBDContext pharmacyBDContext = new PharmacyBDContext();
            dataGridView1.DataSource = pharmacyBDContext.Suppliers.Select
                (supplier => new
                {
                    supplier.NameSuppliers,
                    supplier.LoginSuppliers
                }).ToList();

        }

        public AdministrationWindow()
        {
            InitializeComponent();
            this.Text = "Администратор";
            UpTableSupplier();
            dataGridView1.Columns[0].HeaderText = "Названия поставщика";
            dataGridView1.Columns[1].HeaderText = "Логин";

            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.HeaderText = "Удалить";
            addButton.Text = "Удалить";
            addButton.UseColumnTextForButtonValue = true;
            addButton.Width = 110;
            dataGridView1.Columns.Add(addButton);
            UpTableSeller();
            DataGridViewButtonColumn addButton2 = new DataGridViewButtonColumn();
            dataGridView2.Columns[0].HeaderText = "Фамилия";
            dataGridView2.Columns[1].HeaderText = "Имя";
            dataGridView2.Columns[2].HeaderText = "Логин";
            addButton2.HeaderText = "Удалить";
            addButton2.Text = "Удалить";
            addButton2.UseColumnTextForButtonValue = true;
            addButton2.Width = 110;
            dataGridView2.Columns.Add(addButton2);

        }




        private void AddSupplier_Click(object sender, EventArgs e)
        {
            AdministrationWindows.AddSuppliers addSuppliers = new AddSuppliers();
            addSuppliers.Show();
            this.Close();
        }

        private void AddSeller_Click(object sender, EventArgs e)
        {
            AdministrationWindows.Registration registration = new Registration();
            registration.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string num = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                using (PharmacyBDContext db = new PharmacyBDContext())
                {
                    Seller sellerDelete = db.Seller.Where(x => x.LoginSeller == num).FirstOrDefault();
                    db.Remove(sellerDelete);
                    db.SaveChanges();
                }
                UpTableSeller();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string num = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                using (PharmacyBDContext db = new PharmacyBDContext())
                {
                    Suppliers supplierDelete = db.Suppliers.Where(x => x.NameSuppliers == num).FirstOrDefault();
                    db.Remove(supplierDelete);
                    db.SaveChanges();
                }
                UpTableSupplier();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
