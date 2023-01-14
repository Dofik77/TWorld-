using Microsoft.AspNetCore.Mvc;

namespace TWorl.WebApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public List<object> List()
    {
        return new List<object>()
        {
            new
            {
                Name = "Тест",
                Id = 1,
                Description = "Тест"
            },
            new
            {
                Name = "Тест",
                Id = 1,
                Description = "Тест"
            },
            new
            {
                Name = "Тест",
                Id = 1,
                Description = "Тест"
            }
        };
    }
}