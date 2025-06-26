namespace ProductApi.Models
{
    public class Category
    {
        public int Id { get; set; }               // Unique ID
        public string Name { get; set; }          // Category name
        public string Description { get; set; }   // Optional description
    }
}
