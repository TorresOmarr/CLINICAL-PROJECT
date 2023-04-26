using CLINICAL.Application.Interface;
using CLINICAL.Domain.Entitites;
using CLINICAL.Persistence.Context;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICAL.Persistence.Repositories
{
    public class AnalysisRepository: IAnalysisRepository
    {
        private readonly ApplicationDbContext _context;
        public AnalysisRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Analysis>> ListAnalysis()
        {
            using var connection = _context.CreateConnection;

            var query = "uspAnalysisList";

            var analisys = await connection.QueryAsync<Analysis>(query, commandType: CommandType.StoredProcedure);

            return analisys;

        }
        public async Task<Analysis> AnalysisById(int analysisId)
        {
            using var connection = _context.CreateConnection;

            var query = "uspAnalysisById";

            var parameters = new DynamicParameters();
            parameters.Add("AnalysisId", analysisId);

            var analisys = await connection
                            .QuerySingleOrDefaultAsync<Analysis>(query, param: parameters, commandType: CommandType.StoredProcedure);
            return analisys;
        }
    }
}
