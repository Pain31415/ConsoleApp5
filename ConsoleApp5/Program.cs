namespace ConsoleApp5
{
    class Program
    {
        static async Task Main()
        {
            int[] numbers = { 7, 14, 21, 3, 5, 6, 28 };

            Func<int[], Task<int>> countNumbersDivisibleBySevenAsync = async nums =>
            {
                await Task.Delay(100);
                return nums.Count(num => num % 7 == 0);
            };

            int count = await countNumbersDivisibleBySevenAsync(numbers);

            Console.WriteLine($"Кількість чисел у масиві, кратних семи: {count}");
        }
    }
}