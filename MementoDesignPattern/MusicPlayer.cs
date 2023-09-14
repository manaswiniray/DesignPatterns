using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class MusicPlayer : IMusicPlayer
    {
        private string _currentSong;
        private IList<string> _restoredSongs=new List<string>();

        public IPlaybackMemento CreateMemento()
        {
            return new PlaybackMemento(_currentSong);
        }

        public void PlaySong(string song)
        {
            _currentSong = song;
            Console.WriteLine("{0} is being played.",_currentSong);
        }

        public void RestoreMemento(IPlaybackMemento memento)
        {
            _currentSong = memento.SavedSong;
            _restoredSongs.Add(_currentSong);
            Console.WriteLine("Restored Song: {0}",_currentSong);
        }

        public void GetAllRestoredSongs()
        {
            Console.WriteLine("All Restored Songs Are: ");
            foreach(string song in _restoredSongs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
