using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public interface IIterator
    {
        void SetFirst(string item);
        string GetFirst();
        bool IsDone();
        int Next();
        string CurrentItem();
    }
}
