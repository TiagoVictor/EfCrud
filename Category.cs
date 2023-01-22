namespace EfCrud.Entities;

public class Category
{
    public Category(int id, string title, string slug, string description)
    {
        Id = id;
        Title = title;
        Slug = slug;
        Description = description;
    }

    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
