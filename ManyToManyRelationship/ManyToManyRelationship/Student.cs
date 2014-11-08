using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyRelationship
{
    public class Student
    {
        public string RegNo { set; get; }
        public string Name { set; get; }
        public override string ToString()
        {
            return RegNo;
        }

        public Student(string regNo, string name)
        {
            RegNo = regNo;
            Name = name;
        }
    }
}
