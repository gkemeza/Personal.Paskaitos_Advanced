namespace Paskaita2_MethodsInClasses
{
    /*
    #1
        Main metode esanciame Program klaseje iskvieskite metoda is ManoKlase2 ir isveskite i ekrana manoKintamasis reiksme. 
        Tam reikes sukurti metoda ManoKlase2 klaseje 
        manoKintamasis turi likti globalus kintamasis
    #2
        Main metode esanciame Program klaseje iskvieskite metoda is ManoKlase2 ir kuriame pakeisite manoKintamasis reiksme į "nauja kintamojo reiksme".
        - Tam reikes sukurti metoda ManoKlase2 klaseje
        - manoKintamasis turi likti globalus kintamasis ir private
        - poto kai pakeitėte kintamojo reikšmę (iškvitėte metodą), išveskite i ekraną pradine ir pakeista reiksmę (panaudokite praitoje užduotyje sukurta metoda)
    */
    public class ManoKlase2
    {
        private string manoKintamasis = "Tekstas, kuri reikia atspausdinti";

        public void PrintText()
        {
            Console.WriteLine(manoKintamasis);
        }

        public void ChangeText()
        {
            manoKintamasis = "nauja kintamojo reiksme";
        }
    }
}
