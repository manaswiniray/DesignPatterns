using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public interface IPlaybackMemento
    {
        public string SavedSong { get; }
    }
}
