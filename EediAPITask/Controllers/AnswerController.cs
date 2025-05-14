using EediAPITask.Helpers;
using EediAPITask.Models;
using Microsoft.AspNetCore.Mvc;

namespace EediAPITask.Controllers;

[ApiController]
[Route("[controller]")]
public class AnswerController : ControllerBase
{
    [HttpGet]
    public ActionResult<Answer[]> Get()
    {
        return new Answer[]
        {
            TestData.GenerateMisconception(1),
            TestData.GenerateMisconception(2),
            TestData.GenerateMisconception(3),
        };
    }

    [HttpGet("{id:int}")]
    public ActionResult<Answer> Get([FromRoute] int id)
    {
        // Simple validation for the test data.
        if (id < 1 || id > 3)
        {
            return NotFound();
        }

        return TestData.GenerateMisconception(id);
    }
}