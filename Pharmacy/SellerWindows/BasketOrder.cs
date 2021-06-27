using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.SellerWindows
{
    class BasketOrder
    {
        public string NameMedication { get; set; }
        public string Barcode { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public static List<BasketOrder> baskets = new List<BasketOrder>();

        public static void AddBasketOrder(string nameMedication, string barcode, double price, int quantity)
        {
            CatalogMedication catalog = new CatalogMedication();
            baskets.Add(new BasketOrder()
            {
                NameMedication = nameMedication,
                Barcode = barcode,
                Price = price,
                Quantity = quantity
            });
        }
        public static double TotalPrice()
        {
            double price = 0;
            for (int i = 0; i < BasketOrder.baskets.Count; i++)
            {
                price += BasketOrder.baskets[i].Price;
            }
            return price;
        }
        public override string ToString()
            =>
              $"{NameMedication}" +
            $" - {Math.Round(Price, 3)} бел.руб.";
    }
}
