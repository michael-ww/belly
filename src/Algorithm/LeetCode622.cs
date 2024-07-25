namespace Belly.Algorithm
{
    public class MyCircularQueue
    {
        private int[] queue;
        private int leftIndex;
        private int rightIndex;
        private int size;
        private int limit;

        public MyCircularQueue(int k)
        {
            this.queue = new int[k];
            this.leftIndex = 0;
            this.rightIndex = 0;
            this.size = 0;
            this.limit = k;
        }

        public bool Enqueue(int value)
        {
            if (this.IsFull())
            {
                return false;
            }
            else
            {
                this.queue[rightIndex] = value;
                this.rightIndex = this.rightIndex == this.limit - 1 ? 0 : (this.rightIndex + 1);
                this.size++;
                return true;
            }
        }

        public bool Dequeue()
        {
            if (this.IsEmpty())
            {
                return false;
            }
            else
            {
                int pivot = this.queue[this.leftIndex];
                leftIndex = leftIndex == this.limit - 1 ? 0 : leftIndex++;
                this.size--;
                return true;

            }
        }

        public int Front()
        {
            if (this.IsEmpty())
            {
                return -1;
            }
            else
            {
                return this.queue[this.leftIndex];
            }
        }

        public int Rear()
        {
            if (this.IsEmpty())
            {
                return -1;
            }
            else
            {
                int last = this.rightIndex == 0 ? (this.limit - 1) : (this.rightIndex - 1);
                return this.queue[last];
            }
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public bool IsFull()
        {
            return this.size == this.limit;
        }
    }
}