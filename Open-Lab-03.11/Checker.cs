using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            if (str.Length <= 1)
                return true;
            else
            {
                if (str[0] != str[str.Length - 1])
                    return false;
                else
                    return IsPalindrome(str.Substring(1, str.Length - 2));
            }
        }
    }
}
