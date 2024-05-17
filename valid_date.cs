using System;
using System.Text.RegularExpressions;

namespace Valid 
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
            GetValidDate(input);
        }
        static void GetValidDate(string input)
        {
            string pattern = @"\b(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01])(\d{4})\b";

            MatchCollection Values = Regex.Matches(input, pattern);
            foreach (Match match in Values)
            {
                if (DateTime.TryParseExact(match.Value, "MMddyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    Console.WriteLine($" I got this date : {date.ToString("MM:dd:yyyy")}");
                }
            }
        }
    }
}
