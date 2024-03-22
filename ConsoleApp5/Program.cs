namespace ConsoleApp5
{
    class Program
    {
        static async Task Main()
        {
            int[] array = { 3, 7, 2, 8, 1, 5 };

            Func<int[], Task<int[]>> findOddNumbersAsync = async arr =>
            {
                await Task.Delay(100);
                return arr.Where(num => num % 2 != 0).ToArray();
            };

            int[] oddNumbers = await findOddNumbersAsync(array);

            Console.WriteLine("Непарні числа в масиві:");
            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
