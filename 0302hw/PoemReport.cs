using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0302hw
{
    class PoemReport : IReport
    {
        public void AuthorReport(LinkedList<Poem> collection)
        {
            try
            {
                StreamWriter writer = new StreamWriter("AuthorReport.txt", true);
                foreach (Poem poem in collection)
                {
                    writer.WriteLine(poem.author);
                    Console.WriteLine(poem.author);
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void LengthReport(LinkedList<Poem> collection)
        {
            try
            {
                StreamWriter writer = new StreamWriter("AuthorReport.txt", true);
                foreach (Poem poem in collection)
                {
                    string[] TextArray = poem.body.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    writer.WriteLine(TextArray.Length);
                    Console.WriteLine(TextArray.Length);
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TitleReport(LinkedList<Poem> collection)
        {
            try
            {
                StreamWriter writer = new StreamWriter("TitleReport.txt", true);
                foreach (Poem poem in collection)
                {
                    writer.WriteLine(poem.title);
                    Console.WriteLine(poem.title);
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TopicReport(LinkedList<Poem> collection)
        {
            try
            {
                StreamWriter writer = new StreamWriter("TopicReport.txt", true);
                foreach (Poem poem in collection)
                {
                    writer.WriteLine(poem.topic);
                    Console.WriteLine(poem.topic);
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void YearReport(LinkedList<Poem> collection)
        {
            try
            {
                StreamWriter writer = new StreamWriter("YearReport.txt", true);
                foreach (Poem poem in collection)
                {
                    writer.WriteLine(poem.year);
                    Console.WriteLine(poem.year);
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
