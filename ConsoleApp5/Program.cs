namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Func<int[], int> findMax = array =>
            {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Масив має бути не порожнім", nameof(array));
                }

                return array.Max();
            };

            int[] numbers = { 3, 7, 2, 9, 5 };
            Console.WriteLine($"Максимум в масиві: {findMax(numbers)}");
        }
    }
}
