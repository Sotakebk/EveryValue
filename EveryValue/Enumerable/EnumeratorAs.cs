using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    public static class EnumeratorAs
    {
        public static IEnumerator<T> EnumeratorBitwise<T, V>(IEnumerator<V> enumerator)
            where T : unmanaged
            where V : unmanaged
        {
            while (enumerator.MoveNext())
            {
                var value = enumerator.Current;
                yield return ConvertBitwise<T, V>(value);
            }
        }

        public static unsafe T ConvertBitwise<T, V>(V value)
            where T : unmanaged
            where V : unmanaged
        {
            return *(T*)&value;
        }
    }
}
