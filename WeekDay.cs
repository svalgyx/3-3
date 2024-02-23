namespace HW3_3
{
    public class WeekDay : IPrinter
    {
        private string[] WeekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private string Day;
        public WeekDay(string name)
        {
            if (!(Array.Exists(WeekDays, element => element == day)))
            {
                Day = "Monday";
            } else
            {
                Day = day;
            }
        }
        public void Print()
        {
            Console.WriteLine(Day);
        }
    }
}
