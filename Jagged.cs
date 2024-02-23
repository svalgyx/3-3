namespace HW3_3
{
    public sealed class Jagged : Array, IJagged
    {
        private int Rows { get; set; }
        private int[][] array;

        public Jagged(string init, int rows) : base(init)
        {
            Rows = rows;
            array = new int[rows][];
        }

        public override void UserAr() {
            for (int i = 0; i < Rows; i++)
            {
                string row = Console.ReadLine();
                string[] array_row = row.Split(' ');
                array[i] = new int[array_row.Length];
                for (int j = 0; j < array_row.Length; j++)
                {
                    array[i][j] = int.Parse(array_row[j]);
                }
            }
        }

        public override void RandomAr() {
            Rnd rnd = new Rnd();
            for (int i = 0; i < Rows; i++)
            {
                int array_row_len = rnd.Next(1, 10);
                array[i] = new int[array_row_len];
                for (int j = 0; j < array_row_len; j++)
                {
                    array[i][j] = rnd.Next(1, 100);
                }
            }
        }

        public void Create()
        {
            if (base.Init)
            {
                UserAr();
            }
            else
            {
                RandomAr();
            }
        }

        public override void Print()
        {
            Console.WriteLine("jagged array: ");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override double Average()
        {
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    counter += 1;
                }
            }
            Console.WriteLine("Average: ");
            return (double)sum / (double)counter;
        }

        public void ChangeEvenNums()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
            Console.WriteLine("Elements changed: ");
        }
    }
}
