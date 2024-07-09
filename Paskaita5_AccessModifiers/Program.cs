using Paskaita5_AccessModifiers.Exercises;

namespace Paskaita5_AccessModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region ***** Theory *****

            //Human human = new Human();

            //// galima pasiekti
            //var value = human.Public;
            //var value1 = human.ProtectedInternal;
            //var value2 = human.Internal;

            // viduje projekto klases
            //human.Public = 0;
            // human.Private = 0; - nepasiekiam
            // human.Protected = 0; - nepasiekiam
            //human.Internal = 0;
            //human.ProtectedInternal = 0;
            // human.PrivateProtected = 0; - nepasiekiam

            // is kito prjekto
            //human.Public = 0;
            // human.Private = 0; - nepasiekiam
            // human.Protected = 0; - nepasiekiam
            // human.Internal = 0; - nepasiekiam
            // human.ProtectedInternal = 0; - nepasiekiam
            // human.PrivateProtected = 0; - nepasiekiam

            // Age
            //Animal animal = new Animal(15);

            //animal.Age = 20; // setter
            //Console.WriteLine(animal.Age); // getter

            // Age1
            //animal.SetAge(10); // leidzia naudoti setter nors ir private

            #endregion

            #region ***** #1 *****

            //Person person = new Person("Jonas", 50);
            //// protected
            ////person.PrintInfo();

            //Student student = new Student("Jonukas", 15, 5);
            //Console.WriteLine(student.GetStudentId());
            //// protected
            ////Console.WriteLine(student.Name);
            ////Console.WriteLine(student.Age);

            //Teacher teacher = new Teacher("Jonas", 30, "Matematika");
            //Console.WriteLine(teacher.GetSubject());
            //// protected
            ////Console.WriteLine(teacher.Name);
            ////Console.WriteLine(teacher.Age);

            #endregion

            #region ***** #2 *****

            //BankAccount bankAcc = new BankAccount();
            //bankAcc.SetBalance(100);
            ////account.PrintBalance();

            //SavingsAccount savingsAcc = new SavingsAccount(10);
            //savingsAcc.SetBalance(200);
            //// protected
            ////savings.Printbalance();

            //savingsAcc.CalculateInterestRate();
            //// protected
            ////savings.PrintBalance();

            //CheckingAccount checkingAcc = new CheckingAccount(5000);
            //checkingAcc.Withdraw(5000);

            #endregion

            #region ***** #3 *****

            //Circle circle = new Circle(3);
            //Console.WriteLine(circle.CalculateArea());

            #endregion

            #region ***** #4 *****

            Dog dog = new Dog();
            Console.WriteLine(dog.MakeSound());

            #endregion
        }
    }
}
