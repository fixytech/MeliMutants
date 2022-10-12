using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeliMutant.Web.Api
{
    public class ApiResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public bool Result { get; set; }

    }
}
