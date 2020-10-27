using System;
using System.Collections.Generic;

namespace DataGenerator
{
    class Program
    {
        // NEED ROW GENERATION
            // Skip some products on each manufacturer, including the home table.
            // .ToCSV() function will take care of formatting for the file
            // add option to write files to JSON or XML, maybe both.
        // WRITE FILES

        const int NUMBER_OF_PRODUCTS = 200;

        static void Main(string[] args)
        {
            List<Product> p = Product.MakeProducts(20);

            Console.WriteLine("UPC\tMaker\tDescription");
            foreach(Product prod in p)
            {
                Console.WriteLine("{0}\t{1}\t{2}", prod.upc, prod.manufacturer, prod.description);
            }
        }
    }
}
