using AutoMapper;
using MeliMutant.Core.Entities;
using MeliMutant.Core.Interfaces.Services;
using MeliMutant.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeliMutant.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {

        readonly IMutantStats _mutantStats;
   
        public StatsController(IMutantStats mutantStats)
        {
            _mutantStats = mutantStats;
        }

        [HttpGet]
        public async Task<ActionResult<Adn>> Get()
        {
            Adn Adn = await _mutantStats.Stats();
            return Ok(Adn);
        }
    }
}



