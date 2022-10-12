using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Services.Dna
{
   public class DnaSearch
    {
        public Boolean Run(String[] dna, int matchNumber = 4)
        {
            Boolean Result = false;
            int Count = 0;
            string ChPrev = null;

                for (int r = 0; r < dna.Length; r++)
                {
                    for (int c = 0; c < dna[r].Length; c++)
                    {
                        if (c == 0)
                        {
                            ChPrev = Convert.ToString(dna[r][c]);
                            Count = 0;
                        }
                        if (ChPrev == Convert.ToString(dna[r][c]))
                        {
                            Count += 1;
                        }
                        else
                        {
                            Count = 0;
                        }

                        ChPrev = Convert.ToString(dna[r][c]);

                        if (Count >= matchNumber)
                        {
                        Result = true;
                        }
                       
                    }
                    ChPrev = null;
                }
            return Result;
        }
    }
}
