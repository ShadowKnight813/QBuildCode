// Models/TreeNode.cs
using System.Collections.Generic;

public class TreeNode
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string PartNumber { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public string Item { get; set; }
    public string Material { get; set; }
    public List<TreeNode> Children { get; set; }
}
