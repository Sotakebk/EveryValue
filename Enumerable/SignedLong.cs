using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public class SignedLong : IEnumerable<long>
    {
        public IEnumerator<long> GetEnumerator()
        {
            ulong i = 0;
            do
            {
                yield return unchecked((long)i);
            }
            while (unchecked(++i) != 0); // finish on overflow
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
