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
        public Basket(int capacity)
        {
            _capacity = capacity;
        }

        public Basket()
        {
            
        }

        public bool Add(IProduct product)
        {
            if (product is Filling)
            {
                return false;
            }
            if (IsFull)
            {
                return false;
            }
            _items.Add(product);
            return true;
        }

        public bool Remove(IProduct product)
        {
            return _items.Remove(product);
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
