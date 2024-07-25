namespace Belly.Algorithm
{
    public class FrequencyStack
    {
        private readonly Dictionary<int, Stack<int>> group;
        private readonly Dictionary<int, int> frequency;
        private int maxFrequency;

        public FrequencyStack()
        {
            this.group = new();
            this.frequency = new();
            this.maxFrequency = 0;
        }

        public void Push(int val)
        {
            if (!this.frequency.ContainsKey(val))
            {
                this.frequency.Add(val, 1);
            }
            if (!this.group.ContainsKey(this.frequency[val]))
            {
                this.group.Add(this.frequency[val], new Stack<int>());
            }
            this.group[this.frequency[val]].Push(val);
            this.maxFrequency = Math.Max(this.maxFrequency, this.frequency[val]);
        }

        public int Pop()
        {
            if (this.maxFrequency <= 0)
            {
                throw new InvalidOperationException();
            }

            int val = this.group[this.maxFrequency].Pop();
            if (this.group[this.maxFrequency].Count <= 0)
            {
                this.group.Remove(this.maxFrequency);
                this.maxFrequency--;
            }
            if (this.frequency[val] <= 1)
            {
                this.frequency.Remove(val);
            }
            else
            {
                this.frequency[val] -= 1;
            }
            return val;
        }
    }
}