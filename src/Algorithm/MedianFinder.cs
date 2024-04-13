namespace Belly.Algorithm
{


    public class MedianFinder
    {
        private readonly PriorityQueue<int, int> bigRootHeap;

        private readonly PriorityQueue<int, int> smallRootHeap;

        public MedianFinder()
        {
            this.bigRootHeap = new(Comparer<int>.Create((int x, int y) => y - x));
            this.smallRootHeap = new(Comparer<int>.Default);
        }

        public void AddNum(int num)
        {
            if (this.bigRootHeap.Count <= 0 || num <= this.bigRootHeap.Peek())
            {
                this.bigRootHeap.Enqueue(num, num);
                if (this.smallRootHeap.Count + 1 < this.bigRootHeap.Count)
                {
                    int biggerTopNumber = this.bigRootHeap.Dequeue();
                    this.smallRootHeap.Enqueue(biggerTopNumber, biggerTopNumber);
                }
            }
            else
            {
                this.smallRootHeap.Enqueue(num, num);
                if (this.smallRootHeap.Count > this.bigRootHeap.Count)
                {
                    int smallerTopNumber = this.smallRootHeap.Dequeue();
                    this.bigRootHeap.Enqueue(smallerTopNumber, smallerTopNumber);
                }
            }
        }

        public double FindMedian()
        {
            if (this.bigRootHeap.Count > this.smallRootHeap.Count)
            {
                return this.bigRootHeap.Peek();
            }

            return (this.smallRootHeap.Peek() + this.bigRootHeap.Peek()) / 2d;
        }
    }
}