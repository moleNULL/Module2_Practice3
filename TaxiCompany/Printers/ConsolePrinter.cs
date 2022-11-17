namespace TaxiCompany.Printers
{
    // Print data on Console
    internal class ConsolePrinter : IPrinter
    {
        public void Print(string data)
        {
            Console.WriteLine(data);
        }
    }
}
