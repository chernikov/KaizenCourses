using Kaizen.Core;
using Kaizen.MainWeb.Dtos;
using Kaizen.MainWeb.EntityExtensions;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Route("api/class-room")]
public class ClassRoomController: Controller
{
    private readonly KaizenDbContext context;

    // 1 - get all list
    // 2 - get one details
    // 3 - create
    // 4 - update
    // 5 - delete

    public ClassRoomController(KaizenDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IActionResult List()
    {
        var list = context.ClassRooms.ToList();
        var result = list.Select(item => item.ToDto());
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public IActionResult Detail(int id)
    {
        var entity = context.ClassRooms.SingleOrDefault(p => p.Id == id);

        if (entity == null)
        {
            return NotFound($"Class room with id = {id} doesn't exist");
        }

        var dto = entity.ToDto();

        return Ok(dto);
    }


    [HttpPost]
    public IActionResult Create([FromBody] ClassRoomDto data)
    {
        var entity = data.ToEntity();

        context.ClassRooms.Add(entity);
        context.SaveChanges();

        var dto = entity.ToDto();

        return Created($"/api/class-room/{dto.Id}", dto);
    }


    [HttpPut]
    public IActionResult Update([FromBody] ClassRoomDto data)
    {
        var entity = context.ClassRooms.SingleOrDefault(p => p.Id == data.Id);

        if (entity == null)
        {
            return NotFound($"Class room with id = {data.Id} doesn't exist");
        }
        entity.Name = data.Name;
        context.SaveChanges();

        var dto = entity.ToDto();

        return Ok(dto);

    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var entity = context.ClassRooms.SingleOrDefault(p => p.Id == id);

        if (entity != null)
        {
            context.ClassRooms.Remove(entity);
            context.SaveChanges();
        }

        return Ok();
    }
}
