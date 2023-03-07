using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302hw
{
    interface IReport
    {
        void TitleReport(LinkedList<Poem> collection);
        void AuthorReport(LinkedList<Poem> collection);
        void TopicReport(LinkedList<Poem> collection);
        void YearReport(LinkedList<Poem> collection);
        void LengthReport(LinkedList<Poem> collection);
    }
}
