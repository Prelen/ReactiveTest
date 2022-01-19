using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;

namespace ConsoleTest
{
    internal class EvenNumberSubject : IDisposable
    {
        private readonly Subject<int> subject = new();
        private readonly List<IDisposable> disposables = new();
        public void Run()
        {
            Enumerable.Range(1, 100).Where(x => x % 2 == 0)
               .ToList()
               .ForEach(x => {
                   subject.OnNext(x);
               });
        }

        public void Subscribe(Action<int> action)
        {
            disposables.Add(subject?.Subscribe(action));
        }
        public void Dispose()
        {
            subject?.Dispose();
            disposables.ForEach(d => {
                d?.Dispose();
            });
        }
    }
}
