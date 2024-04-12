namespace Belly.Algorithm
{
    using System.Collections.Generic;

    public class LeetCode232<T>
    {
        private readonly Stack<T> inStack;
        private readonly Stack<T> outStack;


        public LeetCode232()
        {
            this.inStack = new();
            this.outStack = new();
        }

        public void Push(T x)
        {
            this.inStack.Push(x);

        }

        public T Pop()
        {
            if (this.outStack.Count <= 0)
            {
                while (this.inStack.Count > 0)
                {
                    this.outStack.Push(this.inStack.Pop());
                }
            }
            return this.outStack.Pop();
        }

        public T Peek()
        {
            if (this.outStack.Count <= 0)
            {
                while (this.inStack.Count > 0)
                {
                    this.outStack.Push(this.inStack.Pop());
                }
            }
            return this.inStack.Peek();
        }

        public bool Empty()
        {
            return this.inStack.Count <= 0 && this.outStack.Count <= 0;
        }
    }
}