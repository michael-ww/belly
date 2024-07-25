namespace Belly.Algorithm
{
    public class MedianFinder
    {
        private readonly PriorityQueue<int, int> minHeap;
        private readonly PriorityQueue<int, int> maxHeap;

        public MedianFinder()
        {
            this.minHeap = new(Comparer<int>.Default);
            this.maxHeap = new(Comparer<int>.Create((int x, int y) => y - x));
        }
        public void AddNum(int num)
        {
            if (this.maxHeap.Count <= 0 || this.maxHeap.Peek() >= num)
            {
                this.maxHeap.Enqueue(num, num);
            }
            else
            {
                this.minHeap.Enqueue(num, num);
            }
            this.Balance();
        }

        public double FindMedian()
        {
            if (this.maxHeap.Count <= 0 && this.minHeap.Count <= 0)
            {
                throw new InvalidOperationException("No Element");
            }
            if (this.maxHeap.Count == this.minHeap.Count)
            {
                return (this.maxHeap.Peek() + this.minHeap.Peek()) / 2d;
            }
            else
            {
                return this.maxHeap.Count > this.minHeap.Count ? this.maxHeap.Peek() : this.minHeap.Peek();
            }
        }

        private void Balance()
        {
            while (Math.Abs(this.maxHeap.Count - this.minHeap.Count) >= 2)
            {
                if (this.maxHeap.Count > this.minHeap.Count)
                {
                    int num = this.maxHeap.Dequeue();
                    this.minHeap.Enqueue(num, num);
                }
                else
                {
                    int num = this.minHeap.Dequeue();
                    this.maxHeap.Enqueue(num, num);
                }
            }
        }
    }
}