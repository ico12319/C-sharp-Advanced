namespace Application
{

    public class ListNode
    {
        private int value;
        private ListNode previous;
        private ListNode next;

        public int Value { get; set; }
        public ListNode Previous { get; set; }
        public ListNode Next { get; set; }


        public ListNode(int value)
        {
            this.Value = value;
            this.Previous = null;
            this.Next = null;
        }

        public override string ToString()
        {
            return $"{this.Previous?.Value} <- {this.Value} -> {this.Next?.Value}";
        }

    }

}