namespace StudentWiseClient
{
    public static class StringExtensions
    {
        public static string UppercaseFirst(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            return char.ToUpper(text[0]) + text.Substring(1);
        }
    }
}
