using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public interface IHistoryManager
    {
        void AddMemento(IPlaybackMemento memento);
        IPlaybackMemento GetMemento(int index);
    }
}
