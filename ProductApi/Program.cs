using ProductApi.Data;           // chứa ApplicationDbContext
using Microsoft.EntityFrameworkCore;
using ProductApi.Services;
using ProductApi.Repositories;   // IMuItemRepository, ItemGuideRepository, ...

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3000", "https://localhost:3000") // Cả 2 trường hợp
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials(); // nếu bạn cần cookie hoặc token
    });
});

string sqlConn = builder.Configuration.GetConnectionString("ItemGuideDb")!;
string myConn  = builder.Configuration.GetConnectionString("MuOnlineDb")!;
builder.Services.AddScoped<ICategoryService, CategoryService>();
// SQL Server
builder.Services.AddDbContext<ItemGuideContext>(opts =>
    opts.UseSqlServer(sqlConn,
    sql => sql.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(10),
            errorNumbersToAdd: null
        )));
// MySQL
builder.Services.AddDbContext<AppDbContext>(opts =>
    opts.UseMySql(myConn, ServerVersion.AutoDetect(myConn)));
builder.Services.AddDbContext<ApplicationDbContext>(opts =>
    opts.UseMySql(myConn, ServerVersion.AutoDetect(myConn)));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IMuItemRepository,     MuItemRepository>();      // dùng MuOnlineContext
builder.Services.AddScoped<IItemGuideRepository, ItemGuideRepository>();    // dùng ItemGuideContext
builder.Services.AddScoped<IItemGuideService, ItemGuideService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.UseHttpsRedirection();         // ✅ Đặt ngay sau build
app.UseCors();                     // ✅ CORS nằm giữa Routing và MapControllers
app.UseRouting();                  // ✅ Routing phải trước CORS
app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
//using (var scope = app.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<ItemGuideContext>();
//    await SeedData.InitializeAsync(db);
//}
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ItemGuideContext>();
    await db.Database.MigrateAsync();    // bảo đảm đã tạo bảng
    await SeedCrawler.RunAsync(db);
}
app.Run();

