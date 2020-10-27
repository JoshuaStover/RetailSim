using System;
using System.Collections.Generic;
using System.Text;

namespace DataGenerator
{
    class Product
    {
        const int PRODUCTS_PER_MANUFACTURER = 10;

        public string upc, manufacturer, name, description;
        public decimal cost;

        public Product(string m, string n, string d, decimal c)
        {
            upc = MakeUPC_A();
            manufacturer = m;
            name = n;
            description = d;
            cost = c;
        }

        /// <summary>
        /// Generate a random UPC-A code with correct check digit.
        /// Returns as string to prevent formatting headache when code starts with any amount of 0's.
        /// </summary>
        /// <returns></returns>
        static string MakeUPC_A()
        {
            Random rand = new Random();
            string output = "";
            int temp, evenSum = 0, oddSum = 0;

            for (byte i = 1; i < 12; i++)
            {
                temp = rand.Next(10);
                output += temp.ToString();

                if (i % 2 == 0) { evenSum += temp; }
                else { oddSum += temp; }
            }

            temp = 10 - (((3 * oddSum) + evenSum) % 10);

            output += (temp == 10 ? "0" : temp.ToString());

            return output;
        }

        /// <summary>
        /// Creates a base list of products.
        /// List is populated with numberOfProducts products with
        /// PRODUCTS_PER_MANUFACTURER products for each manufacturer.
        /// </summary>
        /// <param name="numberOfProducts">
        /// Total number of products to be generated.
        /// </param>
        /// <returns>
        /// Returns a populated list of products.
        /// </returns>
        public static List<Product> MakeProducts(uint numberOfProducts)
        {
            List<Product> products = new List<Product>();
            Random rand = new Random();

            for (uint i = 0; i < numberOfProducts; i++)
            {
                products.Add(new Product(
                    "Manufacturer " + (Math.Floor((double)(i / PRODUCTS_PER_MANUFACTURER)) + 1).ToString(),
                    "Product " + (i + 1).ToString(), Description.Get(),
                    (decimal)(rand.Next(10, 500) / rand.Next(2, 20))));
            }

            return products;
        }
    }
}
