using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Subscriber : ISubscriber
    {
        private string _subscriberName;

        public Subscriber(string subscriberName)
        {
            _subscriberName = subscriberName;
        }

        public void Update(string videoTitle, string channelName)
        {
            if (!string.IsNullOrEmpty(videoTitle))
            {
                Console.WriteLine("Hello {0}!!! {1} titled new video is available now on the {2} channel .", _subscriberName, videoTitle,channelName);
            }
            else
            {
                Console.WriteLine("Apologies {0}!!! New video is not uploaded yet on the {1} channel .", _subscriberName, channelName);
            }
        }
    }
}
