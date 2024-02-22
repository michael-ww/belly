namespace Algorithm;

public class MyAtoi
{
    public int Process(string s)
    {
        if (s == null || s.Trim().Length <= 0)
        {
            return 0;
        }

        s = s.Trim();
        bool negative = false;
        int unit = 1, answer = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(s[i]))
            {
                answer += (s[i] - '0') * unit;
                unit *= 10;
                negative = false;
            }
            else if (s[i] == '-')
            {
                negative = true;
            }
        }
        if (negative)
        {
            return answer * -1;
        }
        return answer;
    }
}