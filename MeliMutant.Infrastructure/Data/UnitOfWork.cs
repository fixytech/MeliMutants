using MeliMutant.Core.Interfaces;
using MeliMutant.Core.Interfaces.Repositories;
using MeliMutant.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IAnalysisRepository _analysisRepository;
   

        public UnitOfWork(AppDbContext context)
        {
            this._context = context;
        }

        public IAnalysisRepository AnalysisRepository => _analysisRepository ??= new AnalysisRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
