namespace Task2;

//Написати універсальний метод пошуку макс. і мін. елемента в масиві цілих чисел і масиві дійсних чисел.

class Program
{
    static void FindMinMax<T>(T[] array)
    {
        T min = array[0];
        T max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            dynamic value = array[i];
            if (min > value)
                min = value;
            if (max < value)
                max = value;
        }
        Console.WriteLine($"Min value is {min}, max value is {max}");
    }

    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4 };
        double[] b = { 1.1, 2.2, 3.3, 4.4 };
        FindMinMax<int>(a);
        FindMinMax<double>(b);
    }
}

