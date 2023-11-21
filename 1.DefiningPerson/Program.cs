namespace DefiningPerson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Gosho";
            firstPerson.Age = 30;

            firstPerson.IntroduceYourself();
        }
    }
}