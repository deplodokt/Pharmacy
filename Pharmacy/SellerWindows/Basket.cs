using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
            var builder = new StringBuilder();
            string check = RandomReceipt.RandomKod.RandomString();

            var document = new PdfDocument();
            document.Info.Title = "Создание";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Console", 10, XFontStyle.Regular);
           

            int postionValues = 40;
            int postionValuesBarcode = 50;
            int postionValuesPrice = 60;

            gfx.DrawString($"{"".PadRight(25, ' ')}ОАО \"Дуптик\" ", font, XBrushes.Black,
                new XPoint(100, 20));

            foreach (var product in BasketOrder.baskets)
            {

                counter++;
                gfx.DrawString($"{counter}.{product.NameMedication}", font, XBrushes.Black,
                new XPoint(100,postionValues));
                gfx.DrawString($"Код: {product.Barcode}", font, XBrushes.Black,
                new XPoint(100, postionValuesBarcode));
                gfx.DrawString($"  Стоимость{"".PadRight(40 - product.Price.ToString().Length, '.')}{product.Price}", font, XBrushes.Black,
                 new XPoint(100, postionValuesPrice));
                postionValues += 30;
                postionValuesBarcode += 30;
                postionValuesPrice += 30;
            }
            gfx.DrawString("".PadRight(29, '='), font, XBrushes.Black,
                  new XPoint(100, postionValuesPrice));
            gfx.DrawString($"{DateTime.Now.ToString("G")} {"".PadRight(30 - DateTime.Now.ToString("G").Length, '.')} №{check}", font, XBrushes.Black,
                  new XPoint(100, postionValuesPrice+20));
            gfx.DrawString($"Итого{"".PadRight(50 - BasketOrder.TotalPrice().ToString().Length, '.')}{Math.Round((BasketOrder.TotalPrice()), 3).ToString()}", font, XBrushes.Black,
                  new XPoint(100, postionValuesPrice+30));
            MessageBox.Show("Чек покупателя");
            string filename = @"D:\КПиЯП\Pharmacy\Pharmacy\SellerWindows\BuyersReceipt\" + check + ".pdf";
            document.Save(filename);
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
