using AutoMapper;
using MeliMutant.Core.Entities;
using MeliMutant.Core.Interfaces.Services;
using MeliMutant.Web.Api;
using MeliMutant.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MeliMutant.Web.Controllers
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class MutantController : ControllerBase
    {
        readonly IMutantService _analysisService;
        readonly IMapper _mapper;

        // GET: AnalysisController
        public MutantController(IMutantService analysisService, IMapper mapper)
        {
            _analysisService = analysisService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<AnalysisModel>> Post([FromBody] AnalysisMutant analysis)
        {
            try
            {
                var createdAnalysis =
                    await _analysisService.CreateAnalysis(analysis);

                if (createdAnalysis.Result)
                {
                    return new ObjectResult(new ApiResponse() { Status = 403, Message = "Mutant", Result = true }) { StatusCode = 403 };
                }
                else
                {
                    return new ObjectResult(new ApiResponse() { Status = 200, Message = "Mutant", Result = false }) { StatusCode = 200 };
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
