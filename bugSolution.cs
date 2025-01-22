public class ExampleClass
{
    private int _myProperty; // Explicit backing field

    public int MyProperty
    {
        get { return _myProperty; }
        set { _myProperty = value; }
    }

    public void MyMethod()
    {
        // Initialize the property before use.
        MyProperty = 0; // Or some other appropriate default
        Console.WriteLine(MyProperty); // Now it reliably prints 0
        MyProperty = 10;
    }
} 