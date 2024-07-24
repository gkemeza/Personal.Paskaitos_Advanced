namespace Paskaita14_Interfaces.Exercises
{
    internal class AudiCarComparer : IComparer<AudiCar>
    {
        public int Compare(AudiCar? x, AudiCar? y)
        {
            if (x.Fuel == null && y.Fuel == null)
            {
                return 0;
            }
            if (x.Fuel == null)
            {
                return 1;
            }
            if (y.Fuel == null)
            {
                return -1;
            }

            if (x.Fuel > y.Fuel)
            {
                return 1;
            }
            if (x.Fuel < y.Fuel)
            {
                return -1;
            }

            return 0;
        }
    }
}
