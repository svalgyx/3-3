using System;
using System.Diagnostics.SymbolStore;

namespace HW3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array[] arrays = new Array[10];
            Rnd rnd = new Rnd();
            for (int i = 0; i < arrays.Length; i++)
            {
                int num = rnd.Next(1, 4);
                if (num == 1)
                {
                    Single single_ar = new Single("no", rnd.Next(1, 11));
                    single_ar.Create();
                    arrays[i] = single_ar;
                }
                if (num == 2)
                {
                    int rows = rnd.Next(1, 11);
                    int columns = rnd.Next(1, 11);
                    Matrix matrix_ar = new Matrix("no", rows, columns);
                    matrix_array.Create();
                    arrays[i] = matrix_ar;
                }
                if (num == 3)
                {
                    int jagged_rows = rnd.Next(1, 11);
                    Jagged jagged_ar = new Jagged("no", jagged_rows);
                    jagged_ar.Create();
                    arrays[i] = jagged_ar;
                }
            }
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i].Print();
                Console.WriteLine($"The average is: {arrays[i].Average()}");
            }
            WeekDay[] days = { new WeekDay("Monday"), new WeekDay("Tuesday"), new WeekDay("Wednesday"), new WeekDay("Thursday"), new WeekDay("Friday"), new WeekDay("Saturday"), new WeekDay("Sunday")};
            Console.WriteLine("Printing days of the week: ");
            for (int i = 0; i < days.Length; i++) {
                days[i].Print();
            }
            Console.ReadLine();
        }
    }
}
