using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Menu.Menus;

namespace IteratorPattern.Menu.Iterators
{
    public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}
