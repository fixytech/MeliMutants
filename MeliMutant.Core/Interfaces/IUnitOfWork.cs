using MeliMutant.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAnalysisRepository AnalysisRepository { get; }

        Task<int> CommitAsync();
    }
}
