namespace Inheritance
{
    public class Student : Person
    {
        // Props
        public long StudentNumber { get; set; }

        // Ctor
        public Student(string fullname, int age, long studentNumber)
            : base(fullname, age)
        {
            StudentNumber = studentNumber;
        }

        // Methods
        public void Study()
        {
            Console.WriteLine($"Student is stuying.");
        }
    }
}