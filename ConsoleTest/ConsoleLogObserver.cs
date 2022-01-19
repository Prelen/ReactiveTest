using System;

namespace ConsoleTest
{
    internal class ConsoleLogObserver : IObserver<int>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.ToString());
        }

        public void OnNext(int value)
        {
            Console.WriteLine(value);
        }
    }
}
