package collection;

import java.util.LinkedList;
import java.util.Queue;

public class LevelQueue {
    private Queue<String> levelQueue = new LinkedList<>();
    private boolean hasMoreLevels;

    public void enqueueLevel(String level) {
        levelQueue.add(level);
        hasMoreLevels = true;
    }

    public String loadNextLevel() {
        String next = levelQueue.poll();
        hasMoreLevels = !levelQueue.isEmpty();
        return next;
    }

    public boolean hasNextLevel() {
        return hasMoreLevels;
    }
}