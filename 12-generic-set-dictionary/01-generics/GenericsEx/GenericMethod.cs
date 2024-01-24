namespace GenericsEx;

public class GenericMethod
{
    /* Generic Method */
    public static T ReturnSame<T>(T arg1)
    {
        return arg1;
    }

    /* Restriction */
    public static T ReturnGreater<T>(T arg1, T arg2) where T : IComparable
    {
        if (arg1.CompareTo(arg2) >= 0) return arg1;
        return arg2;
    }

    /* Another restriction possibility */

    // where T : struct
    // where T : class
    // where T : unmanaged
    // where T : new()
    // where T : <base type name>
    // where T : U
}
