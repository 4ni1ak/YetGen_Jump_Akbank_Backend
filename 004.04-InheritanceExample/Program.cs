BaseClass baseClass = new();
baseClass.Text = "Test";
baseClass.Print();
DerivedClass derivedClass = new();
derivedClass.Text = "Test 2";
derivedClass.Print();
class BaseClass //Parent Kalıtım Veren 1
{

    public string Text { get; set; }

    public void Print()
    {
        Console.WriteLine("Print Method");
    }
}
class DerivedClass: BaseClass //Child 1 Kalıtım Alan
{
    public int Number { get; set; }
}