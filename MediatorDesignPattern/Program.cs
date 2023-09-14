namespace MediatorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMediator smartAssistantMediator = new SmartAssistantMediator();

            IDevice lightBulb = new Lights();

            IDevice homeTheatre = new MusicSystem();
            IDevice securityCamera = new SecurityCamera();

            smartAssistantMediator.AddDevice(lightBulb);
            smartAssistantMediator.AddDevice(homeTheatre);
            smartAssistantMediator.AddDevice(securityCamera);

            smartAssistantMediator.TurnOffAllDevices();

            lightBulb.TurnOnDevice();
            lightBulb.AdjustDevice(45);
            lightBulb.TurnOffDevice();
        }
    }
}