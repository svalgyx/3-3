namespace HW3_3
{
    public interface IArray : IPrinter
    {
        bool Init { get; }

        void Print();

        double Average();

        void RandomAr();

        void UserAr();
    }
}
