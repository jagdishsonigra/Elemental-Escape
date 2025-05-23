package collection;

public class ExpressionTree {

    public static class Node {
        String value;
        Node left, right;

        public Node(String value) {
            this.value = value;
        }
    }

    private Node root;
    private boolean isValidH2SO4;

    public void setRoot(Node node) {
        this.root = node;
    }

    public Node getRoot() {
        return root;
    }

    public void validateH2SO4() {
        // Check if root is SO4 and has two H children
        if (root != null && "SO4".equals(root.value)) {
            boolean leftIsH = root.left != null && "H".equals(root.left.value);
            boolean rightIsH = root.right != null && "H".equals(root.right.value);
            isValidH2SO4 = leftIsH && rightIsH;
        } else {
            isValidH2SO4 = false;
        }
    }

    public boolean isValid() {
        return isValidH2SO4;
    }
}