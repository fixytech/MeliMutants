using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Services.Dna
{
    public class DnaColums
    {
        public String[] Run(String[] Rows)
        {
            String[] Columns = new String[Rows[0].Length];
            // Recorro las filas
            for (int r = 0; r < Rows.Length; r++)
            {
                // Recorro los caracteres de la fila
                for (int c = 0; c < Rows[r].Length; c++)
                {
                    // Inserto los datos en las columnas
                    Columns[c] += Convert.ToString(Rows[r][c]);
                }
            }

            return Columns;
        }
    }
}
