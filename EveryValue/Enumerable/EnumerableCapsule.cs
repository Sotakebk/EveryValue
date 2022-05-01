using System;
using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    internal class EnumerableCapsule<T> : IEnumerable<T>
    {
        private Func<IEnumerator<T>> source;

        public EnumerableCapsule(Func<IEnumerator<T>> source)
        {
            this.source = source;
        }

        public IEnumerator<T> GetEnumerator() => source();

        IEnumerator IEnumerable.GetEnumerator() => source();
    }
}
