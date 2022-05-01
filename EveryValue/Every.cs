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
        public static IEnumerable<float> Float
        {
            get
            {
                return new EnumerableCapsule<float>(
                    source: () => EnumeratorAs.EnumeratorBitwise<float, uint>(BaseEnumerators.GetFourByteEnumerator())
                    );
            }
        }

        public static IEnumerable<double> Double
        {
            get
            {
                return new EnumerableCapsule<double>(
                    source: () => EnumeratorAs.EnumeratorBitwise<double, ulong>(BaseEnumerators.GetEightByteEnumerator())
                    );
            }
        }

        public static IEnumerable<byte> UnsignedByte
        {
            get
            {
                return new EnumerableCapsule<byte>(
                    source: () => BaseEnumerators.GetOneByteEnumerator()
                    );
            }
        }

        public static IEnumerable<sbyte> SignedByte
        {
            get
            {
                return new EnumerableCapsule<sbyte>(
                    source: () => EnumeratorAs.EnumeratorBitwise<sbyte, byte>(BaseEnumerators.GetOneByteEnumerator())
                    );
            }
        }

        public static IEnumerable<ushort> UnsignedShort
        {
            get
            {
                return new EnumerableCapsule<ushort>(
                    source: () => BaseEnumerators.GetTwoByteEnumerator()
                    );
            }
        }

        public static IEnumerable<short> SignedShort
        {
            get
            {
                return new EnumerableCapsule<short>(
                    source: () => EnumeratorAs.EnumeratorBitwise<short, ushort>(BaseEnumerators.GetTwoByteEnumerator())
                    );
            }
        }

        public static IEnumerable<uint> UnsignedInt
        {
            get
            {
                return new EnumerableCapsule<uint>(
                    source: () => BaseEnumerators.GetFourByteEnumerator()
                    );
            }
        }

        public static IEnumerable<int> SignedInt
        {
            get
            {
                return new EnumerableCapsule<int>(
                    source: () => EnumeratorAs.EnumeratorBitwise<int, uint>(BaseEnumerators.GetFourByteEnumerator())
                    );
            }
        }

        public static IEnumerable<ulong> UnsignedLong
        {
            get
            {
                return new EnumerableCapsule<ulong>(
                    source: () => BaseEnumerators.GetEightByteEnumerator()
                    );
            }
        }

        public static IEnumerable<long> SignedLong
        {
            get
            {
                return new EnumerableCapsule<long>(
                    source: () => EnumeratorAs.EnumeratorBitwise<long, ulong>(BaseEnumerators.GetEightByteEnumerator())
                    );
            }
        }
    }
}
