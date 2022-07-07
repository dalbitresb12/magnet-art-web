using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using si653ebu202015652.API.Shared.Extensions;
using si653ebu202015652.API.Training.Domain.Models;
using si653ebu202015652.API.Training.Domain.Services;
using si653ebu202015652.API.Training.Resources;

namespace si653ebu202015652.API.Training.Controllers;

[ApiController]
[Route("[controller]")]
public class ProviderController : ControllerBase {
  private readonly IMapper mapper;
  private readonly IProviderService service;

  public ProviderController(IMapper mapper, IProviderService service) {
    this.mapper = mapper;
    this.service = service;
  }

  [HttpGet("{id:int}")]
  public async Task<IActionResult> GetById(int id) {
    var result = await service.GetById(id);
    if (result is null) return NotFound();
    return Ok(result);
  }

  [HttpPost]
  public async Task<IActionResult> Post([FromBody] ProviderRequest request) {
    if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

    var mapped = mapper.Map<ProviderRequest, Provider>(request);
    var result = await service.Create(mapped);
    return result.ToResponse<ProviderResource>(this, mapper);
  }
}
