using System.Xml.Linq;

namespace Homework_12._06._2024_Inheritance_Polymorphism
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new ();
            student.AddCourseWorksRatings(12);
            student.AddExamsRatings(12);
            student.AddTestsRatings(12);
            Console.WriteLine(student);
            student.Study();
            student.TakeExam();

            Aspirant aspirant = new ("'Pointer this'");
            aspirant.AddCourseWorksRatings(12);
            aspirant.AddExamsRatings(12);
            aspirant.AddTestsRatings(12);
            Console.WriteLine(aspirant);
            aspirant.Study();
            aspirant.TakeExam();
        }
    }
}
