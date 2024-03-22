namespace ConsoleApp5
{
    class Program
    {
        static async Task Main()
        {
            Func<int, Task<int>> calculateSquareAsync = async (int number) =>
            {
                await Task.Delay(100);
                return number * number;
            };

            int testNumber = 5;
            int square = await calculateSquareAsync(testNumber);
            Console.WriteLine($"Квадрат числа {testNumber} дорівнює: {square}");
        }
    }
}