namespace HW3_3
{
    public sealed class Single : Array, ISingle
    {
        private int Len { get; set; }
        private int[] array;
        public Single(string init, int len) : base(init)
        {
            Len = len;
            array = new int[len];
        }

        public override void UserAr() {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < Len; i++)
            {
                array[i] = int.Parse(inputs[i]);
            }
        }

        public override void RandomAr() {
            Rnd rnd = new Rnd();
            for (int i = 0; i < Len; i++)
            {
                array[i] = rnd.Next(0, 1000);
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
            Console.WriteLine("single array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public override double Average()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("average: ");
            return (double)sum / (double)(Len);
        }

        private bool ContainsStopIndex(int[] array, int element, int stop_index)
        {
            for (int i = 0; i < stop_index; i++)
            {
                if (array[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public void ClearAr()
        {
            int[] clear_ar = new int[array.Length];
            int count = 0;
            for (int i = 0; i < Len; i++)
            {
                if (!(ContainsStopIndex(clear_ar, array[i], count)))
                {
                    clear_ar[count] = array[i];
                    count++;
                }
            }
            int[] clear_ar_result = new int[count];
            Array.Copy(clear_ar, 0, clear_ar_result, 0, count);
            array = clear_ar_result;
            Console.WriteLine("repeated elements deleted");
        }
    }
}
