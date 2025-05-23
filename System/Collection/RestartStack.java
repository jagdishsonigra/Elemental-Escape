package collection;

import java.util.Stack;

public class RestartStack {
    private Stack<String> checkpoints = new Stack<>();
    private boolean canUndo;

    public void pushCheckpoint(String state) {
        checkpoints.push(state);
        canUndo = true;
    }

    public String restartLevel() {
        if (!checkpoints.isEmpty()) {
            String state = checkpoints.pop();
            canUndo = !checkpoints.isEmpty();
            return state;
        }
        canUndo = false;
        return null;
    }

    public boolean canRestart() {
        return canUndo;
    }
}