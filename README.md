# For each value of a numeric type
~~What are you even doing, why would you need this?~~ Understandably, you can loop over every possible float/int/ulong whatever:

    foreach (int f in Every.Float)
    {
        if (f == 1)
        {
            Console.WriteLine($"You just wasted so much time just to iterate over 1065353217 values of Single, congratulations!");
            break;
        }
    }
Patent pending...
