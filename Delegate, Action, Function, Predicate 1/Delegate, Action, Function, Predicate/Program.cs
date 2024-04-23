using Delegate__Action__Function__Predicate.Models;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Delegate__Action__Function__Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();

            People.Add(new Person("Nurlan", "Abbasov", 20));
            People.Add(new Person("Kamil", "acsvgcjbh", 19));
            People.Add(new Person("Anar", "Gasimzada", 20));
            People.Add(new Person("Sahib", "Mammadov", 21));
            People.Add(new Person("Rauf", "Dostuyev", 22));

           /* People.FindAll(p => p.Name == "Kamil")
                .ForEach(p => Console.WriteLine(p.Name + " " + p.Surname));*/

            People.FindAll(p => p.Surname.EndsWith("ova") || p.Surname.EndsWith("ov"))
              .ForEach(p => Console.WriteLine(p.Name + " " + p.Surname));

           /* People.FindAll(p => p.Age>20)
                .ForEach(p => Console.WriteLine(p.Name + " " + p.Surname));*/

        }
    }
}
