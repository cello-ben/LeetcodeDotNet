namespace LeetcodeDotNet.Problems
{
    internal class MyQueue
    {
        //TODO Implement testing
        private List<int> stack;
        public MyQueue()
        {
            stack = new List<int>();
        }

        public void Push(int x)
        {
            stack.Add(x);
        }

        public int Pop()
        {
            if (stack.Count > 0)
            {
                int elem = stack[0];
                stack.RemoveAt(0);
                return elem;
            }
            return -1;
        }

        public int Peek()
        {
            if (stack.Count > 0)
            {
                return stack[0];
            }
            return -1;
        }

        public bool Empty()
        {
            return stack.Count == 0;
        }

        public List<int> GetStack()
        {
            return this.stack;
        }
    }
}