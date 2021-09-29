using System.Collections;
using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public class Double : IEnumerable<double>
    {
        public IEnumerator<double> GetEnumerator()
        {
            ulong i = 0;
            do
            {
                yield return Convert.BinaryDoubleFromULong(i);
            }
            while (unchecked(++i) != 0); // finish on overflow
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
