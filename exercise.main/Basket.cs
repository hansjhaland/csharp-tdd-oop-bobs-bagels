using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private List<IProduct> _items = new List<IProduct>();
        private int _capacity;
        private Inventory _inventory;
        public Basket(int capacity)
        {
            _capacity = capacity;
        }

        public Basket()
        {
            
        }

        public Basket(int capacity, Inventory inventory)
        {
            _capacity = capacity;
            _inventory = inventory;
        }

        public bool Add(IProduct product)
        {
            if (_inventory != null && !_inventory.InStock(product))
            {
                return false;
            }
            if (product is Filling)
            {
                return false;
            }
            if (IsFull)
            {
                return false;
            }
            if (product is Bagel)
            {
                foreach (Filling filling in (product as Bagel).Fillings) 
                {
                    _items.Add(filling);
                }
            }
            _items.Add(product);
            return true;
        }

        public bool Remove(IProduct product)
        {
            bool removed = _items.Remove(product);
            if (!removed) 
            {
                return false;
            }
            if (product is Bagel)
            {
                (product as Bagel).Fillings.ForEach(filling => _items.Remove(filling));
            }
            return true;
        }

        public bool ChangeCapacity(int newCapacity)
        {
            if (newCapacity < _items.Count) 
            {
                return false;
            }
            _capacity = newCapacity;
            return true;

        }

        public Dictionary<string, double> GetSpecialOffers()
        {
            throw new NotImplementedException();
            //Dictionary<string, int> productsCount = new Dictionary<string, int>();
            //foreach (IProduct product in _items)
            //{
            //    productsCount[product.SKU]++;
            //}

            //foreach (KeyValuePair<string, int> pair in productsCount)
            //{
            //    if (pair.Value >= 0)
            //    {

            //        int numTwelveBagelDiscounts = pair.Value / 12;
            //        int remainder = pair.Value % 12;
            //    }
            //}
        }

        public double CalculateTotalDiscountCost()
        {
            throw new NotImplementedException();
            //List<Tuple<string, double>>? specialOffer = GetSpecialOffers();
            //if (specialOffer != null)
            //{
            //    double discountTotal = 0;
            //    List<string> discountSKUs = new List<string>();
            //    foreach (Tuple<string, double> tuple in specialOffer)
            //    {
            //        discountSKUs.Add(tuple.Item1);
            //        discountTotal += tuple.Item2;
            //    }


            //    return discountTotal + remainderTotal;
            //}

            //return _items.Sum(product => product.Price);
        }

        public double CalculateTotalCost()
        {
            return _items.Sum(product => product.Price);
        }

        public List<IProduct> Items { get {return _items;} }
        public bool IsFull { get { return _items.Count >= _capacity; } }
        public int Capacity {  get { return _capacity; } }
    }
}
