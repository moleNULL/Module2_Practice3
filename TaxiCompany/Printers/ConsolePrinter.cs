namespace TaxiCompany.Printers
{
    internal class ConsolePrinter : IPrinter
    {
        public void Print(string data)
        {
            Console.WriteLine(data);
        }
    }
}
