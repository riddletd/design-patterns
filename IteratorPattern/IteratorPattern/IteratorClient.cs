using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class IteratorClient
    {
        static void Main(string[] args)
        {
            test(new Collection1());
            test(new Collection2());
        }

        private static void test(Iterable collection)
        {
            collection.Add(3);
            collection.Add(4);
            collection.Add(5);
            collection.Add(6);

            Iterator iterator = collection.GetIterator();

            Console.WriteLine("Elements in a Collection: ");

            while (iterator.HasNext())
                Console.WriteLine("\t" + iterator.GetItem() + " ");
        }
    }
}
