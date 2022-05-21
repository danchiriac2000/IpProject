using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items.DataBaseObjects
{
    public class ValidProducts
    {

        private Dictionary<String, List<String>> _products = new Dictionary<String, List<String>>();
        private static ValidProducts _instance;
     
        private ValidProducts()
        {

            String[] lines = System.IO.File.ReadAllLines(@"ValidProducts.txt");
            foreach(String line in lines)
            {
                String[] elements = line.Split(':');
                String category = elements[0];

                String[] products = elements[1].Split(',');

                _products.Add(category, products.ToList());

            }

        }
        
        public static ValidProducts GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ValidProducts();
            }

            return _instance;
        }
        public Dictionary<String, List<String>> Products
        {
            get
            {
                return _products;
            }
        }




    }
}
