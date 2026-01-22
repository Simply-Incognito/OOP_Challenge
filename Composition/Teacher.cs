namespace Composition
{
    public class Teacher
    {
        // Props
        public string Subject {get; set;}

        // Fields
        private readonly Person _person;

        // ctor
        public Teacher(Person person, string subject)
        {
            _person = person;
            Subject = subject;
        }

        // Methods
        public void Teach()
        {
            Console.WriteLine($"Teacher is teaching {Subject}");
        }
    }
}