using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public class SignedByte : IEnumerable<sbyte>
    {
        public IEnumerator<sbyte> GetEnumerator()
        {
            byte i = 0;
            do
            {
                yield return unchecked((sbyte)i);
            }
            while (unchecked(++i) != 0);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
