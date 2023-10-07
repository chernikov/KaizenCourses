using Kaizen.Core;
using Kaizen.MainWeb.Dtos;
using Kaizen.MainWeb.EntityExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/class-room")]
public class ClassRoomController : Controller
{
    private readonly KaizenDbContext context;

    public ClassRoomController(KaizenDbContext context) {
        this.context = context;
    }


    [HttpGet]
    public IActionResult GetAll()
    {
        var list = context.ClassRooms.ToList();
        var result = list.Select(p => p.ToDto());

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id) 
    {
        var entity = context.ClassRooms.FirstOrDefault(p => p.Id == id);
        if (entity == null)
        {
            return BadRequest($"ClassRoom with id = {id} doesn't exist");
        }
        var result = entity.ToDto();
        return Ok(result);
    }


    [HttpPost]
    public IActionResult Post([FromBody] ClassRoomDto data) 
    {
        var entity = data.ToEntity();
        context.ClassRooms.Add(entity);
        context.SaveChanges();
        return Created($"api/class-room/{entity.Id}", entity.ToDto());
    }

    [HttpPut]
    public IActionResult Put([FromBody] ClassRoomDto data) 
    { 
        var entity = data.ToEntity();

        var fromDb = context.ClassRooms.FirstOrDefault(p => p.Id == data.Id);

        if (fromDb == null)
        {
            return BadRequest($"ClassRoom with id = {data.Id} doesn't exist");

        }
        fromDb.Name = data.Name;
        context.SaveChanges();

        return Ok(fromDb.ToDto());

    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var entity = context.ClassRooms.FirstOrDefault(p => p.Id == id);
        if (entity != null) { 
            context.ClassRooms.Remove(entity);
            context.SaveChanges();
        }
        return Ok();
    }


}
