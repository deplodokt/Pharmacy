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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.Text = "Регистрация";
        }
        public bool CheckSeller()
        {
            using (PharmacyBDContext pharmacyBDContext = new PharmacyBDContext())
            {
                bool chekSeller = pharmacyBDContext.Seller.Any(p => p.LoginSeller == LoginEntrance.Text && p.PasswordSeller == PasswordEntrance.Text);
                return chekSeller;
            }
        }
        public bool CheckSuppliers()
        {
            using (PharmacyBDContext pharmacyBDContext = new PharmacyBDContext())
            {

                bool chekSuppliers = pharmacyBDContext.Suppliers.Any(p => p.LoginSuppliers == LoginEntrance.Text && p.PasswordSuppliers == PasswordEntrance.Text);
                return chekSuppliers;
            }
        }


        private void EnterSystem_Click(object sender, EventArgs e)
        {
            if (CheckSeller() == false && CheckSuppliers() == false)
            {
                using (PharmacyBDContext db = new PharmacyBDContext())
                {
                    Seller seller = new Seller()
                    { 
                        LastName = LastName.Text,
                        FirstName = FirstName.Text,
                        LoginSeller = LoginEntrance.Text,
                        PasswordSeller = PasswordEntrance.Text
                    };
                    db.Add(seller);
                    db.SaveChanges();
                }
                MessageBox.Show("Вы зарегистрировали продавца");
            }
            else
            {
                MessageBox.Show("Придумайте другой логин");
                LoginEntrance.Clear();
            }
        }

        private void BackWindows_Click(object sender, EventArgs e)
        {
            AdministrationWindows.AdministrationWindow administrationWindow = new AdministrationWindows.AdministrationWindow();
            administrationWindow.Show();
            this.Close();
        }
    }
}
