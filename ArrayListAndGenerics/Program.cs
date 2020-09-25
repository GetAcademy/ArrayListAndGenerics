using System;

namespace ArrayListAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyForEachList();
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }

        static void Main2(string[] args)
        {
            /*
             * Begrensninger i arrayer - løse med objektorientering
             * indexer
             * Generics
             * IEnumerable - foreach
             * LinkedList
             */
            var list2 = new MyArrayList<int>();
            var list = new MyArrayList<Person>();
            var person = new Person
            {
                FirstName = "Terje", 
                LastName = "Kolderup"
            };
            list.Add(person);
            for (int i = 0; i < list.Length; i++)
            {
                var p = list.GetValue(i);

                Console.WriteLine(p.FirstName);
            }

        }
    }
}
