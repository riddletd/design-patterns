using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Collection2 : Iterable
    {
        int [] integers = new int[10];
        int addIndex = 0;
        int getIndex = 0;

        public int GetItem()
        {
            int value = integers[getIndex];
            Next();
            return value;
        }

        public void Next()
        {
            getIndex++;
        }

        public bool HasNext()
        {
            return getIndex < 10;
        }

        public void Add(int i)
        {
            integers[addIndex] = i;
            addIndex++;
        }

        public Iterator GetIterator()
        {
            return new Collection2Iterator(this);
        }
    }
}
