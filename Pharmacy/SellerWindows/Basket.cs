using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            int counter = 0;
            double sum = 1;
            var builder = new StringBuilder();
            string check = RandomReceipt.RandomKod.RandomString();

            builder.AppendLine($"{"".PadRight(25, ' ')}ОАО \"Дуптик\" ");
            foreach (var product in BasketOrder.baskets)
            {

                counter++;
                builder.AppendLine($"{counter}.{product.NameMedication}");
                builder.AppendLine($"Код: {product.Barcode}");
                builder.AppendLine($"  Стоимость{"".PadRight(40 - product.Price.ToString().Length, '.')}{product.Price}");
            }
            builder.AppendLine("".PadRight(51, '='));
            builder.AppendLine($"{DateTime.Now.ToString("G")} {"".PadRight(40 - DateTime.Now.ToString("G").Length, '.')} №{check}");
            builder.AppendLine($"Итого{"".PadRight(45 - BasketOrder.TotalPrice().ToString().Length, '.')}{Math.Round((BasketOrder.TotalPrice()), 3).ToString()}");
            File.WriteAllText(@"D:\КПиЯП\Pharmacy\Pharmacy\SellerWindows\BuyersReceipt\" + check + ".txt", builder.ToString());
            MessageBox.Show("Чек покупателя");
            /* using (magazinesShopContext db = new magazinesShopContext())
             {
                 QuantitySold quantitySold = new QuantitySold()
                 {

                     QuantitySoldMagazines = RspoMagazines.KolMagazinesReport.KolMagazines.QualityMagazines,
                     QuantitySoldPrice = UserWindows.AddBasket.PriceMagazines() - sum,
                     DateQuantitySold = DateTime.Now
                 };
                 db.Add(quantitySold);
                 db.SaveChanges();
             }*/
        }



        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            string buffTitel = BasketOrder.baskets[comboBox1.SelectedIndex].NameMedication.ToString();
            using (PharmacyBDContext db = new PharmacyBDContext())
            {
                CatalogMedication catalog = new CatalogMedication();
                catalog = db.CatalogMedication.FirstOrDefault(p => p.IdmedicationNavigation.NameMedication == buffTitel);
                catalog.QuantityCatalogMedication++;
                db.SaveChanges();
            }
            BasketOrder.baskets.RemoveAt(Convert.ToInt32(comboBox1.SelectedIndex));
            comboBox1.DataSource = null;
            comboBox1.DataSource = BasketOrder.baskets;
             TotalPriceOrder.Text = BasketOrder.TotalPrice().ToString();

        }
        private void BackWindows_Click(object sender, EventArgs e)
        {
            SellerWindows sellerWindows = new SellerWindows();
            sellerWindows.Show();
            this.Close();
        }
    }
}
