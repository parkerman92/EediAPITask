namespace EediAPITask.Models;

public class Question
{
    public int Id { get; set; }


    public required string QuestionImg { get; set; }

    public required string AnswerImg { get; set; }
}