namespace Belly.Algorithm;

public class RomanToInteger
{
    public int Process(string s)
    {
        if (s == null || s.Trim().Length <= 0)
        {
            return 0;
        }
        int answer = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int current = this.GetValue(s[i]);
            int next = i + 1 < s.Length ? this.GetValue(s[i + 1]) : 0;
            if (current >= next)
            {
                answer += current;
            }
            else
            {
                answer += next - current;
                i++;
            }
        }

        return answer;
    }

    private int GetValue(char c)
    {
        int answer = 0;
        switch (c)
        {
            case 'I':
                answer = 1;
                break;
            case 'V':
                answer = 5;
                break;
            case 'X':
                answer = 10;
                break;
            case 'L':
                answer = 50;
                break;
            case 'C':
                answer = 100;
                break;
            case 'D':
                answer = 500;
                break;
            case 'M':
                answer = 1000;
                break;
            default: break;
        }

        return answer;
    }
}