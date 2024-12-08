public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    //Consider removing implicit operators for improved clarity
    //public static implicit operator int(MyClass myClass)
    //{
    //    return myClass.MyProperty;
    //}

    //public static implicit operator MyClass(int value)
    //{
    //    return new MyClass(value);
    //}
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10); // Explicit instantiation is clearer
        int num1 = obj1.MyProperty;    // Explicit access to property

        MyClass obj2 = new MyClass(20);
        int num2 = obj2.MyProperty + 5; // Explicit conversion with property access

        Console.WriteLine(num1); // Output: 10
        Console.WriteLine(num2); // Output: 25
    }
}