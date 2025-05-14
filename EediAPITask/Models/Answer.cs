namespace EediAPITask.Models;

public class Answer
{
    public int Id { get; set; }

    public int TopicId { get; set; }

    public required Question Question { get; set; }

    public required string AnswerUrl { get; set; }

    public bool IsCorrect { get; set; }
}