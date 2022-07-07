using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using si653ebu202015652.API.Painting.Domain.Models;
using si653ebu202015652.API.Painting.Domain.Services;
using si653ebu202015652.API.Painting.Resources;
using si653ebu202015652.API.Shared.Extensions;

namespace si653ebu202015652.API.Painting.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase {
  private readonly IMapper mapper;
  private readonly IAuthorService service;

  public AuthorController(IMapper mapper, IAuthorService service) {
    this.mapper = mapper;
    this.service = service;
  }

  [HttpGet]
  public async Task<IEnumerable<AuthorResource>> GetAll() {
    var entities = await service.ListAll();
    return mapper.Map<IEnumerable<Author>, IEnumerable<AuthorResource>>(entities);
  }

  [HttpPost]
  public async Task<IActionResult> Post([FromBody] AuthorRequest request) {
    if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

    var mapped = mapper.Map<AuthorRequest, Author>(request);
    var result = await service.Create(mapped);
    return result.ToResponse<AuthorResource>(this, mapper);
  }
}
