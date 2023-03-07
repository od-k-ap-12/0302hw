using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302hw
{
    class SearchPoems : ISearch
    {
        public void SearchByAuthor(LinkedList<Poem> collection)
        {
            Console.WriteLine("Enter author: ");
            string search = Console.ReadLine();
            bool ifFound = false;
            foreach (Poem poem in collection)
            {
                if (poem.author == search)
                {
                    ifFound = true;
                    poem.Print();
                    Console.WriteLine("Success");
                }
            }
            if (!ifFound)
            {
                Console.WriteLine("Invalid author");
            }
        }

        public void SearchByTitle(LinkedList<Poem> collection)
        {
            Console.WriteLine("Enter title: ");
            string search = Console.ReadLine();
            bool ifFound = false;
            foreach (Poem poem in collection)
            {
                if (poem.title == search)
                {
                    ifFound = true;
                    poem.Print();
                    Console.WriteLine("Success");
                }
            }
            if (!ifFound)
            {
                Console.WriteLine("Invalid title");
            }
        }
    }
}
