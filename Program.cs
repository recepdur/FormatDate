using System;
using System.Globalization;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] formats = { "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t", "T", "u", "U", "Y" };

            CultureInfo[] cultures = { CultureInfo.CreateSpecificCulture("tr-TR"), CultureInfo.CreateSpecificCulture("en-US") };

            DateTime dateToDisplay = new DateTime(2008, 10, 1, 17, 4, 32);

            foreach (string formatSpecifier in formats)
            {
                foreach (CultureInfo culture in cultures)
                {
                    Console.WriteLine("{0} Format Specifier {1, 10} Culture {2, 40}",
                                    formatSpecifier, culture.Name,
                                    dateToDisplay.ToString(formatSpecifier, culture));
                }
                Console.WriteLine();
            }
        }
    }
}
