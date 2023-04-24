using Application.api;
using Application.dto;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/testRun")]
public class TestRunController : ControllerBase
{
    private readonly ITestRunService _testRunService;

    public TestRunController(ITestRunService testRunService)
    {
        _testRunService = testRunService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TestRunDTO>> FindTestRunById(string id)
    {
        var testPlanDTO = await _testRunService.FindById(id);
        return Ok(testPlanDTO);
    }

    [HttpGet("testSystemId/{testSystemId}")]
    public async Task<ActionResult<TestRunDTO>> FindTestRunsByTestSystemId(string testSystemId)
    {
        var testRunDTOs = await _testRunService.FindByTestSystemId(testSystemId);
        return Ok(testRunDTOs);
    }

    [HttpPost("create")]
    public async Task<ActionResult<TestRunDTO>> CreateTestRun(TestRunDTO testRunDTO)
    {
        await _testRunService.Add(testRunDTO);
        return Ok(testRunDTO);
    }
}