using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2.App
{
    public enum TypeSecurity { Type1, Type2, Type3 }


    public class Product
    {
        public Product():this(0) { }
        public Product(double Price) : this(Price,"") { }
        public Product(double Price,string name) : this(Price,name, "") { }
        public Product(double Price, string name,string Color)  { }
        private double Price_;
        public double Price
        {
            get { return Price_; }
            set
            {
                if (value < 0)
                {
                    Price_ = 0;
                }
                else
                {
                    Price_ = value;
                    PriceInShop = PriceInShop - (PriceInShop * 0.3);
                }
            }
        }
        public double PriceInShop { get; set; }

        public string name { get; set; }
        public string ManuFacture { get; set; }
        public string Color { get; set; }

        public TypeSecurity TypeSecurity { get; set; }
        /// <summary>
        /// Метод для распечатки информации о продукте
        /// </summary>
        public void getProductInfo()
        {
            Console.WriteLine("{0}\t{1} тенге", name, Price);
        }
    }
}
