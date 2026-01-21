namespace Inheritance
{
    public class Student : Person
    {
        // Props
        public long StudentNumber { get; set; }

        // Methods
        public void Study()
        {
            Console.WriteLine($"Student is stuying.");
        }
    }
}