using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302hw
{
    interface ISearch
    {
        void SearchByTitle(LinkedList<Poem> collection);
        void SearchByAuthor(LinkedList<Poem> collection);
    }
}
