using FluentValidation;
using MeliMutant.Core.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MeliMutant.Services.Validators
{
    public class MutantDnaValidator : AbstractValidator<AnalysisMutant>
    {
        public MutantDnaValidator()
        {
            RuleFor(x => x.Dna)
                .NotEmpty()
                .Must(x => SAFE_JSON(x));
        }

        private bool SAFE_JSON(String[] Dna)
        {
            Regex regex = new Regex("\\[\"[ATGC][ATGC][ATGC][ATGC][ATGC][ATGC]\",\"[ATGC][ATGC][ATGC][ATGC][ATGC][ATGC]\",\"[ATGC][ATGC][ATGC][ATGC][ATGC][ATGC]\",\"[ATGC][ATGC][ATGC][ATGC][ATGC][ATGC]\",\"[ATGC][ATGC][ATGC][ATGC][ATGC][ATGC]\",\"[ATGC][ATGC][ATGC][ATGC][ATGC][ATGC]\"\\]", RegexOptions.IgnoreCase);
            return regex.IsMatch(JsonSerializer.Serialize(Dna));
        }
    }
}
