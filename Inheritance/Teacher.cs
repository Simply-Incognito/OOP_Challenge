namespace Inheritance
{
    public class Teacher : Person
    {
        // Props
        public string Subject { get; set; } = string.Empty;

        // Methods
        public void Teach()
        {
            Console.WriteLine($"Teacher is teaching {Subject}");
        }
    }
}