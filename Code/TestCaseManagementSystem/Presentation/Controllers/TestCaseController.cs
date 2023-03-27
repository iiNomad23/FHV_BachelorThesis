using Application.api;
using Application.dto;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/testcase")]
public class TestCaseController : ControllerBase
{
    private readonly ITestCaseService _testCaseService;

    public TestCaseController(ITestCaseService testCaseService)
    {
        _testCaseService = testCaseService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TestCaseDTO>> GetTestCaseById(int id)
    {
        var testCaseDTO = await _testCaseService.GetById(id);
        return Ok(testCaseDTO);
    }
    
    [HttpPost("create")]
    public async Task<ActionResult<TestCaseDTO>> CreateTestCase(TestCaseDTO testCaseDTO)
    {
        await _testCaseService.Add(testCaseDTO);
        return Ok(testCaseDTO);
    }
}