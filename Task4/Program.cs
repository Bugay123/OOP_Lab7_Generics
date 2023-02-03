namespace Task4;

//Реалізувати клас Персона та універсальний клас GenericList <T> для роботи із списком людей(як у прикладі 7).

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class GenericList<T>
{
    private T[] items;
    public int Length { get; private set; }
    public GenericList()
    {
        items = new T[0];
        Length = 0;
    }
    public void Add(T item)
    {
        var temp = new T[Length + 1];
        for (int i = 0; i < Length; i++)
        {
            temp[i] = items[i];
        }
        temp[Length] = item;
        items = temp;
        Length++;
    }
    public T this[int index]
    {
        get { return items[index]; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var list = new GenericList<Person>();
        list.Add(new Person("Tom", 20));
        list.Add(new Person("Bob", 30));
        list.Add(new Person("Sam", 40));

        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine($"Name: {list[i].Name}, Age: {list[i].Age}");
        }
    }
}