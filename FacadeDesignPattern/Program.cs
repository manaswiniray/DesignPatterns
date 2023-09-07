namespace FacadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerController computer = new ComputerController();
            computer.ControlPower();
        }
    }
}