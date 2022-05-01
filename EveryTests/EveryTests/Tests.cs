using EveryValue;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace EveryTests
{
    public class Tests
    {
        private IEnumerable<T> GetEnumerableFromGenericType<T>(T arg)
        {
            return arg switch
            {
                byte => (IEnumerable<T>)Every.UnsignedByte,
                sbyte => (IEnumerable<T>)Every.SignedByte,
                ushort => (IEnumerable<T>)Every.UnsignedShort,
                short => (IEnumerable<T>)Every.SignedShort,
                uint => (IEnumerable<T>)Every.UnsignedInt,
                int => (IEnumerable<T>)Every.SignedInt,
                ulong => (IEnumerable<T>)Every.UnsignedLong,
                long => (IEnumerable<T>)Every.SignedLong,
                _ => null
            };
        }

        [Test]
        [TestCase(sbyte.MinValue, 8)]
        [TestCase(byte.MinValue, 8)]
        [TestCase(ushort.MinValue, 16)]
        [TestCase(short.MinValue, 16)]
        public void TestAllValues<T>(T instance, int bitCount)
        {
            var incrementCounter = new Dictionary<T, byte>();

            var enumerable = GetEnumerableFromGenericType(instance);

            foreach (var val in enumerable)
            {
                if (incrementCounter.ContainsKey(val))
                    incrementCounter[val]++;
                else
                    incrementCounter.Add(val, 1);
            }

            var combinations = 1 << bitCount;

            Assert.AreEqual(combinations, incrementCounter.Count);

            Assert.IsTrue(incrementCounter.All((p) => p.Value.Equals(1)));
        }
    }
}
