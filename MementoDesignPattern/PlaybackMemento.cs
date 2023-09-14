using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class PlaybackMemento : IPlaybackMemento
    {
        public string SavedSong { get; }

        public PlaybackMemento(string song)
        {
            SavedSong = song;
        }

    }
}
