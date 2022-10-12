using AutoMapper;
using MeliMutant.Core.Entities;
using MeliMutant.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeliMutant.Web.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Analysis, AnalysisModel>();
            CreateMap<Analysis, AnalysisMutant>();

            CreateMap<AnalysisModel, Analysis>();
            CreateMap<AnalysisMutant, Analysis>();

        }
    }
}
