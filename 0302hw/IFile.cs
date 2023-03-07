using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302hw
{
    interface IFile
    {
        void Load(string path,LinkedList<Poem> collection);
        void Save(LinkedList<Poem> collection);

    }
}
