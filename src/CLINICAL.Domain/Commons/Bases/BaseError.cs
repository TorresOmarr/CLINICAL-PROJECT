using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICAL.Domain.Commons.Bases
{
    public class BaseError
    {
        public string? PropertyName   { get; set; }
        public string? ErrorMessage  { get; set; }
    }
}
