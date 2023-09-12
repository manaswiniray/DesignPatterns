using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class CameraRecordingCommand : ICommand
    {
        private readonly ICamera _camera;

        public CameraRecordingCommand(ICamera camera)
        {
            _camera = camera;
        }

        public void StartExecution()
        {
            _camera.StartRecording();
        }

        public void StopExecution()
        {
            _camera.StopRecording();
        }
    }
}
