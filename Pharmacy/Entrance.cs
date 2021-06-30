using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
            this.Text = "Вход";
        }
        public bool CheckSuppliers()
        {
            using (PharmacyBDContext pharmacyBDContext = new PharmacyBDContext())
            {

                bool chekSuppliers = pharmacyBDContext.Suppliers.Any(p => p.LoginSuppliers == LoginEntrance.Text && p.PasswordSuppliers == PasswordEntrance.Text);

                Suppliers suppliers = pharmacyBDContext.Suppliers.FirstOrDefault(p => p.LoginSuppliers == LoginEntrance.Text);
                if (chekSuppliers == true)
                {
                        SuppliersWindows.Suppliers.SuppliersNameCurrent.NameSupplirs = suppliers.NameSuppliers;
                        SuppliersWindows.Suppliers.SuppliersNameCurrent.IdSuppliers = suppliers.Idsuppliers;
                }
                else if (chekSuppliers == false)
                {
                    return false;
                }
                return chekSuppliers;

            }
        }

        public bool CheckSeller()
        {
            using (PharmacyBDContext pharmacyBDContext = new PharmacyBDContext())
            {

                bool chekSeller = pharmacyBDContext.Seller.Any(p => p.LoginSeller == LoginEntrance.Text && p.PasswordSeller == PasswordEntrance.Text);

                Seller seller = pharmacyBDContext.Seller.FirstOrDefault(p => p.LoginSeller == LoginEntrance.Text);
                if (chekSeller == true)
                {
                    SellerWindows.SellerLogin.SellerLoginCurrent.LoginSeller = seller.LoginSeller;
                }
                else if (chekSeller == false)
                {
                    return false;
                }
                return chekSeller;

            }
        }

        public bool CheckAdmin()
        {
            using (PharmacyBDContext pharmacyBDContext = new PharmacyBDContext())
            {

                bool chekAdnim = pharmacyBDContext.Administration.Any(p => p.LoginAdministration == LoginEntrance.Text && p.PasswordAdministration == PasswordEntrance.Text);
                return chekAdnim;

            }
        }


        private void EnterSystem_Click(object sender, EventArgs e)
        {
            SellerWindows.SellerWindows sellerWindows = new SellerWindows.SellerWindows();
            SuppliersWindows.SuppliersWindows suppliersWindows = new SuppliersWindows.SuppliersWindows();
            AdministrationWindows.AdministrationWindow administrationWindow = new AdministrationWindows.AdministrationWindow();
            try
            {
                if (CheckSuppliers() == true)
                {
                    suppliersWindows.Show();

                    this.Hide();
                }
                else
                if (CheckSeller() == true)
                {
                    sellerWindows.Show();
                     this.Hide();
                }
               
                else
                if (CheckAdmin() == true)
                {
                    administrationWindow.Show();

                    this.Hide();
                }
                else if (CheckSuppliers() == false && CheckSeller() == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Вы ещё не зарегистрирована", "Регистрация");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверте введеные поля");

            }

        }
    }
}
