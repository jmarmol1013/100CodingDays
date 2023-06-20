package Day001.ReverseLinkedList;

public class ListNode {
    private Node head;

    private static class Node {
        private int data;
        private Node next;

        public Node(int data) {
            this.data = data;
            this.next = null;
        }
    }

    public void insert(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
        } else {
            Node current = head;
            while (current.next != null) {
                current = current.next;
            }
            current.next = newNode;
        }
    }

    public void display() {
        Node current = head;
        while (current != null) {
            System.out.print(current.data + " ");
            current = current.next;
        }
        System.out.println();
    }

    // Solution    
    public void reverse(){
        Node walk = head;
        Node prev = null;
        Node next = null; 

        while(walk != null){
            next = walk.next;
            walk.next = prev;
            prev = walk;
            walk = next;
        }

        head = prev;
    }

    public static void main(String[] args){
        System.out.println("Exercise 1");
        ListNode list = new ListNode();
        list.insert(1);
        list.insert(2);
        list.insert(3);
        list.insert(4);
        list.insert(5);
        list.display();
        list.reverse();
        list.display();

        System.out.println("Exercise 2");
        ListNode list2 = new ListNode();
        list2.insert(1);
        list2.insert(2);
        list2.display();
        list2.reverse();
        list2.display();
    }
}