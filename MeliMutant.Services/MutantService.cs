using MeliMutant.Core.Entities;
using MeliMutant.Core.Interfaces;
using MeliMutant.Core.Interfaces.Services;
using MeliMutant.Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MeliMutant.Services
{
    public class MutantService : IMutantService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MutantService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Analysis> CreateAnalysis(AnalysisMutant newAnalysis)
        {
            MutantDnaValidator validator = new();

            var validationResult = await validator.ValidateAsync(newAnalysis);
            Analysis Analysis = new();
            MutantClass Mutant = new();

            if (validationResult.IsValid)
            {
                Analysis.Dna = JsonSerializer.Serialize(newAnalysis.Dna);
                Analysis.Result = await Mutant.IsMutant(newAnalysis.Dna);

                await _unitOfWork.AnalysisRepository.AddAsync(Analysis);
                await _unitOfWork.CommitAsync();
            }
            else
            {
                throw new ArgumentException(Convert.ToString(validationResult.Errors[0]));
            }
            return Analysis;
        }

    }
}