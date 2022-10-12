using MeliMutant.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Core.Interfaces.Repositories
{
    public interface IAnalysisRepository : IBaseRepository<Analysis>
    {
        public Task<int> QuantyHuman();
        public Task<int> QuantyMutant();
    }
}
