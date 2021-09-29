using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public class UnsignedByte : IEnumerable<byte>
    {
        public IEnumerator<byte> GetEnumerator()
        {
            byte i = 0;
            do
            {
                yield return i;
            } while (unchecked(++i) != 0);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
