using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302hw
{
    interface IChange
    {
        void AddPoem(LinkedList<Poem> collection);
        void DeletePoem(LinkedList<Poem> collection);
        void ChangePoem(LinkedList<Poem> collection);
    }
}
