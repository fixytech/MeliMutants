using MeliMutant.Core.Entities;
using MeliMutant.Core.Interfaces;
using MeliMutant.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Services
{
   public class StatsService : IMutantStats
    {
        private readonly IUnitOfWork _unitOfWork;
        public StatsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Adn> Stats()
        {
            Adn AdnObject = new Adn();
            StatsClass Stats = new StatsClass();

            AdnObject.Count_human_dna = await _unitOfWork.AnalysisRepository.QuantyHuman();
            AdnObject.Count_mutant_dna = await _unitOfWork.AnalysisRepository.QuantyMutant();
            AdnObject.Ratio = Stats.Ratio(AdnObject.Count_human_dna, AdnObject.Count_mutant_dna);

            return AdnObject;
        }
    }
}
