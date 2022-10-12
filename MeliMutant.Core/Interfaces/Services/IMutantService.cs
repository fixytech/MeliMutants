﻿using MeliMutant.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Core.Interfaces.Services
{
    public interface IMutantService
    {
      
       
        Task<Analysis> CreateAnalysis(AnalysisMutant newAnalysis);
        
    }
}
