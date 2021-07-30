namespace DataStructureAlgorithm.Leetcode
{
    //622. Design Circular Queue
    //https://leetcode.com/problems/design-circular-queue/
    public class DesignCircularQueue
    {
        System.Collections.Queue myq=new System.Collections.Queue();
        
    }
    public class MyCircularQueue
    {
        public int[] queue;
        public int front;
        public int count;
        public int capacity;
        public MyCircularQueue(int k)
        {
            queue = new int[k];
            front = 0;
            count = 0;
            capacity = k;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }
            int newIndex = (front + count) % capacity;
            queue[newIndex] = value;
            count = count + 1;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            front = (front + 1) % capacity;
            count = count - 1;
            return true;
        }

        public int Front()
        {
            if (count == 0)
            {
                return -1;
            }
            return queue[front];
        }

        public int Rear()
        {
            if (count == -0)
            {
                return -1;
            }
            int tailIndex = (front + count - 1) % capacity;
            return queue[tailIndex];
        }

        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsFull()
        {
            if (count == capacity)
            {
                return true;
            }
            return false;
        }
    }
}