using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataGenerator
{
    class ProductRow
    {
        private uint productID;
        private int inStock, reorderLevel, capacity;
        private string name, upc, manufacturer, description;
        private decimal cost, price1, price2, price3, price4, price5;

        IFormatProvider enUS = CultureInfo.CreateSpecificCulture("en-US");

        /// <summary>
        /// Generates a product row containing the remaining info for products.
        /// REVISIT THIS, COLLAPSE INTO PRODUCT CLASS.
        /// </summary>
        /// <param name="ID">
        /// Product ID.
        /// </param>
        /// <param name="p">
        /// Product object used for the row.
        /// </param>
        public ProductRow(uint ID, Product p)
        {
            Random rand = new Random();
            productID = ID;
            name = p.name;
            upc = p.upc;
            manufacturer = p.manufacturer;
            description = p.description;
            cost = p.cost;
            inStock = rand.Next(10, 200);
            reorderLevel = inStock / rand.Next(2, 5);
            capacity = (int)(inStock * (rand.NextDouble() * 2));
            price1 = cost * (decimal)((rand.Next(10, 20) / 100) + 1);
            price2 = price1 * (decimal)((rand.Next(10, 20) / 100) + 1);
            price3 = price2 * (decimal)((rand.Next(10, 20) / 100) + 1);
            price4 = price3 * (decimal)((rand.Next(10, 20) / 100) + 1);
            price5 = price4 * (decimal)((rand.Next(10, 20) / 100) + 1);
        }

        /// <summary>
        /// Sends product info to a CSV compatible string for the home DB.
        /// </summary>
        /// <returns>
        /// CSV compatible version of product row.
        /// </returns>
        public string ToHomeCSV()
        {
            return productID.ToString() + "," + name + "," + upc + "," + manufacturer +
                "," + description + ","  + inStock.ToString() + "," +
                reorderLevel.ToString() + "," + capacity.ToString() + "," +
                cost.ToString("C", enUS) + "," + price1.ToString("C", enUS) + "," +
                price2.ToString("C", enUS) + "," + price3.ToString("C", enUS) + "," +
                price4.ToString("C", enUS) + "," + price5.ToString("C", enUS);
        }

        /// <summary>
        /// Sends product info to a CSV compatible string for competitor DBs.
        /// </summary>
        /// <returns>
        /// CSV compatible version of product row.
        /// </returns>
        public string ToCompetitorCSV()
        {
            return productID.ToString() + "," + name + "," + upc + "," +
                manufacturer + "," + description + "," + price1.ToString("C", enUS) +
                "," + price2.ToString("C", enUS) + "," + price3.ToString("C", enUS) +
                "," + price4.ToString("C", enUS) + "," + price5.ToString("C", enUS);
        }
    }
}
