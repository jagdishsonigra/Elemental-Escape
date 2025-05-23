package collection;

public class InventoryHashTable {
    private String[] keys;
    private Object[] values;
    private int capacity;
    private int size;

    public InventoryHashTable(int capacity) {
        this.capacity = capacity;
        this.keys = new String[capacity];
        this.values = new Object[capacity];
        this.size = 0;
    }

    private int hash(String key) {
        return (key.hashCode() & 0x7fffffff) % capacity;
    }

    public void put(String key, Object value) {
        int index = hash(key);
        while (keys[index] != null) {
            if (keys[index].equals(key)) {
                values[index] = value;
                return;
            }
            index = (index + 1) % capacity;
        }
        keys[index] = key;
        values[index] = value;
        size++;
    }

    public Object get(String key) {
        int index = hash(key);
        while (keys[index] != null) {
            if (keys[index].equals(key)) {
                return values[index];
            }
            index = (index + 1) % capacity;
        }
        return null;
    }

    public boolean containsKey(String key) {
        return get(key) != null;
    }

    public int size() {
        return size;
    }

    public void clear() {
        for (int i = 0; i < capacity; i++) {
            keys[i] = null;
            values[i] = null;
        }
        size = 0;
    }
}