using System;
using System.Collections.Generic;
using System.Text;

namespace DataGenerator
{
    class ProductRow
    {
        public uint productID;
        public int inStock, reorderLevel, capacity;
        public string name, upc, manufacturer, description;
        public decimal cost, price1, price2, price3, price4, price5;

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

        public string ToHomeCSV()
        {
            return productID.ToString() + "," + name + "," + upc + "," +
                manufacturer + "," + description + "," + cost.ToString() + "," +
                inStock.ToString() + "," + reorderLevel.ToString() + "," +
                capacity.ToString() + "," + price1.ToString() + "," + 
                price2.ToString() + "," + price3.ToString() + "," + 
                price4.ToString() + "," + price5.ToString();
        }

        public string ToCompetitorCSV()
        {
            return productID.ToString() + "," + name + "," + upc + "," +
                manufacturer + "," + description + "," + price1.ToString() + "," +
                price2.ToString() + "," + price3.ToString() + "," +
                price4.ToString() + "," + price5.ToString();
        }
    }
}
