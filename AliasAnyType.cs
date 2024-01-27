using Person = (string name, int age, string country);

namespace DotNet8AndCSharp12Features
{
    public static class AliasAnyType
    {
        public static Person GetPerson()
        {
            Person person = new Person("Ali", 25, "Denizli");
            return person;
        }

        public static void PrintPerson(Person person)
        {
            Console.WriteLine($"{person.name}, {person.age}, {person.country}");
        }
    }
}
