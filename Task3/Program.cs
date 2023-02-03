namespace Task3;

//Розробити універсальний клас з 1 параметром. Реалізувати в ньому конструктор і 1 метод для знаходження меншого з двох чисел.

public class Universal<T>
{
    public T FirstNum { get; set; }
    public T SecondNum { get; set; }

    public Universal(T firstNum, T secondNum)
    {
        FirstNum = firstNum;
        SecondNum = secondNum;
    }
    public T FindSmaller()
    {
        dynamic firstMun = FirstNum;
        dynamic secondNum = SecondNum;

        return firstMun < secondNum ? firstMun : secondNum;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Universal<int> uni = new Universal<int>(3, 4);
        
        Console.WriteLine(uni.FindSmaller());
    }
}

