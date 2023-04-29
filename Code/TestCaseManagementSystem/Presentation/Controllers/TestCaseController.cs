using Application.api;
using Application.dto;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/testCase")]
public class TestCaseController : ControllerBase
{
    private readonly ITestCaseService _testCaseService;

    public TestCaseController(ITestCaseService testCaseService)
    {
        _testCaseService = testCaseService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TestCaseDTO>> FindTestCaseById(string id)
    {
        var testCaseDTO = await _testCaseService.FindById(id);
        return Ok(testCaseDTO);
    }

    [HttpGet("shortDescription/{shortDescription}")]
    public async Task<ActionResult<TestCaseDTO>> FindTestCasesByShortDescription(string shortDescription)
    {
        var testCaseDTOs = await _testCaseService.FindByShortDescription(shortDescription);
        return Ok(testCaseDTOs);
    }

    [HttpPost("create")]
    public async Task<ActionResult<TestCaseDTO>> CreateTestCase(TestCaseDTO testCaseDTO)
    {
        await _testCaseService.Add(testCaseDTO);
        return Ok(testCaseDTO);
    }
}