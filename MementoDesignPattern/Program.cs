namespace MementoDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMusicPlayer musicPlayer = new MusicPlayer();
            IHistoryManager historyManager = new HistoryManager();

            musicPlayer.PlaySong("Song1");
            historyManager.AddMemento(musicPlayer.CreateMemento());

            musicPlayer.PlaySong("Song2");
            historyManager.AddMemento(musicPlayer.CreateMemento());

            musicPlayer.PlaySong("Song3");
            historyManager.AddMemento(musicPlayer.CreateMemento());

            musicPlayer.RestoreMemento(historyManager.GetMemento(2));
            musicPlayer.RestoreMemento(historyManager.GetMemento(1));
            musicPlayer.RestoreMemento(historyManager.GetMemento(0));

            musicPlayer.GetAllRestoredSongs();
        }
    }
}