namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri uri) => uri.ToString().StartsWith("https://");

    public static int WordCount(this string str) => str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
}
