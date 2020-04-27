using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebServ.Entities;

namespace WebServ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkTerritoriesController : ControllerBase
    {
         private readonly ILogger<ParkTerritoriesController> _logger;

        public ParkTerritoriesController(ILogger<ParkTerritoriesController> logger)
        {
            _logger = logger;
        }
  
        [HttpGet]
        public Park Get()
        {
           return new Park { 
            FullName = "Общество с ограниченной ответственностью Трест «ЗеленСтрой-7»",
            Location = "Главный вход в парк расположен со стороны улицы Косыгина, рельеф местности спокойный, резкопересечённый, с перепадом",
            Water = Waters.yes,   
            PlayGround = PlayGrounds.no,
            SportsGround = SportsGrounds.yes
           };
        }
    }
}
