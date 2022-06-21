using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class LevelController : ControllerBase
{
    

    
    // private readonly ILogger<LevelController> _logger;

    // public LevelController(ILogger<LevelController> logger)
    // {
    //     _logger = logger;
    // }
    //typically the logger is intermediate, it will hit the endpoints and tell you when, and how you hit specific endpoints and errors that may occur. 

    //C* Create- 
    
    //* Update - increase or decrease level

    private int _count = 0;
}