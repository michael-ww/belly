namespace Algorithm
{
    using System.Collections.Generic;

    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s == null || s.Trim().Length < 2)
            {
                return false;
            }

            Stack<char> parentheses = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    parentheses.Push(s[i]);
                }
                else
                {
                    if (parentheses.Count <= 0)
                    {
                        return false;
                    }
                    else if (s[i] == ')' && parentheses.Pop() != '(')
                    {
                        return false;
                    }
                    else if (s[i] == ']' && parentheses.Pop() != '[')
                    {
                        return false;
                    }
                    else if (s[i] == '}' && parentheses.Pop() != '{')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}