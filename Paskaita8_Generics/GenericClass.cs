namespace Paskaita8_Generics
{
    internal class GenericClass<T1, T2>
    {
        private T1 Data;
        private T2 Data2;

        public void Set(T1 data, T2 data2)
        {
            Data = data;
            Data2 = data2;
        }

        // grazina Tuple
        public (T1, T2) Get()
        {
            return (Data, Data2);
        }

        public T1 GetT1()
        {
            return Data;
        }

        public T2 GetT2()
        {
            return Data2;
        }
    }
}
