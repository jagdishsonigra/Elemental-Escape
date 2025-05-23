package collection;

public class CO2LinkedList {

    private static class Node {
        String element;
        Node next;

        Node(String element) {
            this.element = element;
        }
    }

    private Node head;
    private int size;
    private boolean isValidCO2;

    public void addElement(String element) {
        Node newNode = new Node(element);
        if (head == null) {
            head = newNode;
        } else {
            Node ptr = head;
            while (ptr.next != null) {
                ptr = ptr.next;
            }
            ptr.next = newNode;
        }
        size++;
        validateCO2();
    }

    private void validateCO2() {
        isValidCO2 = false;
        if (size != 3) return;

        Node first = head;
        Node second = first.next;
        Node third = second.next;

        if ("O".equals(first.element) && "C".equals(second.element) && "O".equals(third.element)) {
            isValidCO2 = true;
        }
    }

    public boolean isCO2Formed() {
        return isValidCO2;
    }

    public void clear() {
        head = null;
        size = 0;
        isValidCO2 = false;
    }
}