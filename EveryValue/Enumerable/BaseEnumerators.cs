using System.Collections.Generic;

namespace EveryValue.Enumerable
{
    internal static class BaseEnumerators
    {
        // 8 bit
        public static IEnumerator<byte> GetOneByteEnumerator()
        {
            byte i = 0;
            do
            {
                yield return i;
            }
            while (unchecked(++i) != 0);
        }

        // 16 bit
        public static IEnumerator<ushort> GetTwoByteEnumerator()
        {
            ushort i = 0;
            do
            {
                yield return i;
            }
            while (unchecked(++i) != 0);
        }

        // 32 bit
        public static IEnumerator<uint> GetFourByteEnumerator()
        {
            uint i = 0;
            do
            {
                yield return i;
            }
            while (unchecked(++i) != 0);
        }

        // 64 bit
        public static IEnumerator<ulong> GetEightByteEnumerator()
        {
            ulong i = 0;
            do
            {
                yield return i;
            }
            while (unchecked(++i) != 0);
        }
    }
}
