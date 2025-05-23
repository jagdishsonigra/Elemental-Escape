package collection;

import java.util.*;

public class MoleculeGraph {
    private Map<String, List<String>> graph = new HashMap<>();
    private boolean isMethane;

    public void addAtom(String atom) {
        graph.putIfAbsent(atom, new ArrayList<>());
    }

    public void connect(String a, String b) {
        graph.get(a).add(b);
        graph.get(b).add(a);
    }

    public void validateCH4() {
        isMethane = false;
        if (!graph.containsKey("C")) return;

        List<String> connections = graph.get("C");
        if (connections.size() != 4) return;

        boolean allHydrogens = connections.stream().allMatch(atom -> "H".equals(atom));
        isMethane = allHydrogens;
    }

    public boolean isValidMethane() {
        return isMethane;
    }
}