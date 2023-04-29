using Application.api;
using Application.dto;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/testImplementation")]
public class TestImplementationController : ControllerBase
{
    private readonly ITestImplementationService _testImplementationService;

    public TestImplementationController(ITestImplementationService testImplementationService)
    {
        _testImplementationService = testImplementationService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TestImplementationDTO>> FindTestImplementationById(string id)
    {
        var testImplementationDTO = await _testImplementationService.FindById(id);
        return Ok(testImplementationDTO);
    }
    
    [HttpGet("shortDescription/{shortDescription}")]
    public async Task<ActionResult<TestImplementationDTO>> FindTestImplementationsByShortDescription(string shortDescription)
    {
        var testImplementationDTOs = await _testImplementationService.FindByShortDescription(shortDescription);
        return Ok(testImplementationDTOs);
    }
    
    [HttpPost("create")]
    public async Task<ActionResult<TestImplementationDTO>> CreateTestImplementation(TestImplementationDTO testImplementationDTO)
    {
        await _testImplementationService.Add(testImplementationDTO);
        return Ok(testImplementationDTO);
    }
}