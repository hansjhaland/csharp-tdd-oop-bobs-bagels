using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercise.main
{   
    public class Coffee : IProduct
    {
        private string _sku;
        private double _price;
        private string _name;
        private string _variant;
        public string SKU { get { return _sku; } }

        public double Price { get { return _price; } }

        public string Name { get { return _name; } }

        public string Variant { get { return _variant; } }
    }
}
