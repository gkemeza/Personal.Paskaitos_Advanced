namespace Paskaita8_Generics.Exercises
{
    internal class MySelfCreatedList<T>
    {
        private T[] MyArray { get; set; }
        private int Index = 0;
        private int Size = 10;

        public MySelfCreatedList()
        {
            MyArray = new T[Size];
        }

        public void AddElement(T elementToAdd)
        {
            if (IsFull())
            {
                MyArray = IncreaseListSize();
            }
            if (elementToAdd != null)
            {
                MyArray[Index] = elementToAdd;
                Index++;
            }
            else
            {
                throw new ArgumentNullException(nameof(elementToAdd));
            }
        }

        private bool IsFull()
        {
            return Index == Size;
        }

        private T[] IncreaseListSize()
        {
            Size++;
            var newArray = new T[Size];
            MyArray.CopyTo(newArray, 0);
            return newArray;
        }

        public void DeleteElement(T value)
        {
            int indexToDelete = Array.IndexOf(MyArray, value);

            var newArray = new T[MyArray.Length - 1];
            for (int i = 0; i < MyArray.Length - 1; i++)
            {
                if (i >= indexToDelete)
                {
                    newArray[i] = MyArray[i + 1];
                }
                else
                {
                    newArray[i] = MyArray[i];
                }
            }
            MyArray = newArray;
        }

        public void DeleteElementAt(int index)
        {
            var newArray = new T[MyArray.Length - 1];
            for (int i = 0; i < MyArray.Length - 1; i++)
            {
                if (i >= index)
                {
                    newArray[i] = MyArray[i + 1];
                }
                else
                {
                    newArray[i] = MyArray[i];
                }
            }
            MyArray = newArray;
        }

    }
}
