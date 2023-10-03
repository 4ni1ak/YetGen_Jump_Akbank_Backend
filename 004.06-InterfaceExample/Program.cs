Console.WriteLine("Interfaces!");
SamsungPrinter samsungPrinter = new();
samsungPrinter.PrintPage();
HPPrinter hpPrinter = new();
hpPrinter.PrintPage();
interface IPrinter
{
    void PrintPage();
}
class SamsungPrinter: IPrinter
{
    public void PrintPage()
    {
       Console.WriteLine("Printing in Black and White");
    }

}

class HPPrinter:IPrinter
{
    public void PrintPage()
    {
        Console.WriteLine("Printing in Color");

    }
}