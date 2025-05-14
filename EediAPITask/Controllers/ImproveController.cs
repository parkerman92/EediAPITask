using EediAPITask.Helpers;
using EediAPITask.Models;
using Microsoft.AspNetCore.Mvc;

namespace EediAPITask.Controllers;

[ApiController]
[Route("[controller]")]
public class ImproveController : ControllerBase
{
    [HttpGet]
    public ActionResult<TopicSummary[]> GetTopicSummaries()
    {
        var allTopics = TestData.GenerateTopics();

        // Massage the test data.
        var testData =
            allTopics
            .Select(x => TopicSummary.Create(x, Random.Shared.Next(0, 5)))
            .ToArray();

        var parentTotals = testData
            .GroupBy(x => x.ParentId)
            .Where(w => w.Key != null)
            .ToDictionary(x => (int)x.Key!, x => x.Sum(y => y.MisconceptionCount));

        foreach (var topicSummary in testData.Where(w => w.ParentId == null))
        {
            topicSummary.MisconceptionCount = parentTotals[topicSummary.Id];
        }

        return testData
            .Where(w => w.MisconceptionCount > 0)
            .ToArray();
    }

    [HttpGet]
    [Route("Misconceptions/{topicId:int}")]
    public ActionResult<Answer[]> GetMisconceptions([FromRoute] int topicId)
    {
        return Enumerable.Range(1, Random.Shared.Next(1, 4)).Select(s => TestData.GenerateMisconception(s, topicId)).ToArray();
    }
}