using System;

namespace HW3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vegetables[] salad = new Vegetables[6] { new Tomato(), new Cucumber(), new Garlic(), new Onion(), new Dill(), new Parsley() };
            double generalKcal = 0;
            Console.WriteLine("For the salad we need:");
            for (int i = 0; i < salad.Length; i++)
            {
                Console.WriteLine($"{i + 1}){salad[i].Name}");
            }

            Array.Sort(salad);
            Console.WriteLine("\nVegetables in ascending order of calories:");
            for (int i = 0; i < salad.Length; i++)
            {
                generalKcal += salad[i].KCal;
                Console.WriteLine($"{i + 1}){salad[i].Name} {salad[i].KCal} Kcal");
            }

            Console.WriteLine($"Total calorie content of the salad: {generalKcal} Kcal");
            Console.WriteLine("\nVegetables with a caloric value greater than 30");
            Vegetables[] vegetables = FindVegetables.KcalMoreNum(salad, 30);
            for (int i = 0; i < vegetables.Length; i++)
            {
                Console.WriteLine($"{i + 1}){vegetables[i].Name} {vegetables[i].KCal} Kcal");
            }

            Console.WriteLine("\nDo you know interesting facts about vegetables? ");
            for (int i = 0; i < salad.Length; i++)
            {
                Console.WriteLine($"{salad[i].Name}: {salad[i].Specialty}");
            }
        }
    }
}
