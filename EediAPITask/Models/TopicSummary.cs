namespace EediAPITask.Models;

public class TopicSummary : Topic
{
    public int MisconceptionCount { get; set; }

    public static TopicSummary Create(Topic topic, int? misconceptionCount = null)
    {
        return new TopicSummary()
        {
            Id = topic.Id,
            Name = topic.Name,
            ParentId = topic.ParentId,
            MisconceptionCount = misconceptionCount ?? 0,
        };
    }
}