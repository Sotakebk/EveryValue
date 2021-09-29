using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public class UnsignedShort : IEnumerable<ushort>
    {
        public IEnumerator<ushort> GetEnumerator()
        {
            ushort i = 0;
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
