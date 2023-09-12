namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IYoutubeChannel youtubeChannel1=new YoutubeChannel("Techinical Guruji");

            ISubscriber subscriber1 = new Subscriber("Ram");
            ISubscriber subscriber2 = new Subscriber("Sita");

            youtubeChannel1.Subscribe(subscriber1);
            youtubeChannel1.Subscribe(subscriber2);

            youtubeChannel1.UploadVideo("IPhone 15");


            IYoutubeChannel youtubeChannel2 = new YoutubeChannel("Tech Burner");
            
            ISubscriber subscriber3 = new Subscriber("Shyam");
            ISubscriber subscriber4 = new Subscriber("Bharat");

            youtubeChannel2.Subscribe(subscriber3);
            youtubeChannel2.Subscribe(subscriber4);

            youtubeChannel2.UploadVideo("Samsung S23 Ultra Vs IPhone 15");

            youtubeChannel2.UploadVideo("");
        }
    }
}