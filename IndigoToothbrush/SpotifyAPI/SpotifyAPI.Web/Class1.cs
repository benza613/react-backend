namespace SpotifyAPI
{
    public class Class1
    {

    }

    public static class StringLibrary
    {
        public static bool StartsUpper(this string? str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }

        public static int AmplifyValue(int data)
        {
            return data * 120;
        }
    }
}