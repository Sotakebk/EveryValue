using EveryValue.Enumerable;
using System.Collections.Generic;

/* This is epic syntactic sugar.
 * Is this needed? No.
 * Is this epic? Yes!
 * Is this useless? Pretty much.
 */

namespace EveryValue
{
    public static class Every
    {
        public static IEnumerable<float> Float => new Float();
        public static IEnumerable<double> Double => new Double();
        public static IEnumerable<byte> UnsignedByte => new UnsignedByte();
        public static IEnumerable<sbyte> SignedByte => new SignedByte();
        public static IEnumerable<ushort> UnsignedShort => new UnsignedShort();
        public static IEnumerable<short> SignedShort => new SignedShort();
        public static IEnumerable<uint> UnsignedInt => new UnsignedInt();
        public static IEnumerable<int> SignedInt => new SignedInt();
        public static IEnumerable<ulong> UnsignedLong => new UnsignedLong();
        public static IEnumerable<long> SignedLong => new SignedLong();
    }
}
