// Client

// Create a tree structure

using CompositePattern.Structural;

var root = new Composite("root");
root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));

var comp1 = new Composite("Composite C1");
comp1.Add(new Leaf("Leaf C1-A"));
comp1.Add(new Leaf("Leaf C1-B"));

var comp2 = new Composite("Composite C2");
comp2.Add(new Leaf("Leaf C2-A"));
comp1.Add(comp2);

root.Add(comp1);
root.Add(new Leaf("Leaf C"));

root.PrimaryOperation(1);