namespace ProjectEulerLibrary
{
    using System.Collections.Generic;

    public class Fibonacci
    {
        const int MAX_NTH_FIBONACCI = 40;

        public static int Get(int nthValue)
        {
            if (nthValue <= 1)
            {
                return 0;
            }
            else if (nthValue == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci.Get(nthValue - 1) + Fibonacci.Get(nthValue - 2);
            }
        }

        public List<int> Values { get; private set; }

        public Fibonacci()
        {
            this.Values = new List<int>(MAX_NTH_FIBONACCI)
            {
                1, 2, 3, 5, 8, 13, 21, 34, 55, 89
            };
            this.Seed();
        }

        private void Seed()
        {
            for (int i = this.Values.Count; i < this.Values.Capacity; i++)
            {
                this.Values.Add(this.Values[i - 2] + this.Values[i - 1]);
            }
        }
    }
}
