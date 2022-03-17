using System;
namespace FinalLabOne
{
    public class FullTime : Employee
    {
        public int bonus;

        public FullTime(string id, string name, int salary, string joiningDate, int bonus) : base(id, name, salary, joiningDate)
        {
            this.bonus = bonus;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("FullTime Employee Id : ", this.id);
            Console.WriteLine("FullTime Emlpoyee Name : ", this.name);
            Console.WriteLine("FullTime Employee Salary : ", this.salary);
            Console.WriteLine("FullTime Employee Joining Date : ", this.joiningDate);
            Console.WriteLine("FullTime Employee Bonus : ", this.bonus);

        }
        
        public override void GrossIncome()
        {
            Console.WriteLine($"FullTime Employee Gross Income : {(salary * 12) + (bonus * 2)}");
        }
    }
}
