namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int[] array = { 3, 7, 2, 8, 1, 5 };

            Func<int[], int> findMin = arr =>
            {
                int min = arr[0];
                foreach (int num in arr)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            };

            Console.WriteLine($"Мінімальний елемент в масиві: {findMin(array)}");
        }
    }
}
