namespace EediAPITask.Models;

public class Topic
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public int? ParentId { get; set; }
}