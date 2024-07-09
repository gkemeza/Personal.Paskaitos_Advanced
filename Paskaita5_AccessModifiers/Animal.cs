namespace Paskaita5_AccessModifiers
{
    internal class Animal
    {
        public Animal(int age)
        {
            Age = age; // set

            Console.WriteLine(Age); // get
        }

        // Age
        public int Age { get; set; }

        // Age1
        public int Age1 { get; private set; }

        public void SetAge(int age)
        {
            Age1 = age;
        }

        // Age2
        public int Age2
        {
            get { return Age; }
            set { Age = value; }
        }

        // Age3
        // jei nori kazkokia specialia/paprasta logika irasyti, kad nereiketu metodo kurti
        private int age;
        public int Age3
        {
            get
            {
                return age + 100;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be below 0");
                }
                age = value;
            }
        }

        // Date
        private DateTime date;
        public string Date
        {
            get
            {
                return date.ToString();
            }
            set
            {
                if (DateTime.TryParse(value, out DateTime result))
                {
                    date = result;
                }
                else
                {
                    throw new ArgumentException("Cannot parse value");
                }
            }
        }
    }
}
