using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Camera : ICamera
    {
        public void StartRecording()
        {
            Console.WriteLine("The Recording is Started");
        }

        public void StopRecording()
        {
            Console.WriteLine("The Recording is Stopped");
        }
    }
}
