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

        public double CalculateTotalCost()
        {
            return _items.Sum(product => product.Price);
        }

        public List<IProduct> Items { get {return _items;} }
        public bool IsFull { get { return _items.Count >= _capacity; } }
        public int Capacity {  get { return _capacity; } }
    }
}
