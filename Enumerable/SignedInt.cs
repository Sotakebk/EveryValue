using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public class SignedInt : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            uint i = 0;
            do
            {
                yield return unchecked((int)i);
            }
            while (unchecked(++i) != 0); // finish on overflow
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
