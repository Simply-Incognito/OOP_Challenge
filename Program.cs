
using Inheritance;

public class Program
{
    public static void Main(string[] args)
    {
        var student = new Student()
        {
            FullName = "Simply_",
            Age = 16,
            StudentNumber = 230805067
        };

        student.Introduce();

        student.Study();

        var teacher = new Teacher()
        {
            Subject = "Data Structures"
        };

        teacher.Teach();
    }
}