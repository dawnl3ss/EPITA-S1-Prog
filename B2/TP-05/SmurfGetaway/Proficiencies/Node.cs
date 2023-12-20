namespace SmurfGetaway.Proficiencies;

public class Node
{
    public int X { get; }
    public int Y { get; }

    public bool Walkable;

    public int GCost;
    public int HCost;
    public int FCost => GCost + HCost;

    public Node? Parent;

    public Node(int x, int y, bool walkable)
    {
        X = x;
        Y = y;
        
        GCost = int.MaxValue;
        HCost = 0;
        Parent = null;
        Walkable = walkable;
    }

    public bool Same(Node? node)
    {
        if (node is null)
            return false;
        return X == node.X && Y == node.Y;
    }
}