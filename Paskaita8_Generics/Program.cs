using Paskaita8_Generics.Exercises;

namespace Paskaita8_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ***** Theory *****

            //PrintInfo(11);
            //PrintInfo(11.5m);
            //PrintInfo<string>("tekstas");
            //PrintInfoObj(11);
            //PrintInfoObj(11.5);
            //PrintInfoObj(11.5m);
            //PrintInfoObj("tekstas");

            //GenericClass<string, int> generic = new GenericClass<string, int>();
            //generic.Set("Tekstas", 123);
            //var value = generic.Get();

            //var repoTest = new Repository<Vegetable>(); // ?
            //var repoTomato = new Repository<Tomato>();

            //repoTomato.Add(new Tomato());
            //repoTomato.Add(new Tomato());
            //repoTomato.Add(new Tomato());
            ////repoTomato.Add(new Carrot()); // negalima

            //var ans = repoTomato.GetByIndex(0);
            //Console.WriteLine(ans.Color);

            #endregion

            #region ***** #1 *****

            //decimal? number = null;
            //Validation.Validate<decimal?>(number);

            #endregion

            #region ***** #2 *****

            //var value = new Value();
            //decimal number = 11.5m;
            //string text = "Labas";

            //value.ShowValues<decimal, string>(number, text);
            //value.ShowValues(number, text);

            #endregion

            #region ***** #3 *****

            //var myList = new MySelfCreatedList<string>();
            //myList.AddElement("vienas");
            //myList.AddElement("du");
            //myList.AddElement("trys");

            //myList.DeleteElementAt(1);
            //myList.DeleteElement("vienas");

            #endregion
        }

        #region ***** Theory *****

        public static void PrintInfo<T>(T obj)
        {
            Console.WriteLine(obj.GetType().Name + ": " + obj);
        }

        // reikia vengti naudoti object (geriau generic),
        // nes ne konkretus, o object tipas (pvz.: object (double))
        public static void PrintInfoObj(object obj)
        {
            Console.WriteLine(obj.GetType().Name + ": " + obj);

        }
        #endregion
    }
}
