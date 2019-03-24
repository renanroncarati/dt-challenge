using System.Globalization;

namespace DTChallenge.Ui
{
    public static class Cultures
    {
        private static readonly CultureInfo Canada =
            CultureInfo.GetCultureInfo("en-CA");

        public static NumberFormatInfo GetCanadaCurrency()
        {
            var canada = (NumberFormatInfo)Canada.NumberFormat.Clone();
            canada.CurrencySymbol = "CAD$";

            return canada;
        }
    }
}
