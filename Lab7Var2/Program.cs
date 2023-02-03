namespace Lab7Var2;

//Модифікувати приклад 1 для обміну даними типів double, string

class Program
{
    static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

    static void Main(string[] args)
    {
        double a = 1;
        double b = 2;
        Swap<double>(ref a, ref b);
        Console.WriteLine("a = " + a + " b = " + b);

        string c = "one";
        string d = "two";
        Swap<string>(ref c, ref d);
        Console.WriteLine($"c = {c}, d = {d}");
    }
}

