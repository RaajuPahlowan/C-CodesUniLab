using System;

namespace FinalLabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTime ft = new FullTime("E001", "LexLuthor", 30000, "12-10-2018", 15000);
            PartTime pt = new PartTime("E002", "BlackAdam", 12000, "23-08-2021", 1300);
            ft.ShowInfo();
            ft.GrossIncome();
            pt.ShowInfo();
            pt.GrossIncome();
        }
    }
}
