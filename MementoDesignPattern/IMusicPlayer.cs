using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public interface IMusicPlayer
    {
        void PlaySong(string song);
        IPlaybackMemento CreateMemento();
        void RestoreMemento(IPlaybackMemento memento);
        void GetAllRestoredSongs();
    }
}
