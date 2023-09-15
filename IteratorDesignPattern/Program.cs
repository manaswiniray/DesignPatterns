namespace IteratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChannelCollection channelCollection = new ChannelCollection();
            channelCollection.AddChannel(new Channel(96, ChannelType.Sports));
            channelCollection.AddChannel(new Channel(93.5, ChannelType.Movies));
            channelCollection.AddChannel(new Channel(98.2, ChannelType.Serial));
            channelCollection.AddChannel(new Channel(98, ChannelType.Regional));

            IChannelIterator iterator=channelCollection.GetIterator();

            while(iterator.HasNext())
            {
                IChannel channel = iterator.Next();
                Console.WriteLine("Frequency: {0} and Channel Type: {1}",channel.Frequncy,channel.Type.ToString());
            }

        }
    }
}