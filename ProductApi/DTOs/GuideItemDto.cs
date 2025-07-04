namespace ProductApi.Dtos;
public record GuideItemDto(int Id, string Name, int TypeId, int Level, string? Options, string? ImageUrl, string? Description);
