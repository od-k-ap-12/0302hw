using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302hw
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Poem> Poems = new LinkedList<Poem>();
            ModifyPoems mp = new ModifyPoems();
            SearchPoems sp = new SearchPoems();
            PoemFiles pf = new PoemFiles();
            PoemReport pr = new PoemReport();
            int choice;
            do
            {
                Console.WriteLine("1.Add a poem \n2.Delete a poem \n3.Change a poem \n4.Search a poem by its title \n5.Search a poem by its author \n6.Save poems to file \n7.Load poems from file \n8.Get a report \n9.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        mp.AddPoem(Poems);
                        break;
                    case 2:
                        mp.DeletePoem(Poems);
                        break;
                    case 3:
                        mp.ChangePoem(Poems);
                        break;
                    case 4:
                        sp.SearchByTitle(Poems);
                        break;
                    case 5:
                        sp.SearchByAuthor(Poems);
                        break;
                    case 6:
                        pf.Save(Poems);
                        break;
                    case 7:
                        Console.WriteLine("Enter path:");
                        pf.Load(Console.ReadLine(),Poems);
                        break;
                    case 8:
                        Console.WriteLine("1.Report by title \n2.Report by author \n3.Report by topic \n4.Report by year \n5.Report by length");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                pr.TitleReport(Poems);
                                break;
                            case 2:
                                pr.AuthorReport(Poems);
                                break;
                            case 3:
                                pr.TopicReport(Poems);
                                break;
                            case 4:
                                pr.YearReport(Poems);
                                break;
                            case 5:
                                pr.LengthReport(Poems);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        break;

                }
            }
            while (choice != 9);
        }
    }
}
