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
        private List<Filling> _fillings = new List<Filling>();

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

        public bool AddFilling(Filling filling) 
        { 
            _fillings.Add(filling);
            return true;
        }


        public string SKU { get { return _sku; } }

        public double Price {  get { return _price; } }

        public string Name {  get { return _name; } }

        public string Variant {  get { return _variant; } }
        public List<Filling> Fillings { get { return _fillings; } }
    }
}
