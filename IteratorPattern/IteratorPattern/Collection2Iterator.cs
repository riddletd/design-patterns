using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Collection2Iterator : Iterator
    {
        Collection2 collection;

        public Collection2Iterator(Collection2 collection)
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
