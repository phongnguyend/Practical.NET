using System;
using System.Threading;

namespace AsyncDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start!");

            Coffee cup = PourCoffee();
            Console.WriteLine("3. coffee is ready");

            Egg eggs = FryEggs(2);
            Console.WriteLine("8. eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("14. bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("20. toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("22. oj is ready");
            Console.WriteLine("23. Breakfast is ready!");

            Console.WriteLine("24. End!");
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

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"15.{slice + 1} .Putting a slice of bread in the toaster");
            }
            Console.WriteLine("16. Start toasting...");
            FakeBlockingIOOperation(3000);
            Console.WriteLine("17. Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"9. putting {slices} slices of bacon in the pan");
            Console.WriteLine("10. cooking first side of bacon...");
            FakeBlockingIOOperation(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"11.{slice + 1}. flipping a slice of bacon");
            }
            Console.WriteLine("12. cooking the second side of bacon...");
            FakeBlockingIOOperation(3000);
            Console.WriteLine("13. Put bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("4. Warming the egg pan...");
            FakeBlockingIOOperation(3000);
            Console.WriteLine($"5. cracking {howMany} eggs");
            Console.WriteLine("6. cooking the eggs ...");
            FakeBlockingIOOperation(3000);
            Console.WriteLine("7. Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("2. Pouring coffee");
            return new Coffee();
        }

        private static void FakeBlockingIOOperation(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
    }
}
