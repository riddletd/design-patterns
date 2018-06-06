using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Collection1 : Iterable
    {
        List<int> integers = new List<int>();
        int currentIndex = 0;

        public int GetItem()
        {
            int value = integers[currentIndex];
            Next();
            return value;
        }

        public void Next()
        {
            currentIndex++;
        }

        public bool HasNext()
        {
            integers.TrimExcess();
            return currentIndex != integers.Capacity;
        }

        public void Add(int i)
        {
            integers.Add(i);
        }

        public Iterator GetIterator()
        {
            return new Collection1Iterator(this);
        }
    }
}
