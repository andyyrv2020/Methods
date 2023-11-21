class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        People people = new People();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            int age = int.Parse(input[1]);
            people.AddPerson(name, age);
        }

        people.SortPeople();
        people.PrintPeopleOver30();
    }
}