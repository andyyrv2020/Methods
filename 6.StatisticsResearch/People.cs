class People
{
    private List<Person> peopleList;

    public People()
    {
        peopleList = new List<Person>();
    }

    public void AddPerson(string name, int age)
    {
        Person person = new Person { Name = name, Age = age };
        peopleList.Add(person);
    }

    public void SortPeople()
    {
        peopleList.Sort((p1, p2) => string.Compare(p1.Name, p2.Name, StringComparison.Ordinal));
    }

    public void PrintPeopleOver30()
    {
        foreach (Person person in peopleList.Where(p => p.Age > 30))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}