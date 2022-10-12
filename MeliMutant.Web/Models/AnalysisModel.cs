using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeliMutant.Web.Models
{
    public class AnalysisModel
    {
        public int Id { get; set; }
        public string Dna { get; set; }
        public bool Result { get; set; }
    }
}
