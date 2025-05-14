using EediAPITask.Models;

namespace EediAPITask.Helpers;

public static class TestData
{
    public static Topic[] GenerateTopics()
    {
        return
        [
            new Topic()
            {
                Id = 1,
                Name = "Number",
                ParentId = null,
            },
            new Topic()
            {
                Id = 2,
                Name = "Algebra",
                ParentId = null,
            },
            new Topic()
            {
                Id = 3,
                Name = "Fractions",
                ParentId = 1,
            },
            new Topic()
            {
                Id = 4,
                Name = "Decimals",
                ParentId = 1,
            },
            new Topic()
            {
                Id = 5,
                Name = "Factors",
                ParentId = 1,
            },
            new Topic()
            {
                Id = 6,
                Name = "Multiples",
                ParentId = 2,
            },
            new Topic()
            {
                Id = 7,
                Name = "Primes",
                ParentId = 2,
            },
            new Topic()
            {
                Id = 8,
                Name = "Fractions",
                ParentId = 2,
            },
        ];
    }

    public static Answer GenerateMisconception(int id, int? topicId = null)
    {
        return new Answer()
        {
            Id = id,
            TopicId = topicId ?? id,
            Question = new Question()
            {
                QuestionImg = $"/answers/{id}.png",
                AnswerImg = $"/answers/{id}.png",
            },
            IsCorrect = false,
            AnswerUrl = $"/answers/{id}.png",
        };
    }
}