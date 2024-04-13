namespace Belly.Algorithm
{
    public class LeetCode295
    {
        private readonly PriorityQueue<int, int> minRootHeap;
        private readonly PriorityQueue<int, int> maxRootHeap;

        public LeetCode295()
        {
            this.minRootHeap = new(Comparer<int>.Default);
            this.maxRootHeap = new(Comparer<int>.Create((int x, int y) => y - x));
        }
        public void AddNum(int num)
        {
            if (this.maxRootHeap.Count <= 0)
            {
                this.maxRootHeap.Enqueue(num, num);
            }
            else
            {
                int maxHeapTop = this.maxRootHeap.Peek();
                if (num <= maxHeapTop)
                {
                    this.maxRootHeap.Enqueue(num, num);
                }
                else
                {
                    this.minRootHeap.Enqueue(num, num);
                }
            }
            if (this.maxRootHeap.Count - this.minRootHeap.Count >= 2)
            {
                int number = this.maxRootHeap.Dequeue();
                this.minRootHeap.Enqueue(number, number);
            }
            if (this.minRootHeap.Count - this.maxRootHeap.Count >= 2)
            {
                int number = this.minRootHeap.Dequeue();
                this.maxRootHeap.Enqueue(number, number);
            }
        }

        public double FindMedian()
        {
            if (this.maxRootHeap.Count <= 0 && this.minRootHeap.Count <= 0)
            {
                throw new InvalidOperationException("No Element");
            }
            if ((this.maxRootHeap.Count + this.minRootHeap.Count) % 2 == 0)
            {
                return (this.maxRootHeap.Dequeue() + this.minRootHeap.Dequeue()) / 2d;
            }
            else
            {
                return this.maxRootHeap.Count > this.minRootHeap.Count ? this.maxRootHeap.Dequeue() : this.minRootHeap.Dequeue();
            }
        }
    }
}