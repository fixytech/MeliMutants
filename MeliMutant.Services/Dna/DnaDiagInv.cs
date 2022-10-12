using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Services.Dna
{
    public class DnaDiagInv
    {
        public String[] Run(String[] Rows)
        {
            String[] DiagoInv = new String[Rows[0].Length + Rows.Length - 1];
            // Establezco las variables

            int diagInv = 0;
            int addRow;
            int addCol;

            // Recorro las filas
            for (int r = 0; r < Rows.Length; r++)
            {
                // Si es la primer fila
                if (r == 0)
                {
                    // Recorro las columnas diagonal para atras
                    for (int c = 0; c < Rows[0].Length; c++)
                    {
                        addCol = c;
                        addRow = 0;
                        while (addRow < Rows.Length)
                        {
                            if (addCol < Rows[0].Length)
                            {
                                DiagoInv[diagInv] += Convert.ToString(Rows[addRow][addCol]);
                            }
                            addRow += 1;
                            addCol += 1;
                        }
                        // Agrego diagonal invertida
                        diagInv += 1;
                    }
                }
                // si la fila es mayo a 0
                else
                {
                    addCol = 0;
                    addRow = r;
                    // recorro diagnoles invertidas
                    while (addRow < Rows.Length)
                    {
                        DiagoInv[diagInv] += Convert.ToString(Rows[addRow][addCol]);

                        addRow += 1;
                        addCol += 1;
                    }
                    // sumo diagonal invertida
                    diagInv += 1;
                }
            }
            return DiagoInv;
        }
    }
}
