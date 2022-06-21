using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class LevelController : ControllerBase
{
    private readonly ILevelService _levelService;

    public LevelController(ILevelService levelService)
    {
        _levelService = levelService;
    }

    //* Update - increase or decrease level

    private int _count = 0;
    private bool UpdateLevel(int id, ILogger _logger)
    {
        if(_logger !=null)
        {
            _count++;
            //^ see line 19
            _logger= _count;
            //^^ uploads to DB
            .Add(_logger);
            return true;
        }
        else
        {
            return false; 
        }
    }
}