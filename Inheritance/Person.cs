
namespace Inheritance
{
    public class Person
    {
        // Properties
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }

        // ctor
        public Person(string fullname, int age)
        {
            FullName = fullname;
            Age = age;
        }

        // Methods
        public void Introduce()
        {
            Console.WriteLine($"My name is {FullName} and I am {Age} years old.");
        }
    }
}