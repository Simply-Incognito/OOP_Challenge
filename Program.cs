
using Inheritance;

public class Program
{
    public static void Main(string[] args)
    {
        var student = new Student("Incognito", 17, 230805067);

        student.Introduce();

        student.Study();

        var teacher = new Teacher("Simply_", 45, "Data Structures");

        teacher.Teach();
    }
}