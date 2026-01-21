
namespace Inheritance
{
    public class Person
    {
        // Properties
        public string FullName { get; set; } = string.Empty;
        public byte Age { get; set; }

        // Methods
        public void Introduce()
        {
            Console.WriteLine($"My name is {FullName} and I am {Age} years old.");
        }
    }
}