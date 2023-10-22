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
            return NotFound();
        }
        return Ok(entity.ToDto());
    }


    [HttpPost]
    public IActionResult Post([FromBody]ScheduleDto data)
    {

        var entity = data.ToEntity();

        context.Schedules.Add(entity);
        context.SaveChanges();

        var newEntity = context.Schedules
            .Include(p => p.ClassRoom)
            .Include(p => p.Grade)
            .Include(p => p.Subject)
            .Include(p => p.TimeSlot)
            .SingleOrDefault(p => p.Id == entity.Id);
        
        return Ok(newEntity?.ToDto());
    }

    [HttpPut]
    public IActionResult Put([FromBody] ScheduleDto data)
    {
        var entity = data.ToEntity();
        var fromDb = context.Schedules.FirstOrDefault(p => p.Id == entity.Id);
        if (fromDb == null)
        {
            return NotFound();
        }
        fromDb.SubjectId = entity.SubjectId;
        fromDb.GradeId = entity.GradeId;
        fromDb.ClassRoomId = entity.ClassRoomId;
        fromDb.TimeSlotId = entity.TimeSlotId;

        context.Schedules.Update(fromDb);
        context.SaveChanges();

        var newEntity = context.Schedules
            .Include(p => p.ClassRoom)
            .Include(p => p.Grade)
            .Include(p => p.Subject)
            .Include(p => p.TimeSlot)
            .SingleOrDefault(p => p.Id == entity.Id);

        return Ok(newEntity?.ToDto());
    }


    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var entity = context.Schedules.SingleOrDefault(p => p.Id == id);

        if (entity != null)
        {
            context.Schedules.Remove(entity);
            context.SaveChanges();
        }
        return Ok();
    }
}
