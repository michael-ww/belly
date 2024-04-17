namespace Belly.Algorithm
{

    public class RdmListNode
    {
        public int Value { get; }

        public RdmListNode Next { get; set; }

        public RdmListNode Random { get; set; }

        public RdmListNode(int value = 0)
        {
            this.Value = value;
        }
    }
}