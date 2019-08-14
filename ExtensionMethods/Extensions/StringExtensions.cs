namespace ExtensionMethods.Extensions
{
    public static class StringExtensions
    {
        public static double ToDouble(this string data)
        {
            double result = double.Parse(data);
            return result;
        }
    }
}
