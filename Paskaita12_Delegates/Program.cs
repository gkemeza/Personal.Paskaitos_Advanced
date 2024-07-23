namespace Paskaita12_Delegates
{
    internal class Program
    {
        static readonly int GlobalNumber = 10;

        // deklaruojam delegata
        public delegate int NumberChanger(int n);

        static void Main(string[] args)
        {
            #region ***** Theory *****

            var numberChangerDelegate1 = new NumberChanger(AddNumber);
            // arba taip
            //NumberChanger numberChangerDelegate1 = AddNumber;
            // arba taip
            //var numberChangerDelegate1 = AddNumber;

            var numberChangerDelegate2 = new NumberChanger(SubtractNumber);

            // negalime priskirti, nes grazinamas tipas nesutampa
            //var numberChangerDelegate3 = new NumberChanger(MultiplyNumber);

            Console.WriteLine(numberChangerDelegate1(5));
            Console.WriteLine(numberChangerDelegate2(15));

            numberChangerDelegate1 = new NumberChanger(SubtractNumber);
            Console.WriteLine(numberChangerDelegate1(5));

            // sukuriam delegato objekta ir priskiriam jam metodus (iskvietus 'del' bus iskviesti abu jam priskirti metodai)
            var del = numberChangerDelegate1 + numberChangerDelegate2;

            var del2 = new NumberChanger(AddNumber) + new NumberChanger(SubtractNumber);

            // iskvieciam delegata
            del(2);
            // leidzia kurti nauja metoda (o ne keisti esanti) ir prideti prie delegato

            var person = new Person();
            // anomininis metodas
            person.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine($"Property {eventArgs.PropertyName} has changed");
                //refresh page
            };

            Console.WriteLine("Changing age");
            person.Age = 25;

            Console.WriteLine("Changing name");
            person.Name = "Jonas";

            #endregion

            //var supratimo2 = new Supratimo2();
            //supratimo2.Start();

            //var supratimo3 = new Supratimo3();
            //supratimo3.A_Main();

            //var supratimo4 = new Supratimo4();
            //supratimo4.A_Main();

            //var supratimo6 = new Supratimo6();
            //supratimo6.A_Main();

            //var supratimo8 = new Supratimo8();
            //supratimo8.A_Main();

            //var supratimo5 = new Supratimo5();
            //supratimo5.A_Main();

            //Supratimo12.A_Main();
        }

        public static int AddNumber(int number)
        {
            return GlobalNumber + number;
        }

        public static int SubtractNumber(int number)
        {
            return GlobalNumber - number;
        }

        public static double MultiplyNumber(int number)
        {
            return GlobalNumber * number;
        }
    }

    /* KLAUSIMAS ===>> Kokia bus konsolėje išvedama reikšmė? kodėl?*/
    public class Supratimo2
    {
        public delegate int MathOperation(int a, int b);

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public void Start()
        {
            MathOperation op = Add;
            op += Multiply;

            int result = op(3, 4);
            Console.WriteLine(result);
        }
    }

    /* KLAUSIMAS ===>> Kokia bus konsolėje išvedama reikšmė? kodėl?*/
    public class Supratimo3
    {
        public delegate void MyDelegate(int number);

        public void PrintNumber(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        public void A_Main()
        {
            MyDelegate del = PrintNumber;
            del(5);

            del = null;
            if (del != null)
            {
                del(10);
            }
            del.Invoke(10);
        }
    }

    /* KLAUSIMAS ===>> Kokia bus konsolėje išvedama reikšmė? kodėl?*/
    public class Supratimo4

    {

        public delegate void MyDelegate(string message);

        public void MethodOne(string message)
        {
            Console.WriteLine("MethodOne: " + message);
        }

        public void MethodTwo(string message)
        {
            Console.WriteLine("MethodTwo: " + message);
        }

        public void A_Main()
        {
            MyDelegate del = MethodOne;

            del("First Call");

            del = MethodTwo;

            del("Second Call");
        }

    }

    /* KLAUSIMAS ===>> Kokia bus konsolėje išvedama reikšmė? kodėl?*/
    public class Supratimo6
    {
        public delegate void MyDelegate(string message);

        public void MethodOne(string message)
        {
            Console.WriteLine("MethodOne: " + message);
        }

        public void MethodTwo(string message)
        {
            Console.WriteLine("MethodTwo: " + message);
        }

        public void MethodThree(string message)
        {
            Console.WriteLine("MethodThree: " + message);
        }

        public void A_Main()
        {
            MyDelegate del = MethodOne;
            del += MethodTwo;
            del += MethodThree;
            del -= MethodTwo;

            del("Hello, Multicast!");
        }
    }

    /* KLAUSIMAS ===>> Kokia bus konsolėje išvedama reikšmė? kodėl?*/
    public class Supratimo8
    {
        public delegate void MyEventHandler(string message);
        public event MyEventHandler MyEvent;

        public void MethodOne(string message)
        {
            Console.WriteLine("MethodOne: " + message);
        }

        public void MethodTwo(string message)
        {
            Console.WriteLine("MethodTwo: " + message);
        }

        public void A_Main()
        {
            MyEvent += MethodOne;
            MyEvent += MethodTwo;

            OnMyEvent("Hello, Events!");
        }

        protected void OnMyEvent(string message)
        {
            if (MyEvent != null)
            {
                MyEvent(message);
            }
        }
    }

    /* KLAUSIMAS ===>>  Kokia bus konsolėje išvedama reikšmė? kur čia yra predikatas?*/
    public class Supratimo5
    {
        public bool IsEvenPredicate(int number)
        {
            return number % 2 == 0;
        }

        public void A_Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            List<int> evenNumbers = numbers.FindAll(IsEvenPredicate);
            Console.WriteLine(string.Join(",", evenNumbers));
        }
    }

    /* KLAUSIMAS ===>> Jei vartotojas įveda "2" kaip savo pasirinkimą, kokia bus konsolėje išvedama reikšmė? kodėl?*/
    // "Išskirstyta būsenų mašina"
    // kiekviena klasė atsakinga už tam tikrą dalyką
    public class Menu
    {
        public event Action<int> OnMenuSelection;

        public void ShowMenu()
        {
            Console.WriteLine("Pasirinkite meniu punktą:");
            Console.WriteLine("1. Pasirinkimas 1");
            Console.WriteLine("2. Pasirinkimas 2");
            Console.WriteLine("3. Pasirinkimas 3");

            int selection = Convert.ToInt32(Console.ReadLine());

            // Suaktyviname įvykį
            OnMenuSelection?.Invoke(selection);
        }
    }
    public class Handler1
    {
        public void Subscribe(Menu menu)
        {
            menu.OnMenuSelection += HandleSelection;
        }

        private void HandleSelection(int selection)
        {
            if (selection == 1)
            {
                Console.WriteLine("Handler1: Pasirinkimas 1 apdorotas.");
            }
        }
    }
    public class Handler2
    {
        public void Subscribe(Menu menu)
        {
            menu.OnMenuSelection += HandleSelection;
        }

        private void HandleSelection(int selection)
        {
            if (selection == 2)
            {
                Console.WriteLine("Handler2: Pasirinkimas 2 apdorotas.");
            }
        }
    }
    public class Supratimo12
    {
        public static void A_Main()
        {
            Menu menu = new Menu();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();

            handler1.Subscribe(menu);
            handler2.Subscribe(menu);

            menu.ShowMenu();
        }
    }
}