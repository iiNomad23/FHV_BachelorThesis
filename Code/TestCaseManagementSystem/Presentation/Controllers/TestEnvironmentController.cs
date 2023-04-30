using Application.Api;
using Application.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/testEnvironment")]
public class TestEnvironmentController : ControllerBase
{
    private readonly ITestEnvironmentService _testEnvironmentService;

    public TestEnvironmentController(ITestEnvironmentService testEnvironmentService)
    {
        _testEnvironmentService = testEnvironmentService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TestEnvironmentDTO>> FindTestEnvironmentById(string id)
    {
        var testEnvironmentDTO = await _testEnvironmentService.FindById(id);
        return Ok(testEnvironmentDTO);
    }

    [HttpGet("shortDescription/{shortDescription}")]
    public async Task<ActionResult<TestEnvironmentDTO>> FindTestEnvironmentsByShortDescription(string shortDescription)
    {
        var testEnvironmentDTOs = await _testEnvironmentService.FindByShortDescription(shortDescription);
        return Ok(testEnvironmentDTOs);
    }

    [HttpPost("create")]
    public async Task<ActionResult<TestEnvironmentDTO>> CreateTestEnvironment(TestEnvironmentDTO testEnvironmentDTO)
    {
        await _testEnvironmentService.Add(testEnvironmentDTO);
        return Ok(testEnvironmentDTO);
    }
}