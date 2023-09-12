using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface IYoutubeChannel
    {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void NotifySubscibers(string videoTitile, string channelName);
        void UploadVideo(string videoTitile);
    }
}
