namespace InterfaceSeggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.ScanContent("Scanned");
            printer.PrintContent("Printed");

            FaxMachine faxMachine = new FaxMachine();
            faxMachine.FaxContent("Fax Item Received");
            faxMachine.PrintContent("Printed");

            Camera camera = new Camera();
            camera.ScanContent("Scanned");
        }
    }
}