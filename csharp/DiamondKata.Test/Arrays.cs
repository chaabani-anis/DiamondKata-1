using System.Collections.Generic;

public static class Arrays
{
    public static IList<T> AsList<T>(params T[] source)
    {
        return source;
    }
}