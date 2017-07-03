using System;
using Humanizer;

namespace Umbraco7Demo.Core
{
    public static class CurrencyHelper
    {
        public static string AmountToText(Double amount)
        {
            var formatText = String.Empty;


            int wholeNumber = (int)Math.Floor(amount);
            int decimalNumber = (int)(Math.Round(amount - Math.Truncate(amount), 2) * 100);

            if (decimalNumber > 0)
            {
                formatText = $"{wholeNumber.ToWords()} dollars and {decimalNumber.ToWords()} cents";
            }
            else
            {
                formatText = $"{wholeNumber.ToWords()} dollars";
            }

            return formatText;
        }
    }
}
