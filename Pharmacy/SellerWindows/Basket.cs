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
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
            this.Text = "Корзина";
            TotalPriceOrder.Text = BasketOrder.TotalPrice().ToString();
            comboBox1.DataSource = BasketOrder.baskets;
            label3.Text = SellerLogin.SellerLoginCurrent.LoginSeller;
        }

        private void CreateBuyerOrder_Click(object sender, EventArgs e)
        {
          /*  DialogResult dialogResult = MessageBox.Show("Вы точно хотите оформить заказ?", "Оформление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                int counter = 0;
                double sum = 1;
                var builder = new StringBuilder();
                string check = RandomKodUser.RandomString();

                builder.AppendLine($"{"".PadRight(25, ' ')}ОАО \"ReBerries\" ");
                foreach (var product in UserWindows.AddBasket.baskets)
                {

                    counter++;
                    builder.AppendLine($"{counter}.{product.TitleAddBasket}");
                    builder.AppendLine($"  Стоимость{"".PadRight(40 - product.PriceAddBasket.ToString().Length, '.')}{product.PriceAddBasket}");
                }
                builder.AppendLine("".PadRight(51, '='));
                builder.AppendLine($"{DateTime.Now.ToString("G")} {"".PadRight(41 - DateTime.Now.ToString("G").Length, '.')}№{check}");
                builder.AppendLine($"Всего{"".PadRight(46 - UserWindows.AddBasket.PriceMagazines().ToString().Length, '.')}{UserWindows.AddBasket.PriceMagazines().ToString()}");
                if (sumAll > 0)
                {
                    builder.AppendLine($"Скидка{"".PadRight(40, ' ')}" + sumAll + "%");
                    sum = (Convert.ToDouble(UserWindows.AddBasket.PriceMagazines()) / 100 * PromoSell);
                }
                sum = 0;
                builder.AppendLine($"Итого{"".PadRight(45 - UserWindows.AddBasket.PriceMagazines().ToString().Length, '.')}{Math.Round((UserWindows.AddBasket.PriceMagazines() - sum), 3).ToString()}");
                File.WriteAllText(@"D:\Практика РСПО\RspoMagazines\RspoMagazines\Receipts\" + check + ".txt", builder.ToString());
                MessageBox.Show("Заказ оформлен");
                using (magazinesShopContext db = new magazinesShopContext())
                {
                    QuantitySold quantitySold = new QuantitySold()
                    {

                        QuantitySoldMagazines = RspoMagazines.KolMagazinesReport.KolMagazines.QualityMagazines,
                        QuantitySoldPrice = UserWindows.AddBasket.PriceMagazines() - sum,
                        DateQuantitySold = DateTime.Now
                    };
                    db.Add(quantitySold);
                    db.SaveChanges();
                }
            }*/
        }

       

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            string buffTitel = BasketOrder.baskets[comboBox1.SelectedIndex].NameMedication.ToString();
            using (PharmacyBDContext db = new PharmacyBDContext())
            {
                CatalogMedication catalog = new CatalogMedication();
                catalog  = db.CatalogMedication.FirstOrDefault(p => p.IdmedicationNavigation.NameMedication == buffTitel);
                catalog.QuantityCatalogMedication++;
                db.SaveChanges();
            }
            BasketOrder.baskets.RemoveAt(Convert.ToInt32(comboBox1.SelectedIndex));
            comboBox1.DataSource = null;
            comboBox1.DataSource = BasketOrder.baskets;

        }
        private void BackWindows_Click(object sender, EventArgs e)
        {
            SellerWindows sellerWindows = new SellerWindows();
            sellerWindows.Show();
            this.Close();
        }
    }
}
