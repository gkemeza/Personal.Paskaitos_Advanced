using System.Xml.Linq;

namespace Paskaita13_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var linqRodymas = new LinqRodymas();
            //linqRodymas.A_Main();

            // #1
            //string[] collection = { "Jonas", "Lukas", "Mantas", };
            //var result = Exercises.SortWhereLengthIsMoreThan5(collection);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // #2
            //var AllIphones = new List<Iphone>
            //{
            //    { new Iphone("Iphone 15 pro max", 1000)},
            //    { new Iphone("Iphone 15 pro", 900)},
            //    { new Iphone("Iphone 15 plus", 800)},
            //    { new Iphone("Iphone 15", 700)},
            //    { new Iphone("Iphone 14 pro max", 800)}
            //};

            //var ProIphonesWithDiscount = AllIphones
            //    .Where(phone => phone.Name.ToLower().Contains("pro"))
            //    .Select(phone => new Iphone(
            //        phone.Name + " (sale)",
            //        phone.Price * 0.9m))
            //    .ToList();

            //foreach (var item in ProIphonesWithDiscount)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Price}");
            //}

            // #3
            //var skaiciai = new List<int> { -5, 10, -80, 100, 0, 1, -15, 12, 30, -43 };
            //var naujiSkaiciai = skaiciai
            //    .Where(s => s > 0)
            //    .Select(s => s * s)
            //    .OrderBy(s => s);

            //foreach (var num in naujiSkaiciai)
            //{
            //    Console.WriteLine(num);
            //}

            // #4

            //var knygos = new List<(string Pavadinimas, string Autorius, int Puslapiai, int Metai, string Zanras, double Reitingas)>
            //{
            //    ("Haris Poteris", "J.K. Rowling", 223, 1997, "Fantastika", 4.7),
            //    ("1984", "George Orwell", 328, 1949, "Distopija", 4.6),
            //    ("Karas ir taika", "Leo Tolstoy", 1225, 1869, "Istorinis romanas", 4.1),
            //    ("Mažasis princas", "Antoine de Saint-Exupéry", 96, 1943, "Filosofija", 4.5),
            //    ("Nusikaltimas ir bausmė", "Fiodor Dostojevskij", 671, 1866, "Psichologinis trileris", 4.3),
            //    ("Metai", "Kristijonas Donelaitis", 228, 1818, "Poezija", 4.0),
            //    ("Altorių šešėly", "Vincas Mykolaitis-Putinas", 534, 1933, "Romanas", 4.2),
            //    ("Dievų miškas", "Balys Sruoga", 442, 1957, "Memuarai", 4.4)
            //};

            //var sortedBooks = knygos
            //    .OrderBy(x => x.Zanras)
            //    .ThenByDescending(x => x.Puslapiai)
            //    .ThenByDescending(x => x.Reitingas)
            //    .Where(x => x.Puslapiai > 300 && x.Metai > 1900);

            //foreach (var book in sortedBooks)
            //{
            //    Console.WriteLine($"{book.Pavadinimas} {book.Zanras} {book.Reitingas} {book.Puslapiai} {book.Metai}");
            //}

            //    List<string> sentences = new List<string>
            //{
            //    "The quick brown fox jumps over the lazy dog.",
            //    "A journey of a thousand miles begins with a single step.",
            //    "To be or not to be, that is the question.",
            //    "All that glitters is not gold.",
            //    "The only thing we have to fear is fear itself."
            //};

            //    string keyword = "fear";

            //    string? firstSentenceWithKeyword = sentences
            //        .Select(sentence => sentence.ToUpper())
            //        .FirstOrDefault(sentence => sentence.Contains(keyword.ToUpper()));

            //    Console.WriteLine(firstSentenceWithKeyword);
            //}

            /*
            Pagrindiniai LINQ operatoriai 
            Flipped classroom šaltiniai: 
             - https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/walkthrough-writing-queries-linq
             - https://www.tutorialsteacher.com/linq
             - https://dotnettutorials.net/course/linq/
            Sukurkite užduotį kitiems studentantams kuriose naudojama LINQ su kolekcijomis metodai. 
            Jūsų užduotys turi būti aiškios, suprantamos. Konkretus LINQ metodas turi būti naudojamas pagal jo paskirtį.
            Užduotys atsitiktinai bus paskirtos kitiems studentams, kurie turės jas atlikti.
            Užduotyse gali būti naudojami tik jau anksčiau išbandyti LINQ metodai:
            */
            //Where

            // #1
            // Sukurti Product klasę su dviem savybėm: Name ir Price.
            // Sukurti Product sąrašą su keliais produktais.
            // Atspausdinti produktus kurie kainuoja maziau nei 1Eur.
            // Atspausdinti produktus kurie prasideda raide 'B'.

            // #2
            // Sukurkite metodą, kuris per parametrus paima List<int>.
            // Metodas turi surasti tik teigiamus skaičius, padalinti iš 2 ir grąžinti naujame sąraše.

            // #3
            // Sukurti Product klasę su dviem savybėm: Price ir Quantity.
            // Sukurti 'myProducts' sąrašą su keliais produktais.
            // Iš šio sąrašo sukurti 'sortedByTotalValue' sąrašą,
            // kuriame produktai bus surikiuoti pagal mažėjančią bendrą vertę (Price * Quantity)

            // #4
            // Sukurti 'names' sąrašą su keleta vardų.
            // Atspausdinti vardus surikiuotus pagal:
            // pirma - abėcėlės (a-z) tvarka,
            // antra - vardo ilgį mažėjančia tvarka

            // ?
            //        var names = new List<string> { "Jonas", "Benas", "Antanas", "Bronius" };

            //        var sortedNames = names
            //            .OrderBy(x => x)
            //            .ThenByDescending(x => x.Length);

            //            foreach (var name in sortedNames)
            //            {
            //                Console.WriteLine(name);
            //            }

            // #4

            /*
                    List<string> sentences = new List<string>
            {
                "The quick brown fox jumps over the lazy dog.",
                "A journey of a thousand miles begins with a single step.",
                "To be or not to be, that is the question.",
                "All that glitters is not gold.",
                "The only thing we have to fear is fear itself."
            };

            string keyword = "fear";

            Paversti kiekvieną sakinį į didžiąsias raides.
            Surasti pirmąjį sakinį, kuriame yra 'keyword', arba numatytąją vertę, jei tokio sakinio nėra.
            */
        }
    }
}