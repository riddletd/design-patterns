using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Collection1Iterator : Iterator
    {
        Collection1 collection;

        public Collection1Iterator(Collection1 collection)
        {
            this.collection = collection;
        }

        public int GetItem()
        {
            return collection.GetItem();
        }

        public bool HasNext()
        {
            return collection.HasNext();
        }

        public void Next()
        {
            collection.Next();
        }
    }
}
