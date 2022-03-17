using System;
namespace FinalLabOne
{

    public class PartTime : Employee
    {
        public int commission;

        public PartTime(string id, string name, int salary, string joiningDate, int commission) : base(id, name, salary, joiningDate)
        {
            this.commission = commission;

        }

        public override void ShowInfo()

        {
            Console.WriteLine("PartTime Employee Id : ", this.id);
            Console.WriteLine("PartTime Emlpoyee Name : ", this.name);
            Console.WriteLine("PartTime Employee Salary : ", this.salary);
            Console.WriteLine("PartTime Employee Joining Date : ", this.joiningDate);
            Console.WriteLine("PartTime Employee Commission : ", this.commission);
        }

        public override void GrossIncome()
        {
            Console.WriteLine($"PartTime Employee Gross Income : {(salary * 12) + commission}");
        }
    }
}
