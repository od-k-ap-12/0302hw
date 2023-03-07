using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0302hw
{
    class PoemFiles : IFile
    {
        public void Load(string path, LinkedList<Poem> collection)
        {
            try
            {
                StreamReader reader = new StreamReader(path, Encoding.UTF8);
                while (!reader.EndOfStream)
                {
                    Poem poem = new Poem();
                    poem.title=Console.ReadLine();
                    poem.author=Console.ReadLine();
                    poem.year=Convert.ToInt32(Console.ReadLine());
                    poem.body=Console.ReadLine();
                    poem.topic=Console.ReadLine();
                    collection.AddLast(poem);
                }
                reader.Close(); 

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Save(LinkedList<Poem> collection)
        {
            try
            {
                StreamWriter writer = new StreamWriter("Poems.txt", true);
                foreach(Poem poem in collection)
                {
                    writer.WriteLine(poem.title);
                    writer.WriteLine(poem.author);
                    writer.WriteLine(poem.year);
                    writer.WriteLine(poem.body);
                    writer.WriteLine(poem.topic);
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
