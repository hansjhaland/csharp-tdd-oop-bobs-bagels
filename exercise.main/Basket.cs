using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private List<IProduct> _items;
        public void Add(IProduct bagel)
        {
            throw new NotImplementedException();
        }
        public List<IProduct> Items { get {return _items;} }
    }
}
