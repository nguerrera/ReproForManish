public class MultiTargeted
{
    public static void AlwaysThere()
    {
    }

#if NETSTANDARD1_3
    public static void NetStandardOnly()
    {
    }
#endif
}
