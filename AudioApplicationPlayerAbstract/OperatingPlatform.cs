using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    internal class OperatingPlatform
    {
        public static void OperationsForPlatform()
        {
            IAudioPlayerFactory audioPlayerFactory = ChoosePlatformForAudioPlayer.ChoosePlatform();
            IAudioPlayer audioPlayer = audioPlayerFactory.CreateAudioPlayer();

            while (true)
            {
                Console.WriteLine("Menu 2:");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Select Notification Platform: ");
                Console.WriteLine("4. Return to Menu 1");
                Console.WriteLine("Select Option:");

                int choice2 = int.Parse(Console.ReadLine());

                switch (choice2)
                {
                    case 1:
                        audioPlayer.Play();
                        break;
                    case 2:
                        audioPlayer.Stop();
                        break;
                    case 3:
                        audioPlayer.Notify();

                        break;
                    case 4:
                        Console.WriteLine("Returning to Menu1: ");
                        Thread.Sleep(500);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
