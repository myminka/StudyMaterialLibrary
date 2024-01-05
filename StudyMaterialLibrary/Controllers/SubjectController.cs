using Microsoft.AspNetCore.Mvc;
using StudyLibrary.Application.Abstractions;
using StudyLibrary.Application.Services;
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
        var subject = _subjectService.GetSubjectByIdAsync(id);
        if(subject == null) 
        {
            return NotFound();
        }
        return Ok(subject);
    }

    [HttpGet]
    public IActionResult GetAllSubjects()
    {
        var subjects = _subjectService.GetAllSubjectAsync();
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
        var addedSubject = _subjectService.AddSubjectAsync(newSubject);
        var routeValues = new {id =  addedSubject.Id};
        return CreatedAtAction(nameof(GetSubjectById), routeValues, addedSubject);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateStudyMaterial(Subject subject)
    {
        var material = _subjectService.GetSubjectByIdAsync(subject.Id);
        if (material == null)
        {
            return NotFound();
        }
        var updatedMaterial = _subjectService.UpdateSubjectAsync(subject);
        return Ok(updatedMaterial);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStudyMaterial(Subject subject)
    {
        var material = _subjectService.GetSubjectByIdAsync(subject.Id);
        if (material == null)
        {
            return NotFound();
        }
        _subjectService.DeleteSubjectAsync(material.Id);
        return NoContent();
    }
}
