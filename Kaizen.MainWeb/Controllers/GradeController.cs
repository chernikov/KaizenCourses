using Kaizen.Core;
using Kaizen.MainWeb.Dtos;
using Kaizen.MainWeb.EntityExtensions;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Route("api/grade")]
public class GradeController: Controller
{
    private readonly KaizenDbContext context;

    public GradeController(KaizenDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IActionResult List()
    {
        var list = context.Grades.ToList();
        var result = list.Select(item => item.ToDto());
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public IActionResult Detail(int id)
    {
        var entity = context.Grades.SingleOrDefault(p => p.Id == id);

        if (entity == null)
        {
            return NotFound($"Grade with id = {id} doesn't exist");
        }

        var dto = entity.ToDto();

        return Ok(dto);
    }


    [HttpPost]
    public IActionResult Create([FromBody] GradeDto data)
    {
        var entity = data.ToEntity();

        context.Grades.Add(entity);
        context.SaveChanges();

        var dto = entity.ToDto();

        return Created($"/api/grade/{dto.Id}", dto);
    }


    [HttpPut]
    public IActionResult Update([FromBody] GradeDto data)
    {
        var entity = context.Grades.SingleOrDefault(p => p.Id == data.Id);

        if (entity == null)
        {
            return NotFound($"Grade with id = {data.Id} doesn't exist");
        }
        entity.Name = data.Name;
        context.SaveChanges();

        var dto = entity.ToDto();

        return Ok(dto);

    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var entity = context.Grades.SingleOrDefault(p => p.Id == id);

        if (entity != null)
        {
            context.Grades.Remove(entity);
            context.SaveChanges();
        }

        return Ok();
    }
}
