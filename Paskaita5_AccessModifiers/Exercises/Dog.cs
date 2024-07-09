namespace Paskaita5_AccessModifiers.Exercises
{
    internal sealed class Dog : Animal
    {
        public sealed override string MakeSound()
        {
            return "Woof woof";
        }
    }

    // "cannot derive from sealed type 'Dog'"
    //internal class BigDog : Dog
    //{

    //}
}
