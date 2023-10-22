using Kaizen.Core;
using Kaizen.MainWeb.Dtos;
using Kaizen.MainWeb.EntityExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Route("api/subject")]
[Authorize(Roles = "Admin")]
public class SubjectController : Controller
{
    private readonly KaizenDbContext context;

    public SubjectController(KaizenDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {

        var list = context.Subjects.ToList();
        var result = list.Select(p => p.ToDto());
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        var entity = context.Subjects.SingleOrDefault(r => r.Id == id);

        if (entity == null)
        {
            return BadRequest("Subject not found");
        }
        var result = entity.ToDto();
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Post([FromBody] SubjectDto data)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Model is not valid");
        }

        var entity = data.ToEntity();

        context.Subjects.Add(entity);
        context.SaveChanges();

        return Created("", entity.ToDto());
    }

    [HttpPut]
    public IActionResult Put([FromBody] SubjectDto data)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Model is not valid");
        }

        var entity = data.ToEntity();

        var fromDb = context.Subjects.SingleOrDefault(p => p.Id == entity.Id);
        if (fromDb == null)
        {
            return BadRequest($"Subject with id {entity.Id} doesn't exist");
        }

        fromDb.Name = entity.Name;
        context.SaveChanges();

        return Ok(fromDb.ToDto());
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {

        var fromDb = context.Subjects.SingleOrDefault(p => p.Id == id);

        if (fromDb != null)
        {
            context.Subjects.Remove(fromDb);
            context.SaveChanges();
        }

        return Ok();
    }
}
