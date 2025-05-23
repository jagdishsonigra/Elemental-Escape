package collection;

public class ElementTree {

    public static class Node {
        String element;
        Node left, right;

        public Node(String element) {
            this.element = element;
        }
    }

    private Node root;
    private boolean isCorrectCompound;

    public void setRoot(String element) {
        root = new Node(element);
    }

    public Node getRoot() {
        return root;
    }

    public Node insertLeft(Node parent, String element) {
        parent.left = new Node(element);
        return parent.left;
    }

    public Node insertRight(Node parent, String element) {
        parent.right = new Node(element);
        return parent.right;
    }

    private String getCompound(Node node) {
        if (node == null) return "";
        return getCompound(node.left) + node.element + getCompound(node.right);
    }

    public void validateCompound(String expected) {
        String compound = getCompound(root);
        isCorrectCompound = expected.equals(compound);
    }

    public boolean isCorrectCompound() {
        return isCorrectCompound;
    }
}