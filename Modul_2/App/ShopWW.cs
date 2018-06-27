using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2.App
{
    public class ShopWW
    {
        public ShopWW()
        {

        }
        public ShopWW(string Address, string Phone)
        {
            this.Address = Address;
            this.Phone = Phone;
        }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Catalog> Catalogs = new List<Catalog>();

        /// <summary>
        /// Метод для распечатки информации о продукции
        /// </summary>
        public void PrintCatalog()
        {
            foreach (Catalog catalog in Catalogs)
            {
                Console.WriteLine(catalog.Name);
                foreach (Product products in catalog.Products)
                {
                    products.getProductInfo();
                }
            }
        }
    }
}
