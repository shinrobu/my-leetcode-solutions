//Runtime: 72ms
//Memory: 39.4 MB

/*Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. 
The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. 
Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. 

There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer. */

public class Solution {
    public int RomanToInt(string s) {
        char[] numerals = s.ToCharArray(0, s.Length);
            int[] romanValues = new int[s.Length];
            int translated = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (numerals[i])
                {
                    case 'I':
                        romanValues[i] = 1;
                        break;
                    case 'V':
                        romanValues[i] = 5;
                        break;
                    case 'X':
                        romanValues[i] = 10;
                        break;
                    case 'L':
                        romanValues[i] = 50;
                        break;
                    case 'C':
                        romanValues[i] = 100;
                        break;
                    case 'D':
                        romanValues[i] = 500;
                        break;
                    case 'M':
                        romanValues[i] = 1000;
                        break;
                    default:
                        romanValues[i] = 0;
                        break;
                }
            }
            translated = Calculations(romanValues, numerals);
            return translated;
    }
    
     public static int Calculations(int[] numerals, char[] romans)
        {
            int total = 0, temp = 0;
            for (int i = 0; i < numerals.Length; i++)
            {
                if ((i + 1 < numerals.Length))
                {
                    if (SpecialCases(romans[i], romans[i + 1]))
                    {
                        temp = numerals[i + 1] - numerals[i];
                        total += temp;
                        if (i + 2 >= numerals.Length)
                            break;
                        else
                            i = i + 1;
                    }
                    else
                    {
                        temp = 0;
                        total += numerals[i];
                    }
                }
                else 
                    total += numerals[i];
            }
            return total;
        }

        public static bool SpecialCases(char roman1, char roman2)
        {
            if (roman1 == 'I' && (roman2 == 'V' || roman2 == 'X'))
                return true;
            else if (roman1 == 'X' && (roman2 == 'L' || roman2 == 'C'))
                return true;
            else if (roman1 == 'C' && (roman2 == 'D' || roman2 == 'M'))
                return true;
            return false;
        }
}
