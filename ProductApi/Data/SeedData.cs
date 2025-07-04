using Microsoft.EntityFrameworkCore;
namespace ProductApi.Data;
public static class SeedData
{
    public static async Task InitializeAsync(ItemGuideContext db)
    {
        if (await db.ItemTypes.AnyAsync()) return; // already seeded

        var types = new[]
        {
            new ItemType { Name = "Weapon" },
            new ItemType { Name = "Sword" },
            new ItemType { Name = "Staff" },
            new ItemType { Name = "Spear" },
            new ItemType { Name = "Mace" },
            new ItemType { Name = "Shield" },
            new ItemType { Name = "Armor" },
            new ItemType { Name = "Artifact" },
            new ItemType { Name = "Muun" },
            new ItemType { Name = "Set (Mastery)" },
            new ItemType { Name = "Set (Ancient)" },
            new ItemType { Name = "Set (Lucky)" }
        };
        db.ItemTypes.AddRange(types);
        await db.SaveChangesAsync();

        var items = new[]
        {
            new Item { Name = "Silver Heart Magic Two‑Hand Sword", TypeId = types.Single(t => t.Name == "Sword").Id, Level = 400, Description = "Mastery sword", Options = "Excellent;+Damage" },
            new Item { Name = "Blue Eye Rune Wizard Armor",         TypeId = types.Single(t => t.Name == "Armor").Id, Level = 380, Description = "Mastery armor", Options = "+HP" },
            new Item { Name = "Divine Staff of Archangel",          TypeId = types.Single(t => t.Name == "Staff").Id, Level = 380, Description = "Legendary staff" },
            new Item { Name = "Ghost Muun",                         TypeId = types.Single(t => t.Name == "Muun").Id, Level = 0,   Description = "Pet that increases damage" },
            new Item { Name = "Brilliant Set Armor",                TypeId = types.Single(t => t.Name == "Set (Mastery)").Id, Level = 400, Description = "Mastery set piece" }
        };
        db.Items.AddRange(items);
        await db.SaveChangesAsync();
    }
}