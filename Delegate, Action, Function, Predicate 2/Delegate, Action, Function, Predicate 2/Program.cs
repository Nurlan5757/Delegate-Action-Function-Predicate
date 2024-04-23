using Delegate__Action__Function__Predicate_2.Models;

namespace Delegate__Action__Function__Predicate_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            exams.Add(new Exam("abc", 4, DateTime.Now));
            exams.Add(new Exam("avshb", 2, DateTime.Now));
            exams.Add(new Exam("asbxk", 5, DateTime.Now));
            exams.Add(new Exam("iol", 1, DateTime.Now));

            exams.FindAll(s => s.StartDate <= DateTime.Now.AddDays(7))
                .ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));


            exams.FindAll(s => s.ExamDuration > 2)
                .ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));


            exams.FindAll(s => DateTime.Now >= s.StartDate && DateTime.Now < s.EndDate)
                .ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));

        }
    }
}
