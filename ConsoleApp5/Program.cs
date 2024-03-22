namespace ConsoleApp5
{
    class Program
    {
        private static readonly object locker = new object();

        static async Task Main()
        {
            Func<DateTime, Task<bool>> isProgrammerDayAsync = async date =>
            {
                await Task.Delay(100);
                return date.DayOfYear == 256;
            };

            DateTime testDate1 = new DateTime(2024, 9, 12);
            DateTime testDate2 = new DateTime(2024, 9, 13);

            Console.WriteLine($"Чи є {testDate1.Date} днем програміста? {await CheckIsProgrammerDayAsync(testDate1, isProgrammerDayAsync)}");
            Console.WriteLine($"Чи є {testDate2.Date} днем програміста? {await CheckIsProgrammerDayAsync(testDate2, isProgrammerDayAsync)}");
        }

        static async Task<bool> CheckIsProgrammerDayAsync(DateTime date, Func<DateTime, Task<bool>> isProgrammerDayAsync)
        {
            bool result;
            lock (locker)
            {
                result = isProgrammerDayAsync(date).Result;
            }
            return result;
        }
    }
}