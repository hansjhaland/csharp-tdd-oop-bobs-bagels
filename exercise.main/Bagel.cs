using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Bagel : IProduct
    {
        private string _sku;
        private double _price;
        private string _name;
        private string _variant;

        public Bagel(string sku, double price, string name, string variant)
        {
            _sku = sku;
            _price = price;
            _name = name;
            _variant = variant;
        }

        public Bagel()
        {

        }

        public string SKU { get { return _sku; } }

        public double Price {  get { return _price; } }

        public string Name {  get { return _name; } }

        public string Variant {  get { return _variant; } }
    }
}
