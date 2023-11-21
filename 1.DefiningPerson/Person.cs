using System;

public class Person
{
    private string name;
    private int age;

    // Свойство за достъп до полето name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Свойство за достъп до полето age
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Метод за представяне
    public void IntroduceYourself()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}
