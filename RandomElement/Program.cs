string[] snacks = { "hesburger", "kfc", "vaga mama", "mysushi", "mcdonalds", "healthy food" };

Random rnd = new Random();

int randomIndex  = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");