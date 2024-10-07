using Microsoft.AspNetCore.Mvc;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Models;

namespace CSharpTest.Controllers.v1.Room_types;

[ApiController]
[Route("api/v1/Room_types/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Room_types")]
public class Room_typeController : ControllerBase
{   
    protected readonly IRoom_typeRepository Room_typeRepository;

    public Room_typeController(IRoom_typeRepository Room_typeRepository)
    {
        this.Room_typeRepository = Room_typeRepository;
    }
}