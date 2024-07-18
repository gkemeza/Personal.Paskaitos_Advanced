using Paskaita11_ExtensionMethods.Exercises;
using System.Collections.Generic;

namespace Paskaita11_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ***** Theory *****

            //string text = Console.ReadLine();

            //Console.WriteLine("Is empty?");
            //Console.WriteLine(text.IsEmpty());

            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Is {num} even?");
            //Console.WriteLine(num.IsEven());

            var person = new Person()
            {
                Id = 1,
                Name = "Jonas",
                Age = 30,
                PersonalCode = 321159755
            };

            //var personDTO = new PersonDTO()
            //{
            //    Name = person.Name,
            //    Age = person.Age,
            //};

            var personDto = person.PersonToDto();

            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var words = new List<string> { "Jonas", "Mantas", "Lukas" };
            var personsDto = new List<PersonDTO>
            {
                new PersonDTO
                {
                    Age = 30,
                    Name = person.Name,
                },
                new PersonDTO
                {
                    Age = 20,
                    Name = "Adomas",
                }
            };

            //numbers.PrintAllItems();
            //words.PrintAllItems();
            //personsDto.PrintAllItems();

            #endregion

            #region ***** Exercises *****

            //int number = -1;
            //int number2 = 1;
            //string text = "vie na sdu";
            //string fullName = "JonasJonaitis";
            //int yearOfBirth = 1965;
            //string domain = "@gmail.com";

            //Console.WriteLine($"{number} is positive: {number.IsPositive()}");
            //Console.WriteLine($"{number} is even: {number.IsEven()}");
            //Console.WriteLine($"{number} is bigger than {number2}: {number.IsBigger(number2)}");

            //Console.WriteLine($"Has empty spaces: {text.HasEmptySpaces()}");

            //Console.WriteLine($"Email: {fullName.GetEMail(yearOfBirth, domain)}");

            var names = new List<string> { "Jonas", "Mantas", "Adomas", "Lukas", "Benas" };
            string name = "Adomas";

            Console.WriteLine(names.FindAndReturnIfEqual(name));

            //var newList = names.EveryOtherWord();
            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            string path = @"../../../File.txt";
            File.WriteAllText(path, "testing\ntesting\ntesting");

            var file = new FileInfo(path);
            var everyOtherLine = file.GetEveryOtherLine();

            #endregion
        }
    }
}
