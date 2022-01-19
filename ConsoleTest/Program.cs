using System;


namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //EvenNumberObservable evenObserver = new();
            //ConsoleLogObserver consoleObserver = new();
            //evenObserver.Subscribe(consoleObserver);

            EvenNumberSubject subject = new();
            subject.Subscribe(Console.WriteLine);
            subject.Run();

            Console.WriteLine("Completed");
            Console.ReadKey();

        }

     
    }
}
