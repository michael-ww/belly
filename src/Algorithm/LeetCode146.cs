namespace Belly.Algorithm
{
    public class LRUCache
    {
        private readonly Dictionary<int, int> cache;

        private readonly LinkedList<int> visited;

        private int capacity;

        public LRUCache(int capacity)
        {
            this.cache = new Dictionary<int, int>(capacity);
            this.visited = new LinkedList<int>();
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (this.cache.TryGetValue(key, out int value))
            {
                this.visited.Remove(key);
                this.visited.AddFirst(key);
                return value;
            }
            else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            if (this.cache.ContainsKey(key))
            {
                this.visited.Remove(key);
                this.visited.AddFirst(key);
                this.cache[key] = value;
            }
            else
            {
                if (this.cache.Count >= capacity)
                {
                    this.visited.RemoveLast();
                    this.cache.Add(key, value);
                    this.visited.AddFirst(key);
                }
                else
                {
                    this.cache.Add(key, value);
                    this.visited.AddFirst(key);
                }
            }
        }
    }
}