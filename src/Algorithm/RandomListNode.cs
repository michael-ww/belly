namespace Belly.Algorithm
{

    public class RandomListNode
    {
        public int Value { get; }

        public RandomListNode Next { get; set; }

        public RandomListNode Random { get; set; }

        public RandomListNode(int value = 0)
        {
            this.Value = value;
        }
    }
}