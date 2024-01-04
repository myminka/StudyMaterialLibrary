using Microsoft.AspNetCore.Mvc;
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
        var studyMaterial = _studyMaterialService.GetStudyMaterialById(id);
        if(studyMaterial == null)
        {
            return NotFound();
        }
        return Ok(studyMaterial);
    }

    [HttpGet]
    public IActionResult GetAllStudyMaterials()
    {
        var studyMaterials = _studyMaterialService.GetAllStudyMaterials();
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
        var addedMaterial = _studyMaterialService.AddStudyMaterial(newStudyMaterial);
        var routeValues = new { id = newStudyMaterial.Id };
        return CreatedAtAction(nameof(GetStudyMaterialById), routeValues, addedMaterial);
    }
}
