namespace Algorithm
{
    using System.Collections.Generic;

    public class UnionFindSet<T>
    {
        public Dictionary<T,Element<T>> elementMap{ get; }

        public Dictionary<Element<T>,Element<T>> fatherMap{ get; }

        public Dictionary<Element<T>,int> sizeMap{ get; }
    }

    public class Element<T>
    {
        public T Value { get; }

        public Element(T value)
        {
            this.Value = value;
        }
    }
}