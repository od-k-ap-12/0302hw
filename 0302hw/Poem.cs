using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302hw
{
    class Poem
    {
        public string title { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public string body { get; set; }
        public string topic { get; set; }
        public Poem()
        {
            title = "";
            author = "";
            year = 0;
            body = "";
            topic = "";
        }
        public Poem(string _title,string _author, int _year, string _body, string _topic)
        {
            title = _title;
            author = _author;
            year = _year;
            body = _body;
            topic = _topic;
        }
        public void Rewrite()
        {
            Console.WriteLine("Enter title:");
            title = Console.ReadLine();
            Console.WriteLine("Enter author:");
            author = Console.ReadLine();
            Console.WriteLine("Enter year:");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter body:");
            body = Console.ReadLine();
            Console.WriteLine("Enter topic:");
            topic = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine("Title: " + title + "\nAuthor: " + author + "\n3.Year: " + year + "\nBody: " + body + "\nTopic: " + topic);
        }
        public override string ToString()
        {
            return "Title: " + title + "\nAuthor: " + author + "\n3.Year: " + year + "\nBody: " + body + "\nTopic: " + topic;
        }
    }
}
