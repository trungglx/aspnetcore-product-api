namespace ProductApi.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ProductApi.Data;   // MuOnlineContext & entity Item

    /// <summary>
    /// Truy vấn dữ liệu item từ DB MUOnline (MySQL) – chỉ đọc.
    /// </summary>
    public class MuItemRepository : IMuItemRepository
    {
        private readonly AppDbContext _db;

        public MuItemRepository(AppDbContext db)
        {
            _db = db;
        }
    }
}
