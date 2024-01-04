using Microsoft.AspNetCore.Mvc;
using StudyLibrary.Entities;

namespace StudyLibrary.Api.Controllers;

[ApiController]
[Route("api/[controller")]
public class SubjectController : ControllerBase
{
    private readonly ISubjectService _subjectService;

    public SubjectController(ISubjectService subjectService)
    {
        _subjectService = subjectService;
    }

    [HttpGet("{id}")]
    public IActionResult GetSubjectById(int id)
    {
        var subject = _subjectService.GetSubjectById(id);
        if(subject == null) 
        {
            return NotFound();
        }
        return Ok(subject);
    }

    [HttpGet]
    public IActionResult GetAllSubjects()
    {
        var subjects = _subjectService.GetAllSubjects();
        if (subjects == null)
        {
            return NotFound();
        }
        return Ok(subjects);
    }

    [HttpPost]
    public IActionResult AddSubject(Subject newSubject)
    {
        if (newSubject == null)
        {
            BadRequest("Invalid Subject");
        }
        var addedSubject = _subjectService.AddSubject(newSubject);
        var routeValues = new {id =  addedSubject.Id};
        return CreatedAtAction(nameof(GetSubjectById), routeValues, addedSubject);
    }
}
