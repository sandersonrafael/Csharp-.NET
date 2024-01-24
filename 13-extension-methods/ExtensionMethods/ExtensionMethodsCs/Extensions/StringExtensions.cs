namespace System;

public static class StringExtensions
{
    public static string Cut(this string thisStr, int cutLength)
    {
        return thisStr.Substring(0, cutLength) + (thisStr.Length > cutLength ? "..." : "");
    }
}
