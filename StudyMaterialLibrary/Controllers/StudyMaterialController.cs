using Microsoft.AspNetCore.Mvc;
using StudyLibrary.Application.Abstractions;
using StudyLibrary.Entities;

namespace StudyLibrary.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudyMaterialController : Controller
{
    private readonly IStudyMaterialService _studyMaterialService;

    public StudyMaterialController(IStudyMaterialService studyMaterialService)
    {
        _studyMaterialService = studyMaterialService;
    }

    [HttpGet("{id}")]
    public IActionResult GetStudyMaterialById(int id)
    {
        var studyMaterial = _studyMaterialService.GetMaterialByIdAsync(id);
        if(studyMaterial == null)
        {
            return NotFound();
        }
        return Ok(studyMaterial);
    }

    [HttpGet]
    public IActionResult GetAllStudyMaterials()
    {
        var studyMaterials = _studyMaterialService.GetAllMaterialsAsync();
        if (studyMaterials == null)
        {
            return NotFound();
        }
        return Ok(studyMaterials);
    }

    [HttpGet]
    public IActionResult GetMaterialsBySubjectId(int subjectId)
    {
        var studyMaterials = _studyMaterialService.GetMaterialsBySubjectIdAsync(subjectId);
        if (studyMaterials == null)
        {
            return NotFound();
        }
        return Ok(studyMaterials);
    }

    [HttpPost]
    public IActionResult AddStudyMaterial(StudyMaterial newStudyMaterial)
    {
        if(newStudyMaterial == null)
        {
            return BadRequest("Invalid material");
        }
        var addedMaterial = _studyMaterialService.AddMaterialAsync(newStudyMaterial);
        var routeValues = new { id = newStudyMaterial.Id };
        return CreatedAtAction(nameof(GetStudyMaterialById), routeValues, addedMaterial);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateStudyMaterial(StudyMaterial studyMaterial)
    {
        var material = _studyMaterialService.GetMaterialByIdAsync(studyMaterial.Id);
        if (material == null)
        {
            return NotFound();
        }
        var updatedMaterial = _studyMaterialService.UpdateMaterialAsync(studyMaterial);
        return Ok(updatedMaterial);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStudyMaterial(StudyMaterial newStudyMaterial)
    {
        var material = _studyMaterialService.GetMaterialByIdAsync(newStudyMaterial.Id);
        if(material == null)
        {
            return NotFound();
        }
        _studyMaterialService.DeleteMaterialAsync(material.Id);
        return NoContent();
    }
}
