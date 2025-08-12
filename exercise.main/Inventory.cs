using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Inventory
    {
        private List<IProduct> _stock = new List<IProduct>();

        public Inventory()
        {
            _stock.Add(new Bagel("BGLO", 0.49, "Bagel", "Onion"));
            _stock.Add(new Bagel("BGLP", 0.39, "Bagel", "Plain"));
            _stock.Add(new Bagel("BGLE", 0.49, "Bagel", "Everything"));
            _stock.Add(new Bagel("BGLS", 0.49, "Bagel", "Sesame"));
            _stock.Add(new Coffee("COFB", 0.99, "Coffee", "Black"));
            _stock.Add(new Coffee("COFW", 1.19, "Coffee", "White"));
            _stock.Add(new Coffee("COFC", 1.29, "Coffee", "Capuccino"));
            _stock.Add(new Coffee("COFL", 1.29, "Coffee", "Latte"));
            _stock.Add(new Filling("FILB", 0.12, "Filling", "Bacon"));
            _stock.Add(new Filling("FILE", 0.12, "Filling", "Egg"));
            _stock.Add(new Filling("FILC", 0.12, "Filling", "Cheese"));
            _stock.Add(new Filling("FILX", 0.12, "Filling", "Cream Cheese"));
            _stock.Add(new Filling("FILS", 0.12, "Filling", "Smoked Salmon"));
            _stock.Add(new Filling("FILH", 0.12, "Filling", "Ham"));
        }
        public Dictionary<string, double> AllFillingsPrice()
        {
            Dictionary<string, double> fillingsPrice = new Dictionary<string, double>();
            foreach (IProduct product in _stock)
            {
                if (product is Filling)
                {
                    fillingsPrice[product.Variant] = product.Price;
                }
            }
            return fillingsPrice;
        }

        public bool InStock(IProduct product)
        {
            foreach(IProduct item in _stock)
            {
                if (product.SKU == item.SKU && product.Price == item.Price && product.Name == item.Name && product.Variant == item.Variant)
                {
                    return true;
                }
            }
            return false;
        }

        public List<IProduct> Stock { get{ return _stock; } }
    }
}
