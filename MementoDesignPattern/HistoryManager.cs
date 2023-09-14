using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class HistoryManager : IHistoryManager
    {
        private IList<IPlaybackMemento> _historyList = new List<IPlaybackMemento>();
        public void AddMemento(IPlaybackMemento memento)
        {
            _historyList.Add(memento);
        }

        public IPlaybackMemento GetMemento(int index)
        {
            if(index>=0 && index < _historyList.Count)
            {
                return _historyList[index];
            }
            return null;
        }
    }
}
