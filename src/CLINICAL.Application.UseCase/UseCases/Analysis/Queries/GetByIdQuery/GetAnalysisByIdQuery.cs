using CLINICAL.Application.Dtos.Analysis.Response;
using CLINICAL.Domain.Commons.Bases;
using MediatR;

namespace CLINICAL.Application.UseCase.UseCases.Analysis.Queries.GetByIdQuery
{
    public class GetAnalysisByIdQuery: IRequest<BaseResponse<GetAnalysisiByIdResponseDto>>
    {
        public int AnalysisId { get; set; }
    }
}
