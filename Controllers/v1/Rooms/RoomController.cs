using Microsoft.AspNetCore.Mvc;
using CSharpTest.Repositories.Interfaces;

namespace CSharpTest.Controllers.v1.Rooms;

[ApiController]
[Route("api/v1/Rooms/[controller]")]
[ApiExplorerSettings(GroupName ="v1")]
[Tags("Rooms")]
public class RoomController: ControllerBase
{
    protected readonly IRoomRepository RoomRepository;

    public RoomController(IRoomRepository RoomRepository)
    {
        this.RoomRepository = RoomRepository;
    }
}