using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public class SignedShort : IEnumerable<short>
    {
        public IEnumerator<short> GetEnumerator()
        {
            ushort i = 0;
            do
            {
                yield return unchecked((short)i);
            }
            while (unchecked(++i) != 0); // finish on overflow
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
