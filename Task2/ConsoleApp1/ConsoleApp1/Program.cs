using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("zaminali rustemov",19,504842198);
            person.FullName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(person.FullName.ToLower());

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.PhoneNumber);

        }
    }
}