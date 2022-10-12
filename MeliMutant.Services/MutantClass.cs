using MeliMutant.Services.Dna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Services
{
   public class MutantClass : Segmentation
    {
        public async Task<Boolean> IsMutant(String[] dna)
        {
            await RunSegmentation(dna);

            DnaSearch SearchClass = new();
            Boolean Result = false;

            if (SearchClass.Run(Rows, 4))
            {
                Result = true;
            }
            if (SearchClass.Run(Columns, 4))
            {
                Result = true;
            }
            if (SearchClass.Run(DiagoInv, 4))
            {
                Result = true;
            }
            return Result;
        }


    }
}
