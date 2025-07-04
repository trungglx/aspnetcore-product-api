using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProductApi.Data;

namespace ProductApi.Data
{
    public class ItemGuideContextFactory : IDesignTimeDbContextFactory<ItemGuideContext>
    {
        public ItemGuideContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ItemGuideContext>();

            // Sửa lại chuỗi kết nối theo máy bạn:
            var connStr = "Server=(localdb)\\MSSQLLocalDB;Database=ItemGuide;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connStr);

            return new ItemGuideContext(optionsBuilder.Options);
        }
    }
}
