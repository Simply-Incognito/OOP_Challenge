namespace Composition
{
    public class Student
    {
        // Props
        public long StudentNumber { get; set; }

        // Fields
        private readonly Person person;

        // ctor
        public Student(Person _person, long studentNumber)
        {
            person = _person;
            StudentNumber = studentNumber;
        }

        // Methods
        public void Introduce()
        {
            Console.WriteLine($"My name is {person.FullName} and I am {person.Age} years old.");
        }

        public void Study()
        {
            Console.WriteLine($"Student is studying...");
        }
    }
}