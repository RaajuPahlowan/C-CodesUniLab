using System;
namespace FinalLabOne
{
    public class Employee
    {
        public string id;
        public string name;
        public int salary;
        public string joiningDate;

        public Employee(string id, string name, int salary, string joiningDate)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joiningDate = joiningDate;

        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Employee Id : ", this.id);
            Console.WriteLine("Emlpoyee Name : ", this.name);
            Console.WriteLine("Employee Salary : ", this.salary);
            Console.WriteLine("Employee Joining Date : ", this.joiningDate);
        }
        public virtual void GrossIncome()
        {
            Console.WriteLine($"Employee Gross Income : {salary*12}");
        }
    }
}
