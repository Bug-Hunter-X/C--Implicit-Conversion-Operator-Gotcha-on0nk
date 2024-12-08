public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass myClass)
    {
        return myClass.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int num1 = obj1;   // Implicit conversion from MyClass to int

        MyClass obj2 = new MyClass(20);
        int num2 = obj2 + 5; // Implicit conversion from MyClass to int, then addition

        Console.WriteLine(num1); // Output: 10
        Console.WriteLine(num2); // Output: 25
    }
}