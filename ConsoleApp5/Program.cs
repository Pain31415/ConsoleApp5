namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Backpack backpack = new Backpack("чорний", "Nike", "поліестер", 1.5, 0, 10);

            backpack.ItemAdded += (sender, item) =>
            {
                Console.WriteLine($"Предмет \"{item.Name}\" додано до рюкзака");
            };

            try
            {
                backpack.AddItem(new Item("Книга", 1));
                backpack.AddItem(new Item("Флешка", 0.5));
                backpack.AddItem(new Item("Ноутбук", 2));
                backpack.AddItem(new Item("Вода", 1));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; }

        public Item(string name, double volume)
        {
            Name = name;
            Volume = volume;
        }
    }

    // Клас, що представляє рюкзак
    class Backpack
    {
        private List<Item> contents;
        private double maxVolume;

        public string Color { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }

        public event EventHandler<Item> ItemAdded;

        public Backpack(string color, string brand, string material, double weight, double volume, double maxVolume)
        {
            Color = color;
            Brand = brand;
            Material = material;
            Weight = weight;
            Volume = volume;
            this.maxVolume = maxVolume;
            contents = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (Volume + item.Volume > maxVolume)
            {
                throw new InvalidOperationException("Рюкзак переповнений");
            }

            contents.Add(item);
            Volume += item.Volume;
            OnItemAdded(item);
        }

        protected virtual void OnItemAdded(Item item)
        {
            ItemAdded?.Invoke(this, item);
        }
    }
}