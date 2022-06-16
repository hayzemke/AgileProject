using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class LevelController : ControllerBase
{
    private readonly ILogger<LevelController> _logger;

    public LevelController(ILogger<LevelController> logger)
    {
        _logger = logger;
    }

    //* Update - increase or decrease level
}