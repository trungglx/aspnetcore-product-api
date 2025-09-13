using HtmlAgilityPack;
using System.Net.Http.Headers;
using ProductApi.Data;
using Microsoft.EntityFrameworkCore;

namespace ProductApi.Data;

public static class SeedCrawler
{
    private static readonly string baseUrl = "https://guidemuonline.com";
    private static readonly HttpClient http = new()
    {
        DefaultRequestHeaders = {
                UserAgent = { ProductInfoHeaderValue.Parse("Mozilla/5.0") } }
    };

    public static async Task RunAsync(ItemGuideContext db)
    {
        if (await db.Items.AnyAsync()) return;   // Đã seed

        var url = $"{baseUrl}/all-items";        // Trang liệt kê
        var html = await http.GetStringAsync(url);
        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        // 🎯 1. Lấy tất cả thẻ item card
        var nodes = doc.DocumentNode.SelectNodes("//div[@class='item-card']") ?? new HtmlNodeCollection(doc.DocumentNode);

        foreach (var n in nodes)
        {
            // Tùy layout thật của trang mà đổi XPath
            var name = n.SelectSingleNode(".//h3")?.InnerText.Trim() ?? "Unknown";
            var img = n.SelectSingleNode(".//img")?.GetAttributeValue("src", "");
            var cat = n.GetAttributeValue("data-category", "Other");
            var level = int.TryParse(n.GetAttributeValue("data-level", "0"), out var lv) ? lv : 0;

            // -- Tạo / lấy ItemType
            var type = await db.ItemTypes.FirstOrDefaultAsync(t => t.Name == cat);
            if (type is null)
            {
                type = new ItemType { Name = cat };
                db.ItemTypes.Add(type);
                await db.SaveChangesAsync();
            }

            // -- Tạo Item
            if (!await db.Items.AnyAsync(i => i.Name == name))
            {
                db.Items.Add(new Item
                {
                    Name = name,
                    TypeId = type.Id,
                    Level = level,
                    ImageUrl = img.StartsWith("http") ? img : baseUrl + img
                });
            }
        }
        await db.SaveChangesAsync();
    }
}
