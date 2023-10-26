using Kaizen.Core;
using Kaizen.MainWeb.Dtos;
using Kaizen.MainWeb.EntityExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kaizen.MainWeb.Controllers;

[Route("api/schedule")]
public class ScheduleController : Controller
{
    private readonly KaizenDbContext context;

    public ScheduleController(KaizenDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var list = context.Schedules
                .Include(p => p.ClassRoom)
                .Include(p => p.Grade)
                .Include(p => p.Subject)
                .Include(p => p.TimeSlot)
                .ToList();

        var result = list.Select(p => p.ToDto());
        return Ok(result);
    }


    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        var entity = context.Schedules
          .Include(p => p.ClassRoom)
          .Include(p => p.Grade)
          .Include(p => p.Subject)
          .Include(p => p.TimeSlot)
          .SingleOrDefault(p => p.Id == id);

        if (entity == null)
        {
            return NotFound($"Schedule with id = {id} doesn't exist");

        }
        return Ok(entity.ToDto());
    }


    [HttpPost]
    public IActionResult Post([FromBody]ScheduleDto schedule)
    {
        var entity = schedule.ToEntity();

        context.Schedules.Add(entity);
        context.SaveChanges();

        var newEntity = context.Schedules
                .Include(p => p.ClassRoom)
                .Include(p => p.Grade)
                .Include(p => p.Subject)
                .Include(p => p.TimeSlot)
                .SingleOrDefault(p => p.Id == entity.Id);

        
        return Created($"/api/schedule/{entity.Id}", newEntity.ToDto());
    }


    [HttpPut]
    public IActionResult Put([FromBody] ScheduleDto schedule)
    {
        var entity = schedule.ToEntity();

        var fromDb = context.Schedules.SingleOrDefault(p => p.Id == entity.Id);

        if (fromDb == null)
        {
            return NotFound($"Schedule with id = {entity.Id} doesn't exist");
        }

        fromDb.SubjectId = entity.SubjectId;
        fromDb.TimeSlotId = entity.TimeSlotId;
        fromDb.GradeId = entity.GradeId;
        fromDb.ClassRoomId = entity.ClassRoomId;
        context.SaveChanges();


        entity = context.Schedules
                .Include(p => p.ClassRoom)
                .Include(p => p.Grade)
                .Include(p => p.Subject)
                .Include(p => p.TimeSlot)
                .SingleOrDefault(p => p.Id == entity.Id);


        return Ok(entity?.ToDto());
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id) 
    {
        var entity = context.Schedules.FirstOrDefault(p => p.Id == id);

        if (entity != null)
        {
            context.Schedules.Remove(entity);
            context.SaveChanges();
        }

        return Ok();
    }
}
