using MeliMutant.Core.Entities;
using MeliMutant.Core.Interfaces.Repositories;
using MeliMutant.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Infrastructure.Repositories
{

    public class AnalysisRepository : BaseRepository<Analysis>, IAnalysisRepository
    {
        protected readonly AppDbContext _context;
        public AnalysisRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> QuantyHuman()
        {
            var Result = await _context.Analysis.Where(b => b.Result != true).ToListAsync();
            return Result.Count;
        }
        public async Task<int> QuantyMutant()
        {
            var Result = await _context.Analysis.Where(b => b.Result != false).ToListAsync();
            return Result.Count;
        }
    }
}





