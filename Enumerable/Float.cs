using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public class Float : IEnumerable<float>
    {
        public IEnumerator<float> GetEnumerator()
        {
            uint i = 0;
            do
            {
                yield return Convert.BinaryFloatFromUInt(i);
            }
            while (unchecked(++i) != 0); // finish on overflow
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
