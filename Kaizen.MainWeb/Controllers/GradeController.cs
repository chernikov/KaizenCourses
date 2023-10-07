using Kaizen.Core;
using Kaizen.MainWeb.Dtos;
using Kaizen.MainWeb.EntityExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/grade")]
public class GradeController : Controller
{
    private readonly KaizenDbContext context;

    public GradeController(KaizenDbContext context) {
        this.context = context;
    }


    [HttpGet]
    public IActionResult GetAll()
    {
        var list = context.Grades.ToList();
        var result = list.Select(p => p.ToDto());

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id) 
    {
        var entity = context.Grades.FirstOrDefault(p => p.Id == id);
        if (entity == null)
        {
            return BadRequest($"Grade with id = {id} doesn't exist");
        }
        var result = entity.ToDto();
        return Ok(result);
    }


    [HttpPost]
    public IActionResult Post([FromBody] GradeDto data) 
    {
        var entity = data.ToEntity();
        context.Grades.Add(entity);
        context.SaveChanges();
        return Created($"api/grade/{entity.Id}", entity.ToDto());
    }

    [HttpPut]
    public IActionResult Put([FromBody] GradeDto data) 
    { 
        var entity = data.ToEntity();

        var fromDb = context.Grades.FirstOrDefault(p => p.Id == data.Id);

        if (fromDb == null)
        {
            return BadRequest($"Grde with id = {data.Id} doesn't exist");

        }
        fromDb.Name = data.Name;
        context.SaveChanges();

        return Ok(fromDb.ToDto());

    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var entity = context.Grades.FirstOrDefault(p => p.Id == id);
        if (entity != null) { 
            context.Grades.Remove(entity);
            context.SaveChanges();
        }
        return Ok();
    }


}
