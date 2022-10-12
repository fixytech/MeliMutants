using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MeliMutant.Services.Dna
{
    public class Segmentation
    {
        protected String[] DiagoInv, Rows, Columns;

        public async Task RunSegmentation(String[] rows)
        {
            Rows = rows;

            await Task.Run(()=>{

                DnaColums ColumClass = new();
                Columns = ColumClass.Run(Rows);

                DnaDiagInv DnaDiagInvClass = new();
                DiagoInv = DnaDiagInvClass.Run(Rows);

            });
        }
    }
}
