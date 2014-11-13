using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndCollectionInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student() {Name = "Badol", RegNo = "001"};
            Student aStudent1 = new Student() {Name = "Labib", RegNo = "002"};


            List<Student>StudentList=new List<Student>()
            {
                new Student(){Name="Badol",RegNo = "002"},
                new Student(){Name = "Labib",RegNo = "003"}
            };
            foreach (var student in StudentList)
            {
                Console.WriteLine(student.Name+"   "+student.RegNo);
            }
            Console.ReadKey();
        }
    }
}
