using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_1
{
    class Zodiac
    {
        public static string[] zodiac = {"원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼",
"용", "뱀", "말", "양"};

        public static string GetZodiac(int BirthYear)
        {
            return zodiac[BirthYear % 12];
        }
    }
}
