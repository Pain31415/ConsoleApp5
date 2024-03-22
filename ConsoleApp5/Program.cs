namespace ConsoleApp5
{
    class Rainbow
    {
        private Dictionary<string, string> rainbowColorsRGB;

        public Rainbow()
        {
            InitializeRainbowColors();
        }

        private void InitializeRainbowColors()
        {
            rainbowColorsRGB = new Dictionary<string, string>
        {
            {"red", "RGB(255, 0, 0)"},
            {"orange", "RGB(255, 165, 0)"},
            {"yellow", "RGB(255, 255, 0)"},
            {"green", "RGB(0, 128, 0)"},
            {"blue", "RGB(0, 0, 255)"},
            {"indigo", "RGB(75, 0, 130)"},
            {"violet", "RGB(148, 0, 211)"}
        };
        }

        public string GetRGBValue(string color)
        {
            if (rainbowColorsRGB.ContainsKey(color.ToLower()))
            {
                return rainbowColorsRGB[color.ToLower()];
            }
            else
            {
                return "Unknown color";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Rainbow rainbow = new Rainbow();

            string rainbowColor = "blue";
            Console.WriteLine($"RGB значення для кольору {rainbowColor}: {rainbow.GetRGBValue(rainbowColor)}");
        }
    }
}