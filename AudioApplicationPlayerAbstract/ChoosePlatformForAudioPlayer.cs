using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    public class ChoosePlatformForAudioPlayer
    {
        public static IAudioPlayerFactory ChoosePlatform()
        {
            while (true)
            {
                Console.WriteLine("Menu 1:");
                Console.WriteLine();
                Console.WriteLine("1. Window:");
                Console.WriteLine("2. Linux");
                Console.WriteLine("3. Exit App");
                Console.WriteLine("Select Option:");
                Console.WriteLine();

                int choice1 = int.Parse(Console.ReadLine());

                if (choice1 == 3) { break; }

                IAudioPlayerFactory audioPlayerFactory = choice1 switch
                {
                    1 => new WindowsAudioPlayerFactory(),
                    2 => new LinuxAudioPlayerFactory(),
                    _ => default,
                };

                return audioPlayerFactory;
            }

           
        }
    }
}
