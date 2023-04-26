using AutoMapper;
using CLINICAL.Application.Dtos.Analysis.Response;
using CLINICAL.Application.Interface;
using CLINICAL.Domain.Commons.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICAL.Application.UseCase.UseCases.Analysis.Queries.GetByIdQuery
{
    public class AnalysisByIdHandler : IRequestHandler<GetAnalysisByIdQuery, BaseResponse<GetAnalysisiByIdResponseDto>>
    {
        private readonly IAnalysisRepository _analysisRepository;
        private readonly IMapper _mapper;

        public AnalysisByIdHandler(IAnalysisRepository analysisRepository, IMapper mapper)
        {
            _analysisRepository = analysisRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<GetAnalysisiByIdResponseDto>> Handle(GetAnalysisByIdQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<GetAnalysisiByIdResponseDto>();

            try
            {
                var analysis = await _analysisRepository.AnalysisById(request.AnalysisId);

                if (analysis is null)
                {
                    response.IsSucces = false;
                    response.Message = "No se encontraron registros";
                    return response;
                }

                response.IsSucces = true;
                response.Data = _mapper.Map<GetAnalysisiByIdResponseDto>(analysis);
                response.Message = "Consulta exitosa";
                return response;
            }
            catch (Exception ex)
            {
                response.IsSucces = false;
                response.Message = ex.Message;
                return response;

            }
        }
    }
}
