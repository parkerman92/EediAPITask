using EediAPITask.Helpers;
using EediAPITask.Models;
using Microsoft.AspNetCore.Mvc;

namespace EediAPITask.Controllers;

[ApiController]
[Route("[controller]")]
public class TopicController : ControllerBase
{
    [HttpGet]
    public ActionResult<Topic[]> Get()
    {
        return TestData.GenerateTopics();
    }

    [HttpGet("{id:int}")]
    public ActionResult<Topic> Get([FromRoute] int id)
    {
        if (id < 1 || id > 8)
        {
            return NotFound();
        }

        return TestData.GenerateTopics().First(f => f.Id == id);
    }
}