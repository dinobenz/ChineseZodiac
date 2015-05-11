using System;

namespace Dinobenz.ChineseZodiac
{
    public static class ChineseZodiacExtension
    {
        static string[] th_animals = new string[] { "ชวด	", "ฉลู", "ขาล", "เถาะ", "มะโรง", "มะเส็ง", "มะเมีย", "มะแม", "วอก", "ระกา", "จอ", "กุน" };

        public static string ToChineseZodiac(this DateTime date)
        {
            var offset = 4;
            var n = (date.Year - offset) % 12;
            return th_animals[n];
        }
    }
}
