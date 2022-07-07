using System.Net.Mime;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using si653ebu202015652.API.Painting.Domain.Models;
using si653ebu202015652.API.Painting.Domain.Services;
using si653ebu202015652.API.Painting.Resources;
using si653ebu202015652.API.Shared.Extensions;
using Swashbuckle.AspNetCore.Annotations;

namespace si653ebu202015652.API.Painting.Controllers;

[ApiController]
[Route("[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Manage registered authors")]
public class AuthorController : ControllerBase {
  private readonly IMapper mapper;
  private readonly IAuthorService service;

  public AuthorController(IMapper mapper, IAuthorService service) {
    this.mapper = mapper;
    this.service = service;
  }

  [HttpGet]
  [ProducesResponseType(typeof(IEnumerable<AuthorResource>), 200)]
  [SwaggerResponse(200, "All the authors were retrieved successfully.", typeof(IEnumerable<AuthorResource>))]
  public async Task<IEnumerable<AuthorResource>> GetAll() {
    var entities = await service.ListAll();
    return mapper.Map<IEnumerable<Author>, IEnumerable<AuthorResource>>(entities);
  }

  [HttpPost]
  [SwaggerResponse(200, "The requested author was successfully created.", typeof(AuthorResource))]
  [SwaggerResponse(400, "A data validation error occurred.")]
  public async Task<IActionResult> Post([FromBody] AuthorRequest request) {
    if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

    var mapped = mapper.Map<AuthorRequest, Author>(request);
    var result = await service.Create(mapped);
    return result.ToResponse<AuthorResource>(this, mapper);
  }
}
