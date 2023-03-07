using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302hw
{
    class ModifyPoems : IChange
    {
        public void AddPoem(LinkedList<Poem> collection)
        {
            Console.WriteLine("Enter title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter author:");
            string author = Console.ReadLine();
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter body:");
            string body = Console.ReadLine();
            Console.WriteLine("Enter topic:");
            string topic = Console.ReadLine();
            collection.AddLast(new Poem(title, author, year, body, topic));

        }

        public void ChangePoem(LinkedList<Poem> collection)
        {
            Console.WriteLine("Enter title: ");
            string search = Console.ReadLine();
            bool ifFound = false;
            foreach (Poem poem in collection)
            {
                if (poem.title == search)
                {
                    ifFound = true;
                    poem.Rewrite();
                    Console.WriteLine("Success");
                    break;
                }
            }
            if (!ifFound)
            {
                Console.WriteLine("Invalid title");
            }
        }

        public void DeletePoem(LinkedList<Poem> collection)
        {
            Console.WriteLine("Enter title: ");
            string search = Console.ReadLine();
            bool ifFound = false;
            foreach (Poem poem in collection)
            {
                if (poem.title == search)
                {
                    ifFound = true;
                    collection.Remove(poem);
                    Console.WriteLine("Success");
                    break;
                }
            }
            if (!ifFound)
            {
                Console.WriteLine("Invalid title");
            }
        }
    }
}
