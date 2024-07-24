namespace Paskaita14_Interfaces
{
    internal class ShapesComparer : IComparer<IShape>
    {
        public int Compare(IShape? x, IShape? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null)
            {
                return -1;
            }
            if (y == null)
            {
                return 1;
            }

            if (x.GetArea() > y.GetArea())
            {
                return -1;
            }
            if (x.GetArea() < y.GetArea())
            {
                return 1;
            }
            return 0;
        }
    }
}