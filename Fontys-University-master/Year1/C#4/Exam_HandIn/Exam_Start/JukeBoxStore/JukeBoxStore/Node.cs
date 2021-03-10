namespace JukeBoxStore
{
    public  class Node
    {
        private Song theItem; //the item it refers to
        private Node next;    // the next node it refers to; null if there does not exist a next node

        public Node(Song aItem)
        {
            this.theItem = aItem;
            this.next = null;
        }

        public Song getItem() { return this.theItem; }

        public Node getNext() { return this.next; }
        public void setNext(Node n) { this.next = n; }
    }
}