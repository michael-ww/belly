namespace Belly.Algorithm
{
    public class LeetCode639
    {
        public int NumDecodings1(string s)
        {
            ArgumentException.ThrowIfNullOrEmpty(s);
            return this.NumDecodings(s, 0);
        }

        private int NumDecodings(string s, int index)
        {
            if (index >= s.Length)
            {
                return 0;
            }

            if (s[index] == '0')
            {
                return 0;
            }

            int answer = this.NumDecodings(s, index + 1) * (s[index] == '*' ? 9 : 1);
            if (index + 1 < s.Length)
            {
                if (s[index] == '*' && s[index + 1] == '*')
                {
                    answer += 15 * this.NumDecodings(s, index + 2);
                }
                else if (s[index] == '*' && s[index + 1] != '*')
                {
                    if (s[index + 1] <= 6)
                    {
                        answer += 2 * this.NumDecodings(s, index + 2);
                    }
                    else
                    {
                        answer += this.NumDecodings(s, index + 2);
                    }
                }
                else if (s[index] != '*' && s[index + 1] == '*')
                {
                    if (s[index] == '1')
                    {
                        answer += 9 * this.NumDecodings(s, index + 2);
                    }
                    else if (s[index] == '2')
                    {
                        answer += 6 * this.NumDecodings(s, index + 2);
                    }
                }
                else if (s[index] != '*' && s[index + 1] != '*')
                {
                    if (((s[index] - '0') * 10 + s[index + 1] - '0') <= 26)
                    {
                        answer += this.NumDecodings(s, index + 2);
                    }
                }
            }

            return answer % 1000000007;
        }

        public int NumDecodings2(string s)
        {
            ArgumentException.ThrowIfNullOrEmpty(s);
            int[] dp = new int[s.Length];
            Array.Fill(dp, -1);
            return this.NumDecodings(s, 0, dp);
        }

        private int NumDecodings(string s, int index, int[] dp)
        {
            if (index >= s.Length)
            {
                return 1;
            }
            if (s[index] == '0')
            {
                return 0;
            }
            if (dp[index] != -1)
            {
                return dp[index];
            }
            int answer = this.NumDecodings(s, index + 1, dp) * (s[index] == '*' ? 9 : 1);
            if (index + 1 < s.Length)
            {
                if (s[index] == '*' && s[index + 1] == '*')
                {
                    answer += 15 * this.NumDecodings(s, index + 2);
                }
                else if (s[index] == '*' && s[index + 1] != '*')
                {
                    if (s[index + 1] <= 6)
                    {
                        answer += 2 * this.NumDecodings(s, index + 2);
                    }
                }
                else if (s[index] != '*' && s[index + 1] == '*')
                {
                    if (s[index] == '1')
                    {
                        answer += 9 * this.NumDecodings(s, index + 2);
                    }
                    else if (s[index] == '2')
                    {
                        answer += 6 * this.NumDecodings(s, index + 2);
                    }
                }
                else
                {
                    if (((s[index] - '0') * 10 + (s[index + 1] - '0')) <= 26)
                    {
                        answer += this.NumDecodings(s, index + 2);
                    }
                }
            }
            answer %= 1000000007;
            dp[index] = answer;
            return answer;
        }

        public int NumDecodings3(string s)
        {
            ArgumentException.ThrowIfNullOrEmpty(s);
            long[] dp = new long[s.Length + 1];
            dp[s.Length] = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                dp[i] = dp[i + 1] * s[i] == '*' ? 9 : 1;
                if (i + 1 < s.Length)
                {
                    if (s[i] == '*' && s[i + 1] == '*')
                    {
                        dp[i] += 15 * dp[i + 2];
                    }
                    else if (s[i] == '*' && s[i + 1] != '*')
                    {
                        if (s[i + 1] <= 6)
                        {
                            dp[i] += 2 * dp[i + 2];
                        }
                    }
                    else if (s[i] != '*' && s[i + 1] == '*')
                    {
                        if (s[i] == '1')
                        {
                            dp[i] += 9 * dp[i + 2];
                        }
                        else if (s[i] == '2')
                        {
                            dp[i] += 6 * dp[i + 2];
                        }
                    }
                    else
                    {
                        if (((s[i] - '0') * 10 + (s[i + 1] - '0')) <= 26)
                        {
                            dp[i] += dp[i + 2];
                        }
                    }
                }
                dp[i] %= 1000000007;
            }

            return (int)dp[0];
        }

        public int NumDecodings4(string s)
        {
            ArgumentException.ThrowIfNullOrEmpty(s);
            long current = 0, next = 1, nnext = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                current = next * s[i] == '*' ? 9 : 1;
                if (i + 1 < s.Length)
                {
                    if (s[i] == '*' && s[i + 1] == '*')
                    {
                        current += 15 * nnext;
                    }
                    else if (s[i] == '*' && s[i + 1] != '*')
                    {
                        if (s[i + 1] <= 6)
                        {
                            current += 2 * nnext;
                        }
                    }
                    else if (s[i] != '*' && s[i + 1] == '*')
                    {
                        if (s[i] == '1')
                        {
                            current += 9 * nnext;
                        }
                        else if (s[i] == '2')
                        {
                            current += 6 * nnext;
                        }
                    }
                    else
                    {
                        if (((s[i] - '0') * 10 + (s[i + 1] - '0')) <= 26)
                        {
                            current += nnext;
                        }
                    }
                }
                current %= 1000000007;
                nnext = next;
                next = current;
            }

            return (int)next;
        }
    }
}