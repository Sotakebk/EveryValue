using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public class UnsignedInt : IEnumerable<uint>
    {
        public IEnumerator<uint> GetEnumerator()
        {
            uint i = 0;
            do
            {
                yield return i;
            }
            while (unchecked(++i) != 0); // finish on overflow
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
