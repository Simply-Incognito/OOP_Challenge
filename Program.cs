
using Inheritance;
using Composition;

public class Program
{
    public static void Main(string[] args)
    {
        // Inheritance
        var student = new Inheritance.Student("Incognito", 17, 230805067);

        student.Introduce();
        student.Study();

        var teacher = new Inheritance.Teacher("Simply_", 45, "Data Structures");

        teacher.Teach();

        Console.WriteLine($"--------------------------");
        

        // Composition
        var person = new Composition.Person("Incognito", 17);
        var _student = new Composition.Student(person, 230805067);

        _student.Introduce();
        _student.Study();

        var _teacher = new Composition.Teacher(new Composition.Person("Simply_", 40), "Data Structures and Algorithm.");

        _teacher.Teach();
    }
}