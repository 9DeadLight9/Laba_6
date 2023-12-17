namespace Laba_6;

public class Calculator<T>
{
    public delegate T Operation(T a, T b);

    public T Add(T a, T b)
    {
        dynamic x = a, y = b;
        return x + y;
    }

    public T Subtract(T a, T b)
    {
        dynamic x = a, y = b;
        return x - y;
    }

    public T Multiply(T a, T b)
    {
        dynamic x = a, y = b;
        return x * y;
    }

    public T Divide(T a, T b)
    {
        dynamic x = a, y = b;
        if (y == 0)
        {
            throw new DivideByZeroException();
        }
        return x / y;
    }
}
