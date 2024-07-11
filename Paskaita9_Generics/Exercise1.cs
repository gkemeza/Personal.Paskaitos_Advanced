namespace Paskaita9_Generics
{
    internal class Exercise1<T1, T2>
    {
        private T1 salary;
        private List<T2> pets;

        public void PrintSalary()
        {
            Console.WriteLine(salary);
        }

        public void PrintPets()
        {
            foreach (var pet in pets)
            {
                Console.WriteLine(pet);
            }
        }

        public void ChangeSalary(T1 salary)
        {
            this.salary = salary;
        }

        public void ChangePets(List<T2> pets)
        {
            this.pets = pets;
        }
    }

}