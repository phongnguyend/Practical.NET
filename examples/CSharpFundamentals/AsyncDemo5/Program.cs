using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncDemo5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("1. Start!");

            Coffee cup = PourCoffee();
            Console.WriteLine("3. coffee is ready");

            Task<Egg> eggsTask = FryEggs(2);
            Task<Bacon> baconTask = FryBacon(3);

            var tasks = new List<Task> { eggsTask, baconTask };

            while (tasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(tasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("8. eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("14. bacon is ready");
                }
                tasks.Remove(finishedTask);
            }

            //Task finishedTask = await Task.WhenAny(tasks);

            Toast toast = await ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("20. toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("22. oj is ready");
            Console.WriteLine("Breakfast is ready!");

            Console.WriteLine("23. End!");

            Console.ReadLine();
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("21. Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("19. Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("18. Putting butter on the toast");

        private async static Task<Toast> ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"15.{slice + 1} .Putting a slice of bread in the toaster");
            }
            Console.WriteLine("16. Start toasting...");
            await FakeIOOperationAsync(3000);
            Console.WriteLine("17. Remove toast from toaster");

            return new Toast();
        }

        private async static Task<Bacon> FryBacon(int slices)
        {
            Console.WriteLine($"9. putting {slices} slices of bacon in the pan");
            Console.WriteLine("10. cooking first side of bacon...");
            await FakeIOOperationAsync(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"11.{slice + 1}. flipping a slice of bacon");
            }
            Console.WriteLine("12. cooking the second side of bacon...");
            await FakeIOOperationAsync(3000);
            Console.WriteLine("13. Put bacon on plate");

            return new Bacon();
        }

        private async static Task<Egg> FryEggs(int howMany)
        {
            Console.WriteLine("4. Warming the egg pan...");
            await FakeIOOperationAsync(3000);
            Console.WriteLine($"5. cracking {howMany} eggs");
            Console.WriteLine("6. cooking the eggs ...");
            await FakeIOOperationAsync(3000);
            Console.WriteLine("7. Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("2. Pouring coffee");
            return new Coffee();
        }

        private static Task FakeIOOperationAsync(int milliseconds)
        {
            return Task.Delay(milliseconds);
        }
    }
}
