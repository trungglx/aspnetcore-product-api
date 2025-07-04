namespace ProductApi.Data;

public class GuideItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int TypeId { get; set; } // Added property to fix CS1061 for 'TypeId'  
    public int Level { get; set; } // Added property to fix CS1061 for 'Level'  
    public string? Options { get; set; } // Added property to fix CS1061 for 'Options'  
    public string? ImageUrl { get; set; } // Added property to fix CS1061 for 'ImageUrl'  
}
