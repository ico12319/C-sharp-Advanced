namespace Application
{
    public class DoublyLinkedlist
    {
        private ListNode head;
        private ListNode tail;
        private int count;

        public int Count { get => count; }

        public DoublyLinkedlist()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void addFirst(int element)
        {
            ListNode newHead = new(element);
            if (head == null)
            {
                head = newHead;
                tail = newHead;
                count++;
                return;
            }

            head.Previous = newHead;
            newHead.Next = head;
            head = newHead;
            count++;
        }

        public void addLast(int element)
        {
            ListNode newTail = new(element);
            if(tail == null)
            {
                head = newTail;
                tail = newTail;
                count++;
                return;
            }

            tail.Next = newTail;
            newTail.Previous = tail;
            tail = newTail;
            count++;
        }

        public void forEach(Action<int> action)
        {
            ListNode curr = head;
            while (curr != null)
            {
                action(curr.Value);
                curr = curr.Next;
            }
        }

        public void removeFirst()
        {
            if (count != 0)
            {
                head = head.Next;
                if (head != null)
                {
                    head.Previous = null;
                }
                else
                {
                    tail = null;
                }
                count--;
            }
            return;
        }

        public void removeLast()
        {
            if(count != 0)
            {
                tail = tail.Previous;
                if(tail != null)
                {
                    tail.Next = null;
                }
                else
                {
                    head = null;
                }
                count--;
            }
            return;
        }
    }
}