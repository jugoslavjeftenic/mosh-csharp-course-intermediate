namespace t02_04_Methods
{
    internal class Calculator
    {
        internal int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var n in numbers)
            {
                sum += n;
            }

            return sum;
        }
    }
}