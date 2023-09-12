using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class YoutubeChannel : IYoutubeChannel
    {
        private string _channelNname;
        private string _currentVideoTitle;
        private List<ISubscriber> subscriberList = new List<ISubscriber>();

        public YoutubeChannel(string channelName) 
        {
            _channelNname = channelName;
        }

        public void UploadVideo(string videoTitile)
        {
            _currentVideoTitle = videoTitile;
            NotifySubscibers(_currentVideoTitle,_channelNname);
        }

        public void NotifySubscibers(string videoTitle,string channelname)
        {
            foreach (Subscriber subscriber in subscriberList)
            {
                subscriber.Update(videoTitle,_channelNname);
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            subscriberList.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscriberList.Remove(subscriber);
        }

        
    }
}
