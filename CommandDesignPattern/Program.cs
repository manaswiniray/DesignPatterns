namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICamera camera = new Camera();
            ICommand cameraRecordingCommand = new CameraRecordingCommand(camera);

            var cameraButton = new Button();
            cameraButton.SetCommand(cameraRecordingCommand);
            cameraButton.PressForExecution();

            var menu = new Menu();
            menu.SetCommand(cameraRecordingCommand);
            menu.Click();
        }
    }
}