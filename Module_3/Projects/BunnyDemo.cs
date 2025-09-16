// BunnyDemo.cs
using System;

namespace Module3Demo
{
    public class Bunny
    {
        public string Name { get; set; }
        public bool LikesCarrots { get; set; }
        public bool LikesHumans { get; set; }

        public Bunny() { }
        public Bunny(string n) { Name = n; }

        public void Describe()
        {
            Console.WriteLine($"{Name} - Carrots: {LikesCarrots}, Humans: {LikesHumans}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Object initializer
            Bunny b1 = new Bunny { Name = "Timmy", LikesCarrots = true, LikesHumans = false };

            // Constructor + initializer
            Bunny b2 = new Bunny("Jimmy") { LikesCarrots = false, LikesHumans = true };

            b1.Describe();
            b2.Describe();
        }
    }
}
