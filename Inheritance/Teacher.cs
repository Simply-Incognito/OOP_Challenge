namespace Inheritance
{
    public class Teacher : Person
    {
        // Props
        public string Subject { get; set; } = string.Empty;

        // ctor
        public Teacher(string fullname, int age, string subject)
            : base(fullname, age)
        {
            Subject = subject;
        }

        // Methods
        public void Teach()
        {
            Console.WriteLine($"Teacher is teaching {Subject}");
        }
    }
}