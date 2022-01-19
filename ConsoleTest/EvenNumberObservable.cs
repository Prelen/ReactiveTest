using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Disposables;

namespace ConsoleTest
{
    internal class EvenNumberObservable : IObservable<int>
    {
        public IDisposable Subscribe(IObserver<int> observer)
        {
            Enumerable.Range(1, 100).Where(x => x % 2 == 0)
                .ToList()
                .ForEach(x => { 
                    observer.OnNext(x); 
                });

            return Disposable.Empty;
        }
    }
}
