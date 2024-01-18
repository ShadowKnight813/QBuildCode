﻿// Models/BomModel.cs
public class BomModel
{
    public string PartNumber { get; set; }
    public string ComponentName { get; set; }
    public int Quantity { get; set; }
}

// Models/PartModel.cs
public class PartModel
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public string Item { get; set; }
    public string Material { get; set; }
}
