using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLambdaComLinq.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Emaill { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string emaill, double salary)
        {
            Name=name;
            Emaill=emaill;
            Salary=salary;
        }
    }
}
