using Microsoft.EntityFrameworkCore;

public class ItemGuideContext : DbContext
{
    public ItemGuideContext(DbContextOptions<ItemGuideContext> options) : base(options)
    {
    }

    public DbSet<ItemType> ItemTypes { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemOption> ItemOptions { get; set; }
}

public class ItemType
{
    public int    Id          { get; set; }
    public string Name        { get; set; } = default!;
    public string? Description{ get; set; }
    public ICollection<Item>  Items { get; set; } = new List<Item>();
}

public class Item
{
    public int    Id          { get; set; }
    public string Name        { get; set; } = default!;
    public int    TypeId      { get; set; }
    public int    Level       { get; set; }
    public string? Options    { get; set; }
    public string? ImageUrl   { get; set; }
    public string? Description{ get; set; }

    public ItemType Type { get; set; } = default!;
    public ICollection<ItemOption> ItemOptions { get; set; } = new List<ItemOption>();
}

public class ItemOption
{
    public int    Id          { get; set; }
    public int    ItemId      { get; set; }
    public string Name        { get; set; } = default!;
    public string? Value      { get; set; }
    public bool   IsExcellent { get; set; }

    public Item Item { get; set; } = default!;
}
