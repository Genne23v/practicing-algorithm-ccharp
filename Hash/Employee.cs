using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Employee
    {
        string name;
        int id;
        string department;

        public Employee(string name, int id, string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }

        static void main(string[] args)
        {
            Employee employee1 = new Employee("Robby", 3827, "Technology");
            Employee employee2 = new Employee("Bobby", 9415, "Marketing");
            Employee employee3 = new Employee("Sally", 2517, "Sales");

            Dictionary<int, Employee> employeesById = new Dictionary<int, Employee>();
            employeesById.Add(employee1.id, employee1);
            employeesById.Add(employee2.id, employee2);
            employeesById.Add(employee3.id, employee3);

            Employee employee;
            if (employeesById.TryGetValue(9415, out employee))
            {
                Console.WriteLine(employee.name + " : " + employee.department);
            };

            HashSet<string> productCodes = new HashSet<string>();
            productCodes.Add("8F26B");
            productCodes.Add("0A43P");
            productCodes.Add("JH762");

            productCodes.Contains("48d89");
            productCodes.Contains("JH762");
        }
    }
}
