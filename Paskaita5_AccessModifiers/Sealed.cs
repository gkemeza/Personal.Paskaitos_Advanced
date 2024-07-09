namespace Paskaita5_AccessModifiers
{
    internal class Sealed
    {
        public virtual void Print()
        {
            Console.WriteLine();
        }
    }

    internal class Mid : Sealed
    {
        public sealed override void Print()
        {
            Console.WriteLine();
        }
    }

    internal sealed class Low : Mid
    {
        // A member cannot override a sealed inherited member.

        //public override void Print()
        //{
        //    Console.WriteLine();
        //}
    }

    // A sealed class cannot act as a base class.

    //internal sealed class Lowest : Low
    //{
    //    //public override void Print()
    //    //{
    //    //    Console.WriteLine();
    //    //}
    //}
}
