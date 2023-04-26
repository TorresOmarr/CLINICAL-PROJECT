using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICAL.Application.Dtos.Analysis.Response
{
    public class GetAnalysisiByIdResponseDto
    {
        public int AnalysisId { get; set; }
        public string? Name { get; set; }
    }
}
