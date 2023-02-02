using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CollectionLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new ObservableCollection<string>
            {
                "Tom", "Bob", "Sam"
            };

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
    }
}
