using Paskaita6_Streams.Exercises;
using System.Text;

namespace Paskaita6_Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ***** Theory *****

            //Console.WriteLine("Hello, Streams!");
            //var darbasSuFailais = new DarbasSuFailais();
            //// prastas budas! (\\ - naudojamas tik windows, kitose os - kitaip)
            //var filePath = "C:\\Users\\Darbas\\.NET_Code\\CodeAcademy\\Paskaitos_Advanced\\Paskaita6_Streams\\tekstas.txt";
            //var filePath1 = "tekstas.txt"; // reikia ant txt failo -> Properties -> Copy to Output Directory -> Copy always // irgi prastai (reikia teisingai nurodyti pilna kelia)
            //var text = darbasSuFailais.ReadAllText(filePath1);
            ////Console.WriteLine(text);

            //var filePath2 = "tekstas2.txt";
            //var newText = "Naujas tekstas!";
            ////darbasSuFailais.WriteAllText(filePath2, newText);

            //var text2 = darbasSuFailais.ReadAllText(filePath2);
            ////Console.WriteLine(text2);

            //var pathToGyvunai = "C:\\Users\\Darbas\\.NET_Code\\CodeAcademy\\Paskaitos_Advanced\\Paskaita6_Streams\\gyvunai.txt"; // !!!
            //string[] gyvunai = darbasSuFailais.ReadAllLines(pathToGyvunai);

            //foreach (var gyvunas in gyvunai)
            //{
            //    Console.WriteLine($"gyvunas yra - {gyvunas}");
            //}

            //string[] naujiGyvunai = ["Kate", "Suo", "Eziukas"];
            //// neprideda, bet perraso visa teksta
            //darbasSuFailais.WriteAllLines(pathToGyvunai, naujiGyvunai);

            //var papuga = "Papuga";
            //naujiGyvunai = naujiGyvunai.Concat(new string[] { papuga }).ToArray();
            //darbasSuFailais.WriteAllLines(pathToGyvunai, naujiGyvunai);
            ////taip pat yra File.AppendAllLines() ir kita

            #endregion

            #region ***** #1 *****

            //// Perskaitykite visą tekstinį failą naudodami File.ReadAllText() metodą ir išspausdinkite į konsolę.
            Exercise1 exe1 = new Exercise1();
            Console.WriteLine(Directory.GetCurrentDirectory());
            exe1.PrintAllText("Exercises\\text.txt");

            #endregion

            #region ***** #2 *****

            //// Įrašykite į failą turinį iš List<string> sąrašo, kiekvieną elementą kaip naują eilutę. Naudodami File.WriteAllLines().
            Exercise2 exe2 = new Exercise2();
            exe2.WriteText();

            //// Perskaitykite didelį tekstinį failą po eilutę ir suskaičiuokite kiekvienos eilutės simbolių skaičių. Naudokite File.ReadLines()
            //exe2.ReadLines();

            #endregion

            #region ***** Supratimo uzduotys *****

            //Program program = new Program();
            //program.SupratimoUzduotis1("C:\\Users\\Darbas\\.NET_Code\\CodeAcademy\\Paskaitos_Advanced\\Paskaita6_Streams\\Exercises\\text.txt");

            //program.SupratimoUzduotis2("C:\\Users\\Darbas\\.NET_Code\\CodeAcademy\\Paskaitos_Advanced\\Paskaita6_Streams\\Exercises\\text.txt");

            #endregion

            #region ***** Paskaita 2 *****

            Console.WriteLine("Hello, Streams kartojimas");
            var manoKlase = new ManoKlase();
            var listas = new List<string>();

            // error
            //manoKlase.manoMetodas1(listas);
            manoKlase.manoMetodas1(listas.ToArray());

            manoKlase.manoMetodas2(listas);
            var masyvas = new string[] { "a", "b", "c" };
            manoKlase.manoMetodas2(masyvas);

            #endregion
        }

        #region ***** Supratimo uzduotys *****

        /*Kas negerai su šiuo metodu rašančiu eilutes į failą iš masyvo? Įvardinkite ir pataisykite.*/
        // naudojo Write() vietoj WriteLine()
        public void SupratimoUzduotis1(string path)
        {
            string[] lines = new string[] { "Line 1", "Line 2", "Line 3" };
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        /*Kas negerai su šiuo metodu rašančiu eilutes į failą? Įvardinkite ir pataisykite.*/
        // nenaudojo paduoto path ir naudojo \r\n, kurie veikia tik per windows (arba galima sudeti teksta i masyva ir naudoti WriteAllLines())
        public void SupratimoUzduotis2(string path)
        {
            string tekstas = $"orem ipsum dolor sit amet, consectetur adipiscing elit.{Environment.NewLine}" +
                $" Curabitur ultrices ipsum tortor, in faucibus mi gravida et. {Environment.NewLine}" +
                $"Curabitur magna nisl, consequat ac efficitur quis, venenatis vel lectus.{Environment.NewLine}" +
                " Fusce id ipsum eu tellus varius fermentum id sed sapien. ";
            File.WriteAllText(path, tekstas);
        }

        /*Kaip galėtumėte patobulinti šį kodą, kad būtų užtikrintas geresnis išteklių valdymas ir našumas? */
        // nenaudojo using
        public void SupratimoUzduotis3(string path)
        {
            using (FileStream fs = new FileStream("example.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];

                fs.Read(buffer, 0, buffer.Length);

                string content = Encoding.UTF8.GetString(buffer);
                Console.WriteLine(content);
            }
        }

        /*Analizuokite žemiau pateiktą metodą ReadFileContent. Kokios situacijos ar įvestys gali lemti blogą metodo veikimą?*/
        /* (gali buti neteisingas filePath, netikrina ar nera null, netikrina ar toks failas jau egzistuoja) - mano ats.
         * ATSAKYMAS: 
        - Failas neegzistuoja: Jei failas nurodytu keliu neegzistuoja, FileNotFoundException išimtis bus išmesta.
        - Neleidžiama prieiga: Jei programa neturi leidimo skaityti failo, bus išmesta UnauthorizedAccessException.
        - Failas užimtas kitu procesu: Jei failas jau atidarytas kitu procesu, IOException gali būti išmesta.
        - Per Didelis failas: Skaitymas į atmintį didelio failo gali užimti daug atminties ir sukelti OutOfMemoryException.
        - filePath per ilgas: windows sistemoje failo kelias negali būti ilgesnis nei 260 simbolių.
        - Gali būti koduotės problemų: Jei failas yra kitos koduotės nei UTF-8, gali būti problemų su simbolių kodavimu.
        */
        public string ReadFileContent(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }

        #endregion
    }
}