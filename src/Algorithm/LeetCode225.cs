namespace Belly.Algorithm
{
    public class LeetCode225<T>
    {
        private readonly Queue<T> queue;

        public LeetCode225()
        {
            this.queue = new();
        }
        public void Push(T x)
        {
            this.queue.Enqueue(x);
            for (int i = 0; i < this.queue.Count - 1; i++)
            {
                this.queue.Enqueue(this.queue.Dequeue());
            }
        }

        public T Pop()
        {
            return this.queue.Dequeue();
        }

        public T Top()
        {
            return this.queue.Peek();
        }

        public bool IsEmpty()
        {
            return this.queue.Count <= 0;
        }
    }
}