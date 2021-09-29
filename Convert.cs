namespace EveryValue
{
    public static class Convert
    {
        public static unsafe float BinaryFloatFromUInt(in uint value)
        {
            uint val = value;
            return *(float*)&val;
        }

        public static unsafe double BinaryDoubleFromULong(in ulong value)
        {
            ulong val = value;
            return *(double*)&val;
        }
    }
}
