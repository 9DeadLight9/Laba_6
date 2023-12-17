using Laba_6;
class Program
{
    static void Main()
    {
        Calculator<int> intCalc = new Calculator<int>();
        Console.WriteLine(intCalc.Add(5, 10));
        Console.WriteLine(intCalc.Subtract(20, 5));
        Console.WriteLine(intCalc.Multiply(3, 7));
        Console.WriteLine(intCalc.Divide(15, 3));

        Calculator<double> doubleCalc = new Calculator<double>();
        Console.WriteLine(doubleCalc.Add(5.5, 10.2));
        Console.WriteLine(doubleCalc.Subtract(20.8, 5.3));
        Console.WriteLine(doubleCalc.Multiply(3.2, 7.7));
        Console.WriteLine(doubleCalc.Divide(15.6, 3.1));
    }
}

