namespace Paskaita9_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ***** #1 *****

            //var exe1 = new Exercise1<int, string>();

            //exe1.ChangeSalary(1500);
            //exe1.ChangePets(new List<string> { "hamster", "parrot" });

            //exe1.PrintSalary();
            //exe1.PrintPets();

            #endregion

            #region ***** #2 *****

            //var quadrilateral = new FourSideGeometricFigure("vardas", 10, 5);
            //var generator = new Generator<FourSideGeometricFigure>();

            //generator.Show(quadrilateral);

            //var generator2 = new Generator<string>();
            //generator2.Show("test");

            //var generator3 = new Generator<decimal>();
            //generator3.Show(11.8m);

            #endregion

            #region ***** #3 *****

            //var type = new Type<string, int>();
            //string text = "test";
            //type.GetType(text);

            #endregion
        }
    }
}
