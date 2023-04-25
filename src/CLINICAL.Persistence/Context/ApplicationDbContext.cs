using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICAL.Persistence.Context
{
    public class ApplicationDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _conecctionString;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _conecctionString = _configuration.GetConnectionString("ClinicalConnection")!;
        }

        public IDbConnection CreateConnection => new SqlConnection(_conecctionString);
    }
}
