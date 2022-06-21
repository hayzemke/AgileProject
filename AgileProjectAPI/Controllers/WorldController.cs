using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class WorldController : ControllerBase
{
    private readonly IWorld  _worldService;

    public WorldController(IWorld worldService)
    {
        _worldService = worldService;
    }


}