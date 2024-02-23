namespace HW3_3
{
    public abstract class Array : IArrayBase
    {
        public bool Init { get; set; }

        public abstract void Print();

        public abstract double Average();

        public abstract void RandomAr();

        public abstract void UserAr();

        public Array(string init)
        {
            Init = true;
            if (init == "no")
            {
                Init = false;
            }
        }
    }
}
