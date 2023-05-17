namespace PriorityQueue
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //await UseNormalQueue();
            await UsePriorityQueue();
            Console.Read();
        }

        private static async Task UseNormalQueue()
        {
            var queue1 = new Queue<string>();
            var queue2 = new Queue<string>();
            var queue3 = new Queue<string>();

            queue1.Enqueue("1.1");
            queue1.Enqueue("1.2");
            queue1.Enqueue("1.3");

            queue2.Enqueue("2.1");
            queue2.Enqueue("2.2");
            queue2.Enqueue("2.3");

            queue3.Enqueue("3.1");
            queue3.Enqueue("3.2");
            queue3.Enqueue("3.3");

            while (true)
            {
                await Task.Delay(1000);

                if (queue1.Count > 0)
                {
                    Console.WriteLine(queue1.Dequeue());
                    continue;
                }

                if (queue2.Count > 0)
                {
                    Console.WriteLine(queue2.Dequeue());
                    continue;
                }

                if (queue3.Count > 0)
                {
                    Console.WriteLine(queue3.Dequeue());
                    continue;
                }
            }
        }

        private static async Task UsePriorityQueue()
        {
            var queue = new PriorityQueue<string, int>();

            queue.Enqueue("1.1", 1);
            queue.Enqueue("1.2", 1);
            queue.Enqueue("1.3", 1);

            queue.Enqueue("2.1", 2);
            queue.Enqueue("2.2", 2);
            queue.Enqueue("2.3", 2);

            queue.Enqueue("3.1", 3);
            queue.Enqueue("3.2", 3);
            queue.Enqueue("3.3", 3);

            while (true)
            {
                await Task.Delay(1000);

                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Dequeue());
                    continue;
                }
            }
        }
    }
}