// File: BunnyShowcase.cs
// Simple showcase of Module 3 concepts using a Bunny class.

using System;

namespace Module3Demo
{
    public class Bunny
    {
        private int _age;
        public readonly string Name;

        public const int Eyes = 2;
        public static readonly int Ears = 2;

        // Each bunny has its own species
        public string Species { get; }

        public bool LikesCarrots { get; set; }
        public bool LikesHumans  { get; set; }

        public int Age
        {
            get { return _age; }
            private set { _age = value < 0 ? 0 : value; }
        }

        public string Mood
        {
            get { return LikesHumans ? "friendly" : "shy"; }
        }

        // Constructors
        public Bunny(string name, string species)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("name is required", nameof(name));
            if (string.IsNullOrWhiteSpace(species))
                throw new ArgumentException("species is required", nameof(species));

            Name = name;
            Species = species;
            Age = 0;
        }

        public Bunny(string name, string species, int age, bool likesCarrots = false, bool likesHumans = false)
            : this(name, species)
        {
            Age = age;
            LikesCarrots = likesCarrots;
            LikesHumans  = likesHumans;
        }

        public void Describe()
        {
            Console.WriteLine($"{Name} ({Species}) — age {Age}, eyes {Eyes}, ears {Ears}, mood {Mood}. " +
                              $"LikesCarrots={LikesCarrots}, LikesHumans={LikesHumans}");
        }

        // Method overloading demo
        public void Feed(int pellets)
        {
            Console.WriteLine($"{Name} ate {pellets} pellets.");
        }

        public void Feed(double grams)
        {
            Console.WriteLine($"{Name} ate {grams} grams.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Constant: {nameof(Bunny.Eyes)} = {Bunny.Eyes}");
            Console.WriteLine($"Static readonly: {nameof(Bunny.Ears)} = {Bunny.Ears}");
            Console.WriteLine();

            // Jimmy the Cottontail
            var b1 = new Bunny("Jimmy", "Cottontail")
            {
                LikesCarrots = true,
                LikesHumans  = false
            };
            b1.Describe();
            b1.Feed(10);
            b1.Feed(12.5);
            Console.WriteLine();

            // Timmy the Soviet Chinchilla
            var b2 = new Bunny("Timmy", "Soviet Chinchilla", age: 2, likesCarrots: false, likesHumans: true)
            {
                LikesCarrots = true
            };
            b2.Describe();
            b2.Feed(8);
            b2.Feed(20.3);
            Console.WriteLine();

            Console.WriteLine("Cube of 3 is " + Cube(3));
        }

        public static int Cube(int x)
        {
            return x * x * x;
        }
    }
}
