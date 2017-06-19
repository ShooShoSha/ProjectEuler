namespace ProjectEulerLibrary
{
    public static class Problem
    {
        /// <summary>
        /// Solves problem one.
        /// </summary>
        /// <remarks>
        /// <para>If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6, and 9. The sum of these multiples is 23.</para>
        /// <para>Find the sum of all the multiples of 3 or 5 below 1000.</para>
        /// </remarks>
        /// <returns>Sum of multiples of 3 or 5 below 1000.</returns>
        public static int SolveProblem1(int upperBound = 1000)
        {
            var sum = 0;
            for (int i = 1; i < upperBound; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
